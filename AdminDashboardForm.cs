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
        }
    }
}
