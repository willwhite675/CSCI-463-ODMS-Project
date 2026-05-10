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
        private string _userName;
        private string _userRole;
        private string _medsFile;
        private string _inventoryFile;
        private string _auditFile;

        public medicationSearch(string name, string role)
        {
            InitializeComponent();
            _userName = name;
            _userRole = role;

            _medsFile = Path.Combine(Application.StartupPath, "medications.txt");
            _inventoryFile = Path.Combine(Application.StartupPath, "inventory.txt");
            _auditFile = Path.Combine(Application.StartupPath, "audit.txt");

            EnsureFilesExist();

            grpAddMedication.Visible = (_userRole == "Administrator");

            SetupGrid();
            LoadMedications();
        }

        private void EnsureFilesExist()
        {
            try
            {
                if (!File.Exists(_medsFile)) File.Create(_medsFile).Close();
                if (!File.Exists(_inventoryFile)) File.Create(_inventoryFile).Close();
                if (!File.Exists(_auditFile)) File.Create(_auditFile).Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing data files: {ex.Message}", "System Error");
            }
        }

        private void submit_Click(object sender, EventArgs e)
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

                File.AppendAllText(_medsFile, $"{medName},{maxDosage}" + Environment.NewLine);

                string dateStr = DateTime.Now.ToString("yyyy-MM-dd");
                File.AppendAllText(_inventoryFile, $"{medName},100,{dateStr}" + Environment.NewLine);

                string auditEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss},{_userName},Created new medication: {medName} with max dosage {maxDosage}mg.";
                File.AppendAllText(_auditFile, auditEntry + Environment.NewLine);

                MessageBox.Show($"{medName} added to system, inventory, and audit log.", "Success");

                txtMeds.Clear();
                nmbrMaxDosage.Value = nmbrMaxDosage.Minimum;

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
            dgvMedications.ReadOnly = true;
            dgvMedications.AllowUserToAddRows = false;
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