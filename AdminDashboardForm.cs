using System;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class AdminDashboardForm : Form
    {
        private string _userName;
        private string _userRole;

        public AdminDashboardForm(string name, string role)
        {
            InitializeComponent();
            _userName = name;
            _userRole = role;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            this.Text = $"ODMS - Admin Dashboard ({_userName})";

            navigationSidebar1.SetupRoleBasedNavigation(_userRole);

            navigationSidebar1.LogoutRequested += (s, ev) => { new Login().Show(); this.Close(); };

            navigationSidebar1.HomeRequested += (s, ev) => ShowHome();

            navigationSidebar1.MedicationsRequested += (s, ev) =>
            {
                contentPanel.Controls.Clear();
                var meds = new medicationSearch(_userName, _userRole);
                meds.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(meds);
            };

            navigationSidebar1.InventoryRequested += (s, ev) =>
            {
                contentPanel.Controls.Clear();
                var inventory = new InventoryPage(_userName);
                inventory.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(inventory);
            };

            navigationSidebar1.AuditRequested += (s, ev) =>
            {
                contentPanel.Controls.Clear();
                var audit = new auditPage();
                audit.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(audit);
            };

            ShowHome();
        }

        private void ShowHome()
        {
            contentPanel.Controls.Clear();
            var home = new mainAdminPage();
            home.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(home);
        }
    }
}