using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class auditPage : UserControl
    {
        private string _auditFile;

        public auditPage()
        {
            InitializeComponent();
            _auditFile = Path.Combine(Application.StartupPath, "audit.txt");

            SetupGrid();
            LoadAuditData();
        }

        private void SetupGrid()
        {
            dgvAudit.Rows.Clear();
            dgvAudit.Columns.Clear();

            dgvAudit.Columns.Add("Timestamp", "Timestamp");
            dgvAudit.Columns.Add("User", "User");
            dgvAudit.Columns.Add("Action", "Action");

            dgvAudit.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAudit.ReadOnly = true;
            dgvAudit.AllowUserToAddRows = false;
        }

        public void LoadAuditData(string filter = "")
        {
            if (!File.Exists(_auditFile)) return;

            try
            {
                dgvAudit.Rows.Clear();
                var lines = File.ReadAllLines(_auditFile);

                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3)
                    {
                        string timestamp = parts[0];
                        string user = parts[1];
                        string action = parts[2];

                        if (string.IsNullOrEmpty(filter) ||
                            timestamp.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            user.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            action.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            dgvAudit.Rows.Add(timestamp, user, action);
                        }
                    }
                }

                dgvAudit.Sort(dgvAudit.Columns["Timestamp"], ListSortDirection.Descending);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading audit logs: {ex.Message}");
            }
        }

        private void auditSearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadAuditData(auditSearchBox.Text.Trim());
        }
    }
}