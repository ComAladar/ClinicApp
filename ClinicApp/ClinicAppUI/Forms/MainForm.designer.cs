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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonPatient = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelMainUC = new System.Windows.Forms.Panel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCashBox = new System.Windows.Forms.Button();
            this.buttonAnalytics = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.buttonAnalytics);
            this.panel1.Controls.Add(this.buttonCashBox);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonSchedule);
            this.panel1.Controls.Add(this.buttonStaff);
            this.panel1.Controls.Add(this.buttonPatient);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 50);
            this.panel1.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(528, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(80, 30);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Enabled = false;
            this.buttonSchedule.Location = new System.Drawing.Point(270, 3);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(80, 30);
            this.buttonSchedule.TabIndex = 0;
            this.buttonSchedule.Text = "Расписание";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.Enabled = false;
            this.buttonStaff.Location = new System.Drawing.Point(184, 3);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(80, 30);
            this.buttonStaff.TabIndex = 0;
            this.buttonStaff.Text = "Персонал";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonPatient
            // 
            this.buttonPatient.Enabled = false;
            this.buttonPatient.Location = new System.Drawing.Point(98, 3);
            this.buttonPatient.Name = "buttonPatient";
            this.buttonPatient.Size = new System.Drawing.Size(80, 30);
            this.buttonPatient.TabIndex = 0;
            this.buttonPatient.Text = "Пациенты";
            this.buttonPatient.UseVisualStyleBackColor = true;
            this.buttonPatient.Click += new System.EventHandler(this.buttonPatient_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonHome.Location = new System.Drawing.Point(12, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(80, 30);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Домой";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelMainUC
            // 
            this.panelMainUC.Location = new System.Drawing.Point(12, 83);
            this.panelMainUC.Name = "panelMainUC";
            this.panelMainUC.Size = new System.Drawing.Size(810, 416);
            this.panelMainUC.TabIndex = 2;
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem,
            this.InfoToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(834, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.HelpToolStripMenuItem.Text = "Помощь";
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.InfoToolStripMenuItem.Text = "О Приложении";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // buttonCashBox
            // 
            this.buttonCashBox.Enabled = false;
            this.buttonCashBox.Location = new System.Drawing.Point(356, 3);
            this.buttonCashBox.Name = "buttonCashBox";
            this.buttonCashBox.Size = new System.Drawing.Size(80, 30);
            this.buttonCashBox.TabIndex = 3;
            this.buttonCashBox.Text = "Бухгалтерия";
            this.buttonCashBox.UseVisualStyleBackColor = true;
            this.buttonCashBox.Click += new System.EventHandler(this.buttonCashBox_Click);
            // 
            // buttonAnalytics
            // 
            this.buttonAnalytics.Enabled = false;
            this.buttonAnalytics.Location = new System.Drawing.Point(442, 3);
            this.buttonAnalytics.Name = "buttonAnalytics";
            this.buttonAnalytics.Size = new System.Drawing.Size(80, 30);
            this.buttonAnalytics.TabIndex = 0;
            this.buttonAnalytics.Text = "Аналитика";
            this.buttonAnalytics.UseVisualStyleBackColor = true;
            this.buttonAnalytics.Click += new System.EventHandler(this.buttonAnalytics_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.panelMainUC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripMain);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "ClinicApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMainUC;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonPatient;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAnalytics;
        private System.Windows.Forms.Button buttonCashBox;
    }
}

