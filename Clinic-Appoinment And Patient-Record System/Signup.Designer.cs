namespace Clinic_Appoinment_And_Patient_Record_System
{
    partial class Signup
    {
        private System.Windows.Forms.Label titleBar;
        private System.Windows.Forms.Panel registrationPanel;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label contactNumberLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label profileNoteLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button backToLoginButton;

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
            titleBar = new Label();
            registrationPanel = new Panel();
            backToLoginButton = new Button();
            registerButton = new Button();
            profileNoteLabel = new Label();
            confirmPasswordTextBox = new TextBox();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            contactNumberTextBox = new TextBox();
            fullNameTextBox = new TextBox();
            confirmPasswordLabel = new Label();
            passwordLabel = new Label();
            usernameLabel = new Label();
            contactNumberLabel = new Label();
            fullNameLabel = new Label();
            headingLabel = new Label();
            registrationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleBar
            // 
            titleBar.BackColor = Color.FromArgb(35, 83, 125);
            titleBar.Dock = DockStyle.Top;
            titleBar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            titleBar.ForeColor = Color.White;
            titleBar.Location = new Point(0, 0);
            titleBar.Name = "titleBar";
            titleBar.Padding = new Padding(12, 0, 0, 0);
            titleBar.Size = new Size(956, 35);
            titleBar.TabIndex = 0;
            titleBar.Text = "Clinic System - Create Patient Account";
            titleBar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // registrationPanel
            // 
            registrationPanel.BackColor = Color.White;
            registrationPanel.BorderStyle = BorderStyle.FixedSingle;
            registrationPanel.Controls.Add(backToLoginButton);
            registrationPanel.Controls.Add(registerButton);
            registrationPanel.Controls.Add(profileNoteLabel);
            registrationPanel.Controls.Add(confirmPasswordTextBox);
            registrationPanel.Controls.Add(passwordTextBox);
            registrationPanel.Controls.Add(usernameTextBox);
            registrationPanel.Controls.Add(contactNumberTextBox);
            registrationPanel.Controls.Add(fullNameTextBox);
            registrationPanel.Controls.Add(confirmPasswordLabel);
            registrationPanel.Controls.Add(passwordLabel);
            registrationPanel.Controls.Add(usernameLabel);
            registrationPanel.Controls.Add(contactNumberLabel);
            registrationPanel.Controls.Add(fullNameLabel);
            registrationPanel.Controls.Add(headingLabel);
            registrationPanel.Location = new Point(272, 152);
            registrationPanel.Name = "registrationPanel";
            registrationPanel.Size = new Size(414, 298);
            registrationPanel.TabIndex = 1;
            // 
            // backToLoginButton
            // 
            backToLoginButton.FlatStyle = FlatStyle.Flat;
            backToLoginButton.ForeColor = Color.FromArgb(0, 55, 105);
            backToLoginButton.Location = new Point(104, 247);
            backToLoginButton.Name = "backToLoginButton";
            backToLoginButton.Size = new Size(109, 30);
            backToLoginButton.TabIndex = 10;
            backToLoginButton.Text = "Back to login";
            backToLoginButton.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(21, 78, 121);
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(16, 247);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(80, 30);
            registerButton.TabIndex = 9;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            // 
            // profileNoteLabel
            // 
            profileNoteLabel.AutoSize = true;
            profileNoteLabel.ForeColor = Color.FromArgb(0, 55, 105);
            profileNoteLabel.Location = new Point(16, 224);
            profileNoteLabel.Name = "profileNoteLabel";
            profileNoteLabel.Size = new Size(266, 15);
            profileNoteLabel.TabIndex = 8;
            profileNoteLabel.Text = "You can add your other details later in My Profile.";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(146, 183);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(250, 23);
            confirmPasswordTextBox.TabIndex = 11;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(146, 149);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(250, 23);
            passwordTextBox.TabIndex = 12;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(146, 115);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(250, 23);
            usernameTextBox.TabIndex = 13;
            // 
            // contactNumberTextBox
            // 
            contactNumberTextBox.Location = new Point(146, 81);
            contactNumberTextBox.Name = "contactNumberTextBox";
            contactNumberTextBox.Size = new Size(250, 23);
            contactNumberTextBox.TabIndex = 14;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(146, 47);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(250, 23);
            fullNameTextBox.TabIndex = 15;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(16, 190);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(104, 15);
            confirmPasswordLabel.TabIndex = 16;
            confirmPasswordLabel.Text = "Confirm password";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(16, 156);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 17;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(16, 122);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 18;
            usernameLabel.Text = "Username";
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.Location = new Point(16, 88);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new Size(94, 15);
            contactNumberLabel.TabIndex = 19;
            contactNumberLabel.Text = "Contact number";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(16, 54);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(59, 15);
            fullNameLabel.TabIndex = 20;
            fullNameLabel.Text = "Full name";
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            headingLabel.ForeColor = Color.FromArgb(0, 55, 105);
            headingLabel.Location = new Point(16, 18);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(138, 15);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Register as new patient";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 243, 246);
            ClientSize = new Size(956, 600);
            Controls.Add(registrationPanel);
            Controls.Add(titleBar);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic System - Create Patient Account";
            registrationPanel.ResumeLayout(false);
            registrationPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}