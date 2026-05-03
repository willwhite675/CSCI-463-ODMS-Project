using System;
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

        public PrescriptionForm(string doctorName)
        {
            InitializeComponent();
            _doctorName = doctorName;
            _prescriptionsFile = Path.Combine(Application.StartupPath, "prescriptions.txt");
            _alertsFile = Path.Combine(Application.StartupPath, "alerts.txt");
            LoadPrescriptions();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatient.Text) ||
                string.IsNullOrWhiteSpace(txtMedication.Text) ||
                nmbrDosage.Value <= 0)
            {
                MessageBox.Show("Patient name, medication, and a valid dosage are required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string patient = txtPatient.Text.Trim();
            string medication = txtMedication.Text.Trim();
            string dosage = nmbrDosage.Value.ToString() + "mg";
            string instructions = txtInstructions.Text.Trim().Replace(",", ";");
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            try
            {
                string line = $"{_doctorName},{patient},{medication},{dosage},{instructions},{date}";
                File.AppendAllText(_prescriptionsFile, line + Environment.NewLine);

                if (nmbrDosage.Value > 50)
                {
                    string alertLine = $"{date},{_doctorName},{patient},{medication},{dosage},Overprescription Threshold Exceeded";
                    File.AppendAllText(_alertsFile, alertLine + Environment.NewLine);

                    MessageBox.Show("High dosage detected. A safety alert has been logged.", "Safety Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                txtPatient.Clear();
                txtMedication.Clear();
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