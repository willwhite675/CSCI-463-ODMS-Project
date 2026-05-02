using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI_463_ODMS_Project
{
    public partial class CreateAccountForm : Form
    {
        private const string UsersFilePath = "users.txt";

        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text.Trim();
            string password = passwordInput.Text.Trim();
            string firstName = firstNameInput.Text.Trim();
            string lastName = lastNameInput.Text.Trim();
            string role = roleSelectionBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Username, Password, and Role are required.", "Input Error");
                return;
            }

            try
            {
                if (File.Exists(UsersFilePath))
                {
                    foreach (string line in File.ReadLines(UsersFilePath))
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length > 0 && parts[0].Equals(username, StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("This username is already taken. Please choose another.", "Account Conflict");
                            return;
                        }
                    }
                }

                string userData = $"{username},{password},{firstName},{lastName},{role}";
                File.AppendAllText(UsersFilePath, userData + Environment.NewLine);

                MessageBox.Show("Account successfully created!", "Success");

                Login loginForm = new Login();
                loginForm.StartPosition = FormStartPosition.Manual;
                loginForm.Location = this.Location;
                loginForm.Size = this.Size;
                loginForm.WindowState = this.WindowState;

                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not save account: {ex.Message}", "File Error");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}