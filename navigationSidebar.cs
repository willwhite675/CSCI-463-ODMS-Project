using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class navigationSidebar : UserControl
    {
        public event EventHandler LogoutRequested;
        public event EventHandler PrescriptionsRequested;
        public event EventHandler HomeRequested;
        public event EventHandler MedicationsRequested;

        public navigationSidebar()
        {
            InitializeComponent();
        }

        private void logoutNavButton_Click(object sender, EventArgs e)
        {
            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }

        private void prescriptionsNavButton_Click(object sender, EventArgs e)
        {
            PrescriptionsRequested?.Invoke(this, EventArgs.Empty);
        }

        private void homeNavButton_Click(object sender, EventArgs e)
        {
            HomeRequested?.Invoke(this, EventArgs.Empty);
        }

        private void medicationSearchNavButton_Click(object sender, EventArgs e)
        {
            MedicationsRequested?.Invoke(this, EventArgs.Empty);
        }

        public void SetupRoleBasedNavigation(string role)
        {
            patientSearchNavButton.Visible = false;
            medicationSearchNavButton.Visible = false;
            alertNavButton.Visible = false;
            prescriptionsNavButton.Visible = false;
            inventoryNavButton.Visible = false;
            userManagementNavButton.Visible = false;
            auditNavButton.Visible = false;

            switch (role)
            {
                case "Doctor":
                    patientSearchNavButton.Visible = true;
                    medicationSearchNavButton.Visible = true;
                    prescriptionsNavButton.Visible = true;
                    break;

                case "Nurse":
                    patientSearchNavButton.Visible = true;
                    medicationSearchNavButton.Visible = true;
                    break;

                case "Administrator":
                    inventoryNavButton.Visible = true;
                    userManagementNavButton.Visible = true;
                    auditNavButton.Visible = true;
                    medicationSearchNavButton.Visible = true;
                    break;
            }

            profileNavButton.Visible = true;
            logoutNavButton.Visible = true;
            homeNavButton.Visible = true;
        }

        
    }
}