using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class InventoryPage : UserControl
    {
        private string _userName;
        private string _inventoryFile;
        private string _medsFile;
        private string _auditFile;

        public InventoryPage(string userName)
        {
            InitializeComponent();
            _userName = userName;

            _inventoryFile = Path.Combine(Application.StartupPath, "inventory.txt");
            _medsFile = Path.Combine(Application.StartupPath, "medications.txt");
            _auditFile = Path.Combine(Application.StartupPath, "audit.txt");

            if (!File.Exists(_auditFile)) File.Create(_auditFile).Close();

            SetupGrid();
            LoadInventoryData();
            PopulateMedicationList();
        }

        private void SetupGrid()
        {
            dgvMedications.Rows.Clear();
            dgvMedications.Columns.Clear();

            dgvMedications.Columns.Add("MedName", "Medication Name");
            dgvMedications.Columns.Add("Quantity", "Stock Level");
            dgvMedications.Columns.Add("LastUpdated", "Last Updated");

            dgvMedications.Columns["MedName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMedications.ReadOnly = true;
            dgvMedications.AllowUserToAddRows = false;
        }

        private void PopulateMedicationList()
        {
            if (!File.Exists(_medsFile)) return;

            comboBoxMedication.Items.Clear();
            try
            {
                foreach (string line in File.ReadAllLines(_medsFile))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length > 0)
                    {
                        comboBoxMedication.Items.Add(parts[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating medication list: {ex.Message}");
            }
        }

        public void LoadInventoryData(string filter = "")
        {
            if (!File.Exists(_inventoryFile)) return;

            try
            {
                dgvMedications.Rows.Clear();
                foreach (string line in File.ReadAllLines(_inventoryFile))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 2)
                    {
                        string name = parts[0];
                        string quantity = parts[1];
                        string date = parts.Length > 2 ? parts[2] : "N/A";

                        if (string.IsNullOrEmpty(filter) || name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            dgvMedications.Rows.Add(name, quantity, date);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading inventory: {ex.Message}");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string selectedMed = comboBoxMedication.SelectedItem?.ToString();
            int addQty = (int)nmbrMedicationInventory.Value;

            if (string.IsNullOrEmpty(selectedMed) || addQty <= 0)
            {
                MessageBox.Show("Please select a medication and enter a valid quantity.", "Input Error");
                return;
            }

            try
            {
                List<string> updatedLines = new List<string>();
                bool found = false;

                if (File.Exists(_inventoryFile))
                {
                    var lines = File.ReadAllLines(_inventoryFile);
                    foreach (var line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0].Equals(selectedMed, StringComparison.OrdinalIgnoreCase))
                        {
                            int currentQty = int.Parse(parts[1]);
                            int newQty = currentQty + addQty;
                            updatedLines.Add($"{parts[0]},{newQty},{DateTime.Now:yyyy-MM-dd}");
                            found = true;
                        }
                        else
                        {
                            updatedLines.Add(line);
                        }
                    }
                }

                if (!found)
                {
                    updatedLines.Add($"{selectedMed},{addQty},{DateTime.Now:yyyy-MM-dd}");
                }

                File.WriteAllLines(_inventoryFile, updatedLines);

                string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss},{_userName},Added {addQty} units to {selectedMed} stock.";
                File.AppendAllText(_auditFile, logEntry + Environment.NewLine);

                MessageBox.Show($"{addQty} units added to {selectedMed}. Action logged to audit trail.", "Success");

                nmbrMedicationInventory.Value = nmbrMedicationInventory.Minimum;
                LoadInventoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing inventory update: {ex.Message}");
            }
        }

        private void medicationSearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadInventoryData(medicationSearchBox.Text.Trim());
        }
    }
}