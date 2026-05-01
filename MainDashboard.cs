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
    public partial class MainDashboard : Form
    {
        private string _userName;
        private string _userRole;

        public MainDashboard(string name, string role)
        {
            InitializeComponent();
            _userName = name;
            _userRole = role;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            /*lblUserName.Text = $"User: {_userName}";
            lblRole.Text = $"Role: {_userRole}";*/

            navigationSidebar1.SetupRoleBasedNavigation(_userRole);
        }
    }
}
