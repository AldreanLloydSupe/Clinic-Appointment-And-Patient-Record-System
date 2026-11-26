namespace Clinic_Appoinment_And_Patient_Record_System.Admin
{
    partial class adminDashboard
    {
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label dashboardTitleLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button patientsButton;
        private System.Windows.Forms.Button appointmentsButton;
        private System.Windows.Forms.Button visitsButton;
        private System.Windows.Forms.Button billingButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Panel appointmentsSummaryPanel;
        private System.Windows.Forms.Panel patientsSummaryPanel;
        private System.Windows.Forms.Panel noShowsSummaryPanel;
        private System.Windows.Forms.Label appointmentsCountLabel;
        private System.Windows.Forms.Label appointmentsTextLabel;
        private System.Windows.Forms.Label patientsCountLabel;
        private System.Windows.Forms.Label patientsTextLabel;
        private System.Windows.Forms.Label noShowsCountLabel;
        private System.Windows.Forms.Label noShowsTextLabel;
        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.Label scheduleTitleLabel;
        private System.Windows.Forms.DataGridView scheduleGrid;
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.Button noShowButton;
        private System.Windows.Forms.Panel providerQueuePanel;
        private System.Windows.Forms.Label providerQueueTitleLabel;
        private System.Windows.Forms.DataGridView providerQueueGrid;

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
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.dashboardTitleLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.patientsButton = new System.Windows.Forms.Button();
            this.appointmentsButton = new System.Windows.Forms.Button();
            this.visitsButton = new System.Windows.Forms.Button();
            this.billingButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.appointmentsSummaryPanel = new System.Windows.Forms.Panel();
            this.patientsSummaryPanel = new System.Windows.Forms.Panel();
            this.noShowsSummaryPanel = new System.Windows.Forms.Panel();
            this.appointmentsCountLabel = new System.Windows.Forms.Label();
            this.appointmentsTextLabel = new System.Windows.Forms.Label();
            this.patientsCountLabel = new System.Windows.Forms.Label();
            this.patientsTextLabel = new System.Windows.Forms.Label();
            this.noShowsCountLabel = new System.Windows.Forms.Label();
            this.noShowsTextLabel = new System.Windows.Forms.Label();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.scheduleTitleLabel = new System.Windows.Forms.Label();
            this.scheduleGrid = new System.Windows.Forms.DataGridView();
            this.checkInButton = new System.Windows.Forms.Button();
            this.noShowButton = new System.Windows.Forms.Button();
            this.providerQueuePanel = new System.Windows.Forms.Panel();
            this.providerQueueTitleLabel = new System.Windows.Forms.Label();
            this.providerQueueGrid = new System.Windows.Forms.DataGridView();
            this.headerPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.summaryPanel.SuspendLayout();
            this.appointmentsSummaryPanel.SuspendLayout();
            this.patientsSummaryPanel.SuspendLayout();
            this.noShowsSummaryPanel.SuspendLayout();
            this.schedulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGrid)).BeginInit();
            this.providerQueuePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerQueueGrid)).BeginInit();
            this.SuspendLayout();
            //
            // headerPanel
            //
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(35, 83, 125);
            this.headerPanel.Controls.Add(this.roleLabel);
            this.headerPanel.Controls.Add(this.dashboardTitleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(959, 35);
            this.headerPanel.TabIndex = 0;
            //
            // dashboardTitleLabel
            //
            this.dashboardTitleLabel.AutoSize = true;
            this.dashboardTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dashboardTitleLabel.ForeColor = System.Drawing.Color.White;
            this.dashboardTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.dashboardTitleLabel.Name = "dashboardTitleLabel";
            this.dashboardTitleLabel.Size = new System.Drawing.Size(67, 15);
            this.dashboardTitleLabel.TabIndex = 0;
            this.dashboardTitleLabel.Text = "Dashboard";
            //
            // roleLabel
            //
            this.roleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.roleLabel.ForeColor = System.Drawing.Color.White;
            this.roleLabel.Location = new System.Drawing.Point(832, 9);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(115, 15);
            this.roleLabel.TabIndex = 1;
            this.roleLabel.Text = "Role: Administrator";
            //
            // navigationPanel
            //
            this.navigationPanel.BackColor = System.Drawing.Color.White;
            this.navigationPanel.Controls.Add(this.reportsButton);
            this.navigationPanel.Controls.Add(this.billingButton);
            this.navigationPanel.Controls.Add(this.visitsButton);
            this.navigationPanel.Controls.Add(this.appointmentsButton);
            this.navigationPanel.Controls.Add(this.patientsButton);
            this.navigationPanel.Controls.Add(this.dashboardButton);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Location = new System.Drawing.Point(0, 35);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(959, 46);
            this.navigationPanel.TabIndex = 1;
            //
            // navigation buttons
            //
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(35, 83, 125);
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Location = new System.Drawing.Point(12, 8);
            this.dashboardButton.Size = new System.Drawing.Size(93, 30);
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.patientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientsButton.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.patientsButton.Location = new System.Drawing.Point(111, 8);
            this.patientsButton.Size = new System.Drawing.Size(75, 30);
            this.patientsButton.Text = "Patients";
            this.appointmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentsButton.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.appointmentsButton.Location = new System.Drawing.Point(192, 8);
            this.appointmentsButton.Size = new System.Drawing.Size(111, 30);
            this.appointmentsButton.Text = "Appointments";
            this.visitsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitsButton.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.visitsButton.Location = new System.Drawing.Point(309, 8);
            this.visitsButton.Size = new System.Drawing.Size(60, 30);
            this.visitsButton.Text = "Visits";
            this.billingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billingButton.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.billingButton.Location = new System.Drawing.Point(375, 8);
            this.billingButton.Size = new System.Drawing.Size(64, 30);
            this.billingButton.Text = "Billing";
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.reportsButton.Location = new System.Drawing.Point(445, 8);
            this.reportsButton.Size = new System.Drawing.Size(75, 30);
            this.reportsButton.Text = "Reports";
            this.dashboardButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.TabIndex = 2;
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.patientsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.patientsButton.Name = "patientsButton";
            this.patientsButton.TabIndex = 3;
            this.patientsButton.UseVisualStyleBackColor = true;
            this.appointmentsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.appointmentsButton.Name = "appointmentsButton";
            this.appointmentsButton.TabIndex = 4;
            this.appointmentsButton.UseVisualStyleBackColor = true;
            this.visitsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.visitsButton.Name = "visitsButton";
            this.visitsButton.TabIndex = 5;
            this.visitsButton.UseVisualStyleBackColor = true;
            this.billingButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.billingButton.Name = "billingButton";
            this.billingButton.TabIndex = 6;
            this.billingButton.UseVisualStyleBackColor = true;
            this.reportsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.TabIndex = 7;
            this.reportsButton.UseVisualStyleBackColor = true;
            //
            // summaryPanel
            //
            this.summaryPanel.Controls.Add(this.noShowsSummaryPanel);
            this.summaryPanel.Controls.Add(this.patientsSummaryPanel);
            this.summaryPanel.Controls.Add(this.appointmentsSummaryPanel);
            this.summaryPanel.Location = new System.Drawing.Point(12, 94);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(600, 74);
            this.summaryPanel.TabIndex = 2;
            //
            // summary cards
            //
            this.appointmentsSummaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appointmentsSummaryPanel.Controls.Add(this.appointmentsTextLabel);
            this.appointmentsSummaryPanel.Controls.Add(this.appointmentsCountLabel);
            this.appointmentsSummaryPanel.Location = new System.Drawing.Point(0, 0);
            this.appointmentsSummaryPanel.Size = new System.Drawing.Size(192, 74);
            this.patientsSummaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patientsSummaryPanel.Controls.Add(this.patientsTextLabel);
            this.patientsSummaryPanel.Controls.Add(this.patientsCountLabel);
            this.patientsSummaryPanel.Location = new System.Drawing.Point(204, 0);
            this.patientsSummaryPanel.Size = new System.Drawing.Size(192, 74);
            this.noShowsSummaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noShowsSummaryPanel.Controls.Add(this.noShowsTextLabel);
            this.noShowsSummaryPanel.Controls.Add(this.noShowsCountLabel);
            this.noShowsSummaryPanel.Location = new System.Drawing.Point(408, 0);
            this.noShowsSummaryPanel.Size = new System.Drawing.Size(192, 74);
            this.appointmentsCountLabel.AutoSize = true;
            this.appointmentsCountLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.appointmentsCountLabel.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.appointmentsCountLabel.Location = new System.Drawing.Point(10, 10);
            this.appointmentsCountLabel.Text = "0";
            this.appointmentsTextLabel.AutoSize = true;
            this.appointmentsTextLabel.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.appointmentsTextLabel.Location = new System.Drawing.Point(10, 46);
            this.appointmentsTextLabel.Text = "Appointments today";
            this.patientsCountLabel.AutoSize = true;
            this.patientsCountLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.patientsCountLabel.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.patientsCountLabel.Location = new System.Drawing.Point(10, 10);
            this.patientsCountLabel.Text = "0";
            this.patientsTextLabel.AutoSize = true;
            this.patientsTextLabel.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.patientsTextLabel.Location = new System.Drawing.Point(10, 46);
            this.patientsTextLabel.Text = "Patients waiting";
            this.noShowsCountLabel.AutoSize = true;
            this.noShowsCountLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.noShowsCountLabel.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.noShowsCountLabel.Location = new System.Drawing.Point(10, 10);
            this.noShowsCountLabel.Text = "0";
            this.noShowsTextLabel.AutoSize = true;
            this.noShowsTextLabel.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.noShowsTextLabel.Location = new System.Drawing.Point(10, 46);
            this.noShowsTextLabel.Text = "No-shows";
            //
            // schedulePanel
            //
            this.schedulePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schedulePanel.Controls.Add(this.noShowButton);
            this.schedulePanel.Controls.Add(this.checkInButton);
            this.schedulePanel.Controls.Add(this.scheduleGrid);
            this.schedulePanel.Controls.Add(this.scheduleTitleLabel);
            this.schedulePanel.Location = new System.Drawing.Point(12, 180);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(600, 408);
            this.schedulePanel.TabIndex = 3;
            this.scheduleTitleLabel.AutoSize = true;
            this.scheduleTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.scheduleTitleLabel.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.scheduleTitleLabel.Location = new System.Drawing.Point(10, 12);
            this.scheduleTitleLabel.Text = "Today schedule";
            this.scheduleGrid.AllowUserToAddRows = false;
            this.scheduleGrid.AllowUserToDeleteRows = false;
            this.scheduleGrid.AllowUserToResizeRows = false;
            this.scheduleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scheduleGrid.BackgroundColor = System.Drawing.Color.White;
            this.scheduleGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scheduleGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(218, 227, 237);
            this.scheduleGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.scheduleGrid.EnableHeadersVisualStyles = false;
            this.scheduleGrid.Location = new System.Drawing.Point(10, 35);
            this.scheduleGrid.ReadOnly = true;
            this.scheduleGrid.RowHeadersVisible = false;
            this.scheduleGrid.Size = new System.Drawing.Size(578, 141);
            this.scheduleGrid.TabIndex = 1;
            this.scheduleGrid.Columns.Add("Time", "Time");
            this.scheduleGrid.Columns.Add("Patient", "Patient");
            this.scheduleGrid.Columns.Add("Provider", "Provider");
            this.scheduleGrid.Columns.Add("Status", "Status");
            this.checkInButton.BackColor = System.Drawing.Color.FromArgb(35, 83, 125);
            this.checkInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkInButton.ForeColor = System.Drawing.Color.White;
            this.checkInButton.Location = new System.Drawing.Point(10, 184);
            this.checkInButton.Size = new System.Drawing.Size(79, 30);
            this.checkInButton.Text = "Check in";
            this.checkInButton.UseVisualStyleBackColor = false;
            this.noShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noShowButton.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.noShowButton.Location = new System.Drawing.Point(98, 184);
            this.noShowButton.Size = new System.Drawing.Size(113, 30);
            this.noShowButton.Text = "Mark no-show";
            //
            // providerQueuePanel
            //
            this.providerQueuePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.providerQueuePanel.Controls.Add(this.providerQueueGrid);
            this.providerQueuePanel.Controls.Add(this.providerQueueTitleLabel);
            this.providerQueuePanel.Location = new System.Drawing.Point(624, 94);
            this.providerQueuePanel.Name = "providerQueuePanel";
            this.providerQueuePanel.Size = new System.Drawing.Size(322, 494);
            this.providerQueuePanel.TabIndex = 4;
            this.providerQueueTitleLabel.AutoSize = true;
            this.providerQueueTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.providerQueueTitleLabel.ForeColor = System.Drawing.Color.FromArgb(0, 55, 105);
            this.providerQueueTitleLabel.Location = new System.Drawing.Point(10, 12);
            this.providerQueueTitleLabel.Text = "Provider queue";
            this.providerQueueGrid.AllowUserToAddRows = false;
            this.providerQueueGrid.AllowUserToDeleteRows = false;
            this.providerQueueGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.providerQueueGrid.BackgroundColor = System.Drawing.Color.White;
            this.providerQueueGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.providerQueueGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(218, 227, 237);
            this.providerQueueGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.providerQueueGrid.EnableHeadersVisualStyles = false;
            this.providerQueueGrid.Location = new System.Drawing.Point(10, 35);
            this.providerQueueGrid.ReadOnly = true;
            this.providerQueueGrid.RowHeadersVisible = false;
            this.providerQueueGrid.Size = new System.Drawing.Size(300, 85);
            this.providerQueueGrid.TabIndex = 1;
            this.providerQueueGrid.Columns.Add("Number", "#");
            this.providerQueueGrid.Columns.Add("Patient", "Patient");
            this.providerQueueGrid.Columns.Add("Arrived", "Arrived");
            //
            // adminDashboard
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 243, 246);
            this.ClientSize = new System.Drawing.Size(959, 604);
            this.Controls.Add(this.providerQueuePanel);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.summaryPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "adminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.navigationPanel.ResumeLayout(false);
            this.summaryPanel.ResumeLayout(false);
            this.appointmentsSummaryPanel.ResumeLayout(false);
            this.appointmentsSummaryPanel.PerformLayout();
            this.patientsSummaryPanel.ResumeLayout(false);
            this.patientsSummaryPanel.PerformLayout();
            this.noShowsSummaryPanel.ResumeLayout(false);
            this.noShowsSummaryPanel.PerformLayout();
            this.schedulePanel.ResumeLayout(false);
            this.schedulePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGrid)).EndInit();
            this.providerQueuePanel.ResumeLayout(false);
            this.providerQueuePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerQueueGrid)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}