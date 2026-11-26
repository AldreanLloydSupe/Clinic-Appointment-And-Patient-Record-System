namespace Clinic_Appoinment_And_Patient_Record_System
{
    partial class Form1
    {
        private System.Windows.Forms.Label titleBar;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            titleBar = new System.Windows.Forms.Label();
            loginPanel = new System.Windows.Forms.Panel();
            headingLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            usernameTextBox = new System.Windows.Forms.TextBox();
            passwordTextBox = new System.Windows.Forms.TextBox();
            loginButton = new System.Windows.Forms.Button();
            registerButton = new System.Windows.Forms.Button();
            loginPanel.SuspendLayout();
            SuspendLayout();
            //
            // titleBar
            //
            titleBar.BackColor = System.Drawing.Color.FromArgb(35, 83, 125);
            titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            titleBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            titleBar.ForeColor = System.Drawing.Color.White;
            titleBar.Location = new System.Drawing.Point(0, 0);
            titleBar.Name = "titleBar";
            titleBar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            titleBar.Size = new System.Drawing.Size(960, 35);
            titleBar.TabIndex = 0;
            titleBar.Text = "Clinic System - Login";
            titleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // loginPanel
            //
            loginPanel.BackColor = System.Drawing.Color.White;
            loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            loginPanel.Controls.Add(registerButton);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(passwordTextBox);
            loginPanel.Controls.Add(usernameTextBox);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Controls.Add(usernameLabel);
            loginPanel.Controls.Add(headingLabel);
            loginPanel.Location = new System.Drawing.Point(299, 235);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new System.Drawing.Size(362, 138);
            loginPanel.TabIndex = 1;
            //
            // headingLabel
            //
            headingLabel.AutoSize = true;
            headingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headingLabel.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            headingLabel.Location = new System.Drawing.Point(10, 12);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new System.Drawing.Size(42, 15);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Sign in";
            //
            // usernameLabel
            //
            usernameLabel.AutoSize = true;
            usernameLabel.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            usernameLabel.Location = new System.Drawing.Point(10, 43);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(60, 15);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            //
            // passwordLabel
            //
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            passwordLabel.Location = new System.Drawing.Point(10, 75);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(57, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            //
            // usernameTextBox
            //
            usernameTextBox.Location = new System.Drawing.Point(99, 34);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new System.Drawing.Size(250, 23);
            usernameTextBox.TabIndex = 3;
            //
            // passwordTextBox
            //
            passwordTextBox.Location = new System.Drawing.Point(99, 66);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new System.Drawing.Size(250, 23);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            //
            // loginButton
            //
            loginButton.BackColor = System.Drawing.Color.FromArgb(21, 78, 121);
            loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            loginButton.ForeColor = System.Drawing.Color.White;
            loginButton.Location = new System.Drawing.Point(10, 98);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(58, 28);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            //
            // registerButton
            //
            registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            registerButton.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            registerButton.Location = new System.Drawing.Point(76, 98);
            registerButton.Name = "registerButton";
            registerButton.Size = new System.Drawing.Size(159, 28);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register as new patient";
            registerButton.UseVisualStyleBackColor = true;
            AutoScaleMode = AutoScaleMode.Font;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            BackColor = System.Drawing.Color.FromArgb(241, 243, 246);
            ClientSize = new System.Drawing.Size(960, 604);
            Controls.Add(loginPanel);
            Controls.Add(titleBar);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Clinic System - Login";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
