using System;
using System.IO;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class PrescriptionForm : UserControl
    {
        private string _doctorName;
        private string _prescriptionsFile;

        public PrescriptionForm(string doctorName)
        {
            InitializeComponent();
            _doctorName = doctorName;
            _prescriptionsFile = Path.Combine(Application.StartupPath, "prescriptions.txt");
            LoadPrescriptions();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatient.Text) ||
                string.IsNullOrWhiteSpace(txtMedication.Text) ||
                string.IsNullOrWhiteSpace(txtDosage.Text))
            {
                MessageBox.Show("Patient name, medication, and dosage are required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string instructions = txtInstructions.Text.Trim().Replace(",", ";");
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string line = $"{_doctorName},{txtPatient.Text.Trim()},{txtMedication.Text.Trim()},{txtDosage.Text.Trim()},{instructions},{date}";
            File.AppendAllText(_prescriptionsFile, line + Environment.NewLine);

            txtPatient.Clear();
            txtMedication.Clear();
            txtDosage.Clear();
            txtInstructions.Clear();

            LoadPrescriptions();
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

            if (!File.Exists(_prescriptionsFile))
                return;

            foreach (string line in File.ReadAllLines(_prescriptionsFile))
            {
                string[] parts = line.Split(',');
                if (parts.Length < 6 || parts[0] != _doctorName)
                    continue;

                dgvPrescriptions.Rows.Add(parts[5], parts[1], parts[2], parts[3], parts[4]);
            }
        }
    }
}
