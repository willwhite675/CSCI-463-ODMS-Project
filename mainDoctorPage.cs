using System;
using System.IO;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class mainDoctorPage : UserControl
    {
        private string _userName;
        private string _prescriptionsFile;

        public mainDoctorPage(string name)
        {
            InitializeComponent();
            _userName = name;
            _prescriptionsFile = Path.Combine(Application.StartupPath, "prescriptions.txt");

            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            recentPrescriptions.Rows.Clear();
            recentPrescriptions.Columns.Clear();

            recentPrescriptions.Columns.Add("Date", "Issued Date");
            recentPrescriptions.Columns.Add("Expiration", "Expiration Date");
            recentPrescriptions.Columns.Add("Patient", "Patient Name");
            recentPrescriptions.Columns.Add("Medication", "Medication");
            recentPrescriptions.Columns.Add("Dosage", "Dosage");
            recentPrescriptions.Columns.Add("Instructions", "Instructions");

            recentPrescriptions.Columns["Instructions"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadData()
        {
            if (!File.Exists(_prescriptionsFile)) return;

            try
            {
                recentPrescriptions.Rows.Clear();
                foreach (string line in File.ReadAllLines(_prescriptionsFile))
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 7 && parts[0] == _userName)
                    {
                        recentPrescriptions.Rows.Add(
                            parts[5],
                            parts[6],
                            parts[1],
                            parts[2],
                            parts[3],
                            parts[4]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading prescriptions: {ex.Message}");
            }
        }
    }
}