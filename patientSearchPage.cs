using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class patientSearchPage : UserControl
    {
        private string _prescriptionsFile;

        public patientSearchPage()
        {
            InitializeComponent();
            _prescriptionsFile = Path.Combine(Application.StartupPath, "prescriptions.txt");

            SetupGrid();
            LoadPatientData();
        }

        private void SetupGrid()
        {
            dgvPatient.Rows.Clear();
            dgvPatient.Columns.Clear();

            dgvPatient.Columns.Add("PatientName", "Patient Name");
            dgvPatient.Columns.Add("Medication", "Medication");

            dgvPatient.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPatient.ReadOnly = true;
            dgvPatient.AllowUserToAddRows = false;
        }

        public void LoadPatientData(string filter = "")
        {
            if (!File.Exists(_prescriptionsFile)) return;

            try
            {
                dgvPatient.Rows.Clear();
                string[] lines = File.ReadAllLines(_prescriptionsFile);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 7)
                    {
                        string patientName = parts[1];
                        string medication = parts[2];

                        if (string.IsNullOrEmpty(filter) || patientName.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            dgvPatient.Rows.Add(patientName, medication);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching patients: {ex.Message}");
            }
        }

        private void patientSearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadPatientData(patientSearchBox.Text.Trim());
        }
    }
}