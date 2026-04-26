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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard();

            dashboard.StartPosition = FormStartPosition.Manual;
            dashboard.Location = this.Location;
            dashboard.Size = this.Size;

            dashboard.WindowState = this.WindowState;

            dashboard.Show();
            this.Hide();
        }
    }
}
