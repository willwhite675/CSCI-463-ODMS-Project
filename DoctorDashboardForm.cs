using System;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class DoctorDashboardForm : Form
    {
        private string _userName;
        private string _userRole;

        public DoctorDashboardForm(string name, string role)
        {
            InitializeComponent();
            _userName = name;
            _userRole = role;
        }

        private void DoctorDashboardForm_Load(object sender, EventArgs e)
        {
            this.Text = $"ODMS - Doctor Dashboard ({_userName})";
            navigationSidebar1.SetupRoleBasedNavigation(_userRole);
            navigationSidebar1.LogoutRequested += (s, ev) => { new Login().Show(); this.Close(); };
            navigationSidebar1.PrescriptionsRequested += (s, ev) =>
            {
                contentPanel.Controls.Clear();
                var prescription = new PrescriptionForm(_userName);
                contentPanel.Controls.Add(prescription);
            };
        }
    }
}
