using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class medicationSearch : UserControl
    {
        private string _medsFile;
        private string _userRole;

        public medicationSearch(string role)
        {
            InitializeComponent();
            _userRole = role;
            _medsFile = Path.Combine(Application.StartupPath, "medications.txt");

            grpNewMedication.Visible = (_userRole == "Administrator");

            SetupGrid();
            LoadMedications();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string medName = txtMeds.Text.Trim();
            decimal maxDosage = nmbrMaxDosage.Value;

            if (string.IsNullOrWhiteSpace(medName) || maxDosage <= 0)
            {
                MessageBox.Show("Please enter a valid medication name and max dosage.", "Input Error");
                return;
            }

            try
            {
                if (File.Exists(_medsFile))
                {
                    var existingMeds = File.ReadAllLines(_medsFile);
                    foreach (var line in existingMeds)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length > 0 && parts[0].Equals(medName, StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("This medication already exists in the system.", "Duplicate Entry");
                            return;
                        }
                    }
                }

                string record = $"{medName},{maxDosage}";
                File.AppendAllText(_medsFile, record + Environment.NewLine);

                txtMeds.Clear();
                nmbrMaxDosage.Value = nmbrMaxDosage.Minimum;
                MessageBox.Show($"{medName} has been added to the system.", "Success");
                LoadMedications();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving medication: {ex.Message}", "File Error");
            }
        }

        private void medicationSearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadMedications(medicationSearchBox.Text.Trim());
        }

        private void SetupGrid()
        {
            dgvMedications.Rows.Clear();
            dgvMedications.Columns.Clear();
            dgvMedications.Columns.Add("Name", "Medication Name");
            dgvMedications.Columns.Add("MaxDosage", "Max Dosage (mg)");

            dgvMedications.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadMedications(string filter = "")
        {
            if (!File.Exists(_medsFile)) return;

            try
            {
                dgvMedications.Rows.Clear();
                var lines = File.ReadAllLines(_medsFile);

                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 2)
                    {
                        string name = parts[0];
                        string dosage = parts[1];

                        if (string.IsNullOrEmpty(filter) || name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            dgvMedications.Rows.Add(name, dosage);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medications: {ex.Message}");
            }
        }
    }
}