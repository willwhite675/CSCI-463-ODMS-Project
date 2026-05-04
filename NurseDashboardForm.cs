using System;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class NurseDashboardForm : Form
    {
        private string _userName;
        private string _userRole;

        public NurseDashboardForm(string name, string role)
        {
            InitializeComponent();
            _userName = name;
            _userRole = role;
        }

        private void NurseDashboardForm_Load(object sender, EventArgs e)
        {
            this.Text = $"ODMS - Nurse Dashboard ({_userName})";

            navigationSidebar1.SetupRoleBasedNavigation(_userRole);

            navigationSidebar1.LogoutRequested += (s, ev) => { new Login().Show(); this.Close(); };

            navigationSidebar1.MedicationsRequested += (s, ev) =>
            {
                contentPanel.Controls.Clear();
                var meds = new medicationSearch(_userRole);
                meds.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(meds);
            };

            navigationSidebar1.HomeRequested += (s, ev) =>
            {
                ShowHome();
            };

            ShowHome();
        }

        private void ShowHome()
        {
            contentPanel.Controls.Clear();
            var home = new mainNursePage();
            home.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(home);
        }
    }
}