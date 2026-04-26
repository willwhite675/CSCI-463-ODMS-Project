namespace CSCI_463_ODMS_Project
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.systemLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Location = new System.Drawing.Point(89, 132);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.systemLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Location = new System.Drawing.Point(264, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 285);
            this.panel1.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(104, 240);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // systemLabel
            // 
            this.systemLabel.AutoSize = true;
            this.systemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemLabel.Location = new System.Drawing.Point(14, 35);
            this.systemLabel.Name = "systemLabel";
            this.systemLabel.Size = new System.Drawing.Size(248, 40);
            this.systemLabel.TabIndex = 4;
            this.systemLabel.Text = "Welcome to\r\nOpioid Data Management System";
            this.systemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(112, 98);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(89, 205);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label systemLabel;
        private System.Windows.Forms.Label label1;
    }
}

