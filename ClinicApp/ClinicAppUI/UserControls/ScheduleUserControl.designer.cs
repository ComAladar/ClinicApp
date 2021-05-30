namespace ClinicAppUI.UserControls
{
    partial class ScheduleUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMonths = new System.Windows.Forms.GroupBox();
            this.monthViewMain = new WindowsFormsCalendar.MonthView();
            this.groupBoxSchedule = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.DoctorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxMonths.SuspendLayout();
            this.groupBoxSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMonths
            // 
            this.groupBoxMonths.Controls.Add(this.monthViewMain);
            this.groupBoxMonths.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMonths.Name = "groupBoxMonths";
            this.groupBoxMonths.Size = new System.Drawing.Size(202, 318);
            this.groupBoxMonths.TabIndex = 1;
            this.groupBoxMonths.TabStop = false;
            this.groupBoxMonths.Text = "Календарь";
            // 
            // monthViewMain
            // 
            this.monthViewMain.ArrowsColor = System.Drawing.SystemColors.Window;
            this.monthViewMain.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.monthViewMain.DayBackgroundColor = System.Drawing.Color.Empty;
            this.monthViewMain.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.monthViewMain.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.monthViewMain.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.monthViewMain.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.monthViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthViewMain.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.monthViewMain.ItemPadding = new System.Windows.Forms.Padding(2);
            this.monthViewMain.Location = new System.Drawing.Point(3, 16);
            this.monthViewMain.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthViewMain.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.monthViewMain.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthViewMain.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthViewMain.Name = "monthViewMain";
            this.monthViewMain.SelectionMode = WindowsFormsCalendar.MonthViewSelection.Day;
            this.monthViewMain.Size = new System.Drawing.Size(196, 299);
            this.monthViewMain.TabIndex = 1;
            this.monthViewMain.Text = "monthView1";
            this.monthViewMain.TodayBorderColor = System.Drawing.Color.Maroon;
            this.monthViewMain.SelectionChanged += new System.EventHandler(this.monthViewMain_SelectionChanged);
            // 
            // groupBoxSchedule
            // 
            this.groupBoxSchedule.Controls.Add(this.buttonAdd);
            this.groupBoxSchedule.Controls.Add(this.dataGridViewSchedule);
            this.groupBoxSchedule.Location = new System.Drawing.Point(208, 3);
            this.groupBoxSchedule.Name = "groupBoxSchedule";
            this.groupBoxSchedule.Size = new System.Drawing.Size(599, 318);
            this.groupBoxSchedule.TabIndex = 2;
            this.groupBoxSchedule.TabStop = false;
            this.groupBoxSchedule.Text = "Расписание";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(513, 282);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AllowUserToAddRows = false;
            this.dataGridViewSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorColumn,
            this.PatientColumn,
            this.DateColumn});
            this.dataGridViewSchedule.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.ReadOnly = true;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(587, 257);
            this.dataGridViewSchedule.TabIndex = 0;
            // 
            // DoctorColumn
            // 
            this.DoctorColumn.HeaderText = "Доктор";
            this.DoctorColumn.Name = "DoctorColumn";
            this.DoctorColumn.ReadOnly = true;
            // 
            // PatientColumn
            // 
            this.PatientColumn.HeaderText = "Пациент";
            this.PatientColumn.Name = "PatientColumn";
            this.PatientColumn.ReadOnly = true;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Дата Прием";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // ScheduleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxSchedule);
            this.Controls.Add(this.groupBoxMonths);
            this.Name = "ScheduleUserControl";
            this.Size = new System.Drawing.Size(810, 416);
            this.groupBoxMonths.ResumeLayout(false);
            this.groupBoxSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMonths;
        private WindowsFormsCalendar.MonthView monthViewMain;
        private System.Windows.Forms.GroupBox groupBoxSchedule;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
    }
}
