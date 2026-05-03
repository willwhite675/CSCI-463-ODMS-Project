using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class PrescriptionForm : UserControl
    {
        private string _doctorName;
        private string _prescriptionsFile;
        private string _alertsFile;
        private string _medsFile;

        private Dictionary<string, decimal> _medicationLimits = new Dictionary<string, decimal>();

        public PrescriptionForm(string doctorName)
        {
            InitializeComponent();
            _doctorName = doctorName;
            _prescriptionsFile = Path.Combine(Application.StartupPath, "prescriptions.txt");
            _alertsFile = Path.Combine(Application.StartupPath, "alerts.txt");
            _medsFile = Path.Combine(Application.StartupPath, "medications.txt");

            LoadPrescriptions();
            PopulateMedicationList();
        }

        private void PopulateMedicationList()
        {
            if (!File.Exists(_medsFile)) return;

            comboBoxMedication.Items.Clear();
            _medicationLimits.Clear();

            try
            {
                foreach (string line in File.ReadAllLines(_medsFile))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 2)
                    {
                        string name = parts[0];
                        if (decimal.TryParse(parts[1], out decimal maxDosage))
                        {
                            comboBoxMedication.Items.Add(name);
                            if (!_medicationLimits.ContainsKey(name))
                                _medicationLimits.Add(name, maxDosage);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medication list: {ex.Message}");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string selectedMed = comboBoxMedication.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(txtPatient.Text) ||
                string.IsNullOrEmpty(selectedMed) ||
                nmbrDosage.Value <= 0)
            {
                MessageBox.Show("Patient name, medication selection, and a valid dosage are required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string patient = txtPatient.Text.Trim();
            string dosage = nmbrDosage.Value.ToString() + "mg";
            string instructions = txtInstructions.Text.Trim().Replace(",", ";");
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            try
            {
                string line = $"{_doctorName},{patient},{selectedMed},{dosage},{instructions},{date}";
                File.AppendAllText(_prescriptionsFile, line + Environment.NewLine);

                if (_medicationLimits.ContainsKey(selectedMed))
                {
                    decimal maxAllowed = _medicationLimits[selectedMed];

                    if (nmbrDosage.Value > maxAllowed)
                    {
                        string alertLine = $"{date},{_doctorName},{patient},{selectedMed},{dosage},Overprescription: {maxAllowed}mg";
                        File.AppendAllText(_alertsFile, alertLine + Environment.NewLine);

                        MessageBox.Show($"Warning: This dosage exceeds the maximum limit for {selectedMed} ({maxAllowed}mg). An alert has been logged.",
                            "Safety Threshold Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                txtPatient.Clear();
                comboBoxMedication.SelectedIndex = -1;
                nmbrDosage.Value = nmbrDosage.Minimum;
                txtInstructions.Clear();

                LoadPrescriptions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing prescription: {ex.Message}");
            }
        }

        private void LoadPrescriptions()
        {
            dgvPrescriptions.Rows.Clear();
            dgvPrescriptions.Columns.Clear();

            dgvPrescriptions.Columns.Add("Date", "Date");
            dgvPrescriptions.Columns.Add("Patient", "Patient Name");
            dgvPrescriptions.Columns.Add("Medication", "Medication");
            dgvPrescriptions.Columns.Add("Dosage", "Dosage");
            dgvPrescriptions.Columns.Add("Instructions", "Instructions");

            if (!File.Exists(_prescriptionsFile)) return;

            foreach (string line in File.ReadAllLines(_prescriptionsFile))
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 6 && parts[0] == _doctorName)
                {
                    dgvPrescriptions.Rows.Add(parts[5], parts[1], parts[2], parts[3], parts[4]);
                }
            }
        }
    }
}