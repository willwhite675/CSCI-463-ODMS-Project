using System;
using System.IO;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class Login : Form
    {
        private const string UsersFilePath = "users.txt";

        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string enteredUser = username.Text.Trim();
            string enteredPass = password.Text.Trim();

            if (!File.Exists(UsersFilePath))
            {
                MessageBox.Show("No user accounts found. Please register first.");
                return;
            }

            try
            {
                foreach (string line in File.ReadLines(UsersFilePath))
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 5)
                    {
                        string savedUser = parts[0];
                        string savedPass = parts[1];
                        string firstName = parts[2];
                        string role = parts[4];

                        if (enteredUser == savedUser && enteredPass == savedPass)
                        {
                            OpenDashboard(role, firstName);
                            return;
                        }
                    }
                }

                MessageBox.Show("Incorrect username or password", "Login Failed");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"System error: {ex.Message}");
            }
        }

        private void OpenDashboard(string role, string name)
        {

            if (role == "Nurse")
            {
                NurseDashboardForm nurseDashboard = new NurseDashboardForm();
                nurseDashboard.StartPosition = FormStartPosition.Manual;
                nurseDashboard.Location = this.Location;
                nurseDashboard.Size = this.Size;
                nurseDashboard.WindowState = this.WindowState;

                nurseDashboard.Show();
                this.Hide();
            }
            else if (role == "Doctor") 
            { 
                DoctorDashboardForm doctorDashboard = new DoctorDashboardForm();
                doctorDashboard.StartPosition = FormStartPosition.Manual;
                doctorDashboard.Location = this.Location;
                doctorDashboard.Size = this.Size;
                doctorDashboard.WindowState = this.WindowState;

                doctorDashboard.Show();
                this.Hide();
            }
            else if (role == "Administrator") 
            {
                
            }
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccount = new CreateAccountForm();
            createAccount.StartPosition = FormStartPosition.Manual;
            createAccount.Location = this.Location;
            createAccount.Show();
            this.Hide();
        }
    }
}