using System;
using System.IO;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class mainAdminPage : UserControl
    {
        private string _alertsFile;

        public mainAdminPage()
        {
            InitializeComponent();

            _alertsFile = Path.Combine(Application.StartupPath, "alerts.txt");

            SetupAlertsGrid();
            LoadRecentAlerts();
        }

        private void SetupAlertsGrid()
        {
            recentAlerts.Rows.Clear();
            recentAlerts.Columns.Clear();

            recentAlerts.Columns.Add("Date", "Date");
            recentAlerts.Columns.Add("User", "Doctor/User");
            recentAlerts.Columns.Add("Patient", "Patient");
            recentAlerts.Columns.Add("Medication", "Medication");
            recentAlerts.Columns.Add("Dosage", "Dosage");
            recentAlerts.Columns.Add("Reason", "Alert Reason");

            recentAlerts.Columns["Reason"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadRecentAlerts()
        {
            if (!File.Exists(_alertsFile)) return;

            try
            {
                recentAlerts.Rows.Clear();

                foreach (string line in File.ReadAllLines(_alertsFile))
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 6)
                    {
                        recentAlerts.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]);
                    }
                }

                if (recentAlerts.Rows.Count > 0)
                {
                    recentAlerts.FirstDisplayedScrollingRowIndex = recentAlerts.Rows.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading audit alerts: {ex.Message}", "System Error");
            }
        }
    }
}