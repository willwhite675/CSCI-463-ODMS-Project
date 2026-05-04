using System;
using System.IO;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class mainNursePage : UserControl
    {
        private string _prescriptionsFile;

        public mainNursePage()
        {
            InitializeComponent();
            _prescriptionsFile = Path.Combine(Application.StartupPath, "prescriptions.txt");

            SetupGrid();
            LoadUpcomingExpirations();
        }

        private void SetupGrid()
        {
            upcomingExpirations.Rows.Clear();
            upcomingExpirations.Columns.Clear();

            upcomingExpirations.Columns.Add("ExpireDate", "Expiration Date");
            upcomingExpirations.Columns.Add("Patient", "Patient Name");
            upcomingExpirations.Columns.Add("Medication", "Medication");
            upcomingExpirations.Columns.Add("Dosage", "Dosage");
            upcomingExpirations.Columns.Add("Doctor", "Prescribing Doctor");

            upcomingExpirations.Columns["Medication"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadUpcomingExpirations()
        {
            if (!File.Exists(_prescriptionsFile)) return;

            try
            {
                upcomingExpirations.Rows.Clear();
                DateTime today = DateTime.Today;
                DateTime twoWeeksFromNow = today.AddDays(14);

                foreach (string line in File.ReadAllLines(_prescriptionsFile))
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 7)
                    {
                        if (DateTime.TryParse(parts[6], out DateTime expireDate))
                        {
                            if (expireDate >= today && expireDate <= twoWeeksFromNow)
                            {
                                upcomingExpirations.Rows.Add(
                                    expireDate.ToString("yyyy-MM-dd"),
                                    parts[1], // Patient
                                    parts[2], // Medication
                                    parts[3], // Dosage
                                    parts[0]  // Doctor
                                );
                            }
                        }
                    }
                }

                upcomingExpirations.Sort(upcomingExpirations.Columns["ExpireDate"], System.ComponentModel.ListSortDirection.Ascending);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading expiration data: {ex.Message}");
            }
        }
    }
}