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

            navigationSidebar1.HomeRequested += (s, ev) => ShowHome();

            navigationSidebar1.PrescriptionsRequested += (s, ev) =>
            {
                contentPanel.Controls.Clear();
                var form = new PrescriptionForm(_userName);
                form.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(form);
            };

            navigationSidebar1.MedicationsRequested += (s, ev) =>
            {
                contentPanel.Controls.Clear();
                var meds = new medicationSearch(_userRole);
                meds.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(meds);
            };

            ShowHome();
        }

        private void ShowHome()
        {
            contentPanel.Controls.Clear();
            var home = new mainDoctorPage(_userName);
            home.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(home);
        }
    }
}