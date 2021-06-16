namespace ClinicAppUI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMainControl = new System.Windows.Forms.Panel();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAnalytics = new System.Windows.Forms.Button();
            this.buttonCashBox = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonPatient = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelCurrentUser = new System.Windows.Forms.Panel();
            this.labelSpecialty = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelQualification = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelStaffFullname = new System.Windows.Forms.Label();
            this.panelMainUC = new System.Windows.Forms.Panel();
            this.panelMainControl.SuspendLayout();
            this.panelCurrentUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainControl
            // 
            this.panelMainControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelMainControl.Controls.Add(this.panelNavigation);
            this.panelMainControl.Controls.Add(this.buttonAbout);
            this.panelMainControl.Controls.Add(this.buttonRefresh);
            this.panelMainControl.Controls.Add(this.buttonAnalytics);
            this.panelMainControl.Controls.Add(this.buttonCashBox);
            this.panelMainControl.Controls.Add(this.buttonSchedule);
            this.panelMainControl.Controls.Add(this.buttonStaff);
            this.panelMainControl.Controls.Add(this.buttonPatient);
            this.panelMainControl.Controls.Add(this.buttonHome);
            this.panelMainControl.Controls.Add(this.panelCurrentUser);
            this.panelMainControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainControl.Location = new System.Drawing.Point(0, 0);
            this.panelMainControl.Name = "panelMainControl";
            this.panelMainControl.Size = new System.Drawing.Size(207, 648);
            this.panelMainControl.TabIndex = 1;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelNavigation.Location = new System.Drawing.Point(0, 193);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(3, 100);
            this.panelNavigation.TabIndex = 3;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonAbout.Image = global::ClinicAppUI.Properties.Resources.AboutIconUI;
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbout.Location = new System.Drawing.Point(0, 598);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(207, 50);
            this.buttonAbout.TabIndex = 3;
            this.buttonAbout.Text = "О Приложении";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.Location = new System.Drawing.Point(0, 470);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(207, 50);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonAnalytics
            // 
            this.buttonAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAnalytics.Enabled = false;
            this.buttonAnalytics.FlatAppearance.BorderSize = 0;
            this.buttonAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalytics.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonAnalytics.Image = global::ClinicAppUI.Properties.Resources.AnalyticsIconUI;
            this.buttonAnalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAnalytics.Location = new System.Drawing.Point(0, 420);
            this.buttonAnalytics.Name = "buttonAnalytics";
            this.buttonAnalytics.Size = new System.Drawing.Size(207, 50);
            this.buttonAnalytics.TabIndex = 0;
            this.buttonAnalytics.Text = "Аналитика";
            this.buttonAnalytics.UseVisualStyleBackColor = true;
            this.buttonAnalytics.Click += new System.EventHandler(this.buttonAnalytics_Click);
            this.buttonAnalytics.Leave += new System.EventHandler(this.buttonAnalytics_Leave);
            // 
            // buttonCashBox
            // 
            this.buttonCashBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCashBox.Enabled = false;
            this.buttonCashBox.FlatAppearance.BorderSize = 0;
            this.buttonCashBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCashBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonCashBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonCashBox.Image = global::ClinicAppUI.Properties.Resources.CashBoxIconUI;
            this.buttonCashBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCashBox.Location = new System.Drawing.Point(0, 370);
            this.buttonCashBox.Name = "buttonCashBox";
            this.buttonCashBox.Size = new System.Drawing.Size(207, 50);
            this.buttonCashBox.TabIndex = 3;
            this.buttonCashBox.Text = "Касса";
            this.buttonCashBox.UseVisualStyleBackColor = true;
            this.buttonCashBox.Click += new System.EventHandler(this.buttonCashBox_Click);
            this.buttonCashBox.Leave += new System.EventHandler(this.buttonCashBox_Leave);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSchedule.Enabled = false;
            this.buttonSchedule.FlatAppearance.BorderSize = 0;
            this.buttonSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSchedule.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonSchedule.Image = global::ClinicAppUI.Properties.Resources.ScheduleIconUI;
            this.buttonSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSchedule.Location = new System.Drawing.Point(0, 320);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(207, 50);
            this.buttonSchedule.TabIndex = 0;
            this.buttonSchedule.Text = "Расписание";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            this.buttonSchedule.Leave += new System.EventHandler(this.buttonSchedule_Leave);
            // 
            // buttonStaff
            // 
            this.buttonStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStaff.Enabled = false;
            this.buttonStaff.FlatAppearance.BorderSize = 0;
            this.buttonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaff.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonStaff.Image = global::ClinicAppUI.Properties.Resources.StaffIconUI;
            this.buttonStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStaff.Location = new System.Drawing.Point(0, 270);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(207, 50);
            this.buttonStaff.TabIndex = 0;
            this.buttonStaff.Text = "Персонал";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            this.buttonStaff.Leave += new System.EventHandler(this.buttonStaff_Leave);
            // 
            // buttonPatient
            // 
            this.buttonPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPatient.Enabled = false;
            this.buttonPatient.FlatAppearance.BorderSize = 0;
            this.buttonPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatient.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonPatient.Image = global::ClinicAppUI.Properties.Resources.PatientsIconUI;
            this.buttonPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPatient.Location = new System.Drawing.Point(0, 220);
            this.buttonPatient.Name = "buttonPatient";
            this.buttonPatient.Size = new System.Drawing.Size(207, 50);
            this.buttonPatient.TabIndex = 0;
            this.buttonPatient.Text = "Пациенты";
            this.buttonPatient.UseVisualStyleBackColor = true;
            this.buttonPatient.Click += new System.EventHandler(this.buttonPatient_Click);
            this.buttonPatient.Leave += new System.EventHandler(this.buttonPatient_Leave);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonHome.Image = global::ClinicAppUI.Properties.Resources.HomeIconUI;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHome.Location = new System.Drawing.Point(0, 170);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(207, 50);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Домой";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            this.buttonHome.Leave += new System.EventHandler(this.buttonHome_Leave);
            // 
            // panelCurrentUser
            // 
            this.panelCurrentUser.Controls.Add(this.labelSpecialty);
            this.panelCurrentUser.Controls.Add(this.labelPosition);
            this.panelCurrentUser.Controls.Add(this.labelQualification);
            this.panelCurrentUser.Controls.Add(this.labelWelcome);
            this.panelCurrentUser.Controls.Add(this.labelStaffFullname);
            this.panelCurrentUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCurrentUser.Location = new System.Drawing.Point(0, 0);
            this.panelCurrentUser.Name = "panelCurrentUser";
            this.panelCurrentUser.Size = new System.Drawing.Size(207, 170);
            this.panelCurrentUser.TabIndex = 1;
            // 
            // labelSpecialty
            // 
            this.labelSpecialty.AutoSize = true;
            this.labelSpecialty.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelSpecialty.Location = new System.Drawing.Point(3, 115);
            this.labelSpecialty.Name = "labelSpecialty";
            this.labelSpecialty.Size = new System.Drawing.Size(11, 13);
            this.labelSpecialty.TabIndex = 7;
            this.labelSpecialty.Text = "-";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelPosition.Location = new System.Drawing.Point(3, 90);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(11, 13);
            this.labelPosition.TabIndex = 6;
            this.labelPosition.Text = "-";
            // 
            // labelQualification
            // 
            this.labelQualification.AutoSize = true;
            this.labelQualification.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQualification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelQualification.Location = new System.Drawing.Point(3, 65);
            this.labelQualification.Name = "labelQualification";
            this.labelQualification.Size = new System.Drawing.Size(11, 13);
            this.labelQualification.TabIndex = 5;
            this.labelQualification.Text = "-";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelWelcome.Location = new System.Drawing.Point(25, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(159, 25);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.Text = "Здравствуйте!";
            // 
            // labelStaffFullname
            // 
            this.labelStaffFullname.AutoSize = true;
            this.labelStaffFullname.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelStaffFullname.Location = new System.Drawing.Point(3, 40);
            this.labelStaffFullname.Name = "labelStaffFullname";
            this.labelStaffFullname.Size = new System.Drawing.Size(11, 13);
            this.labelStaffFullname.TabIndex = 3;
            this.labelStaffFullname.Text = "-";
            // 
            // panelMainUC
            // 
            this.panelMainUC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainUC.Location = new System.Drawing.Point(207, 0);
            this.panelMainUC.Name = "panelMainUC";
            this.panelMainUC.Size = new System.Drawing.Size(977, 645);
            this.panelMainUC.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1184, 648);
            this.Controls.Add(this.panelMainUC);
            this.Controls.Add(this.panelMainControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClinicApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMainControl.ResumeLayout(false);
            this.panelCurrentUser.ResumeLayout(false);
            this.panelCurrentUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMainControl;
        private System.Windows.Forms.Panel panelMainUC;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonPatient;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAnalytics;
        private System.Windows.Forms.Button buttonCashBox;
        private System.Windows.Forms.Panel panelCurrentUser;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Label labelStaffFullname;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelSpecialty;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelQualification;
    }
}

