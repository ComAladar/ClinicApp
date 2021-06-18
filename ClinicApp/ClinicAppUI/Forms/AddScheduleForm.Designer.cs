namespace ClinicAppUI.Forms
{
    partial class AddScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddScheduleForm));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxScheduleDate = new System.Windows.Forms.GroupBox();
            this.comboBoxAppointmentType = new System.Windows.Forms.ComboBox();
            this.labelAppointmentType = new System.Windows.Forms.Label();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.listBoxPatients = new System.Windows.Forms.ListBox();
            this.listBoxStaff = new System.Windows.Forms.ListBox();
            this.groupBoxPatientSelect = new System.Windows.Forms.GroupBox();
            this.groupBoxStaffSelect = new System.Windows.Forms.GroupBox();
            this.labelPatientSearch = new System.Windows.Forms.Label();
            this.labelStaffSearch = new System.Windows.Forms.Label();
            this.textBoxPatientSearch = new System.Windows.Forms.TextBox();
            this.textBoxStaffSearch = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelSpecialty = new System.Windows.Forms.Label();
            this.labelDateOfBirthText = new System.Windows.Forms.Label();
            this.labelPositionText = new System.Windows.Forms.Label();
            this.labelSpecialtyText = new System.Windows.Forms.Label();
            this.groupBoxScheduleDate.SuspendLayout();
            this.groupBoxPatientSelect.SuspendLayout();
            this.groupBoxStaffSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(438, 344);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 30);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "ОК";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(524, 344);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxScheduleDate
            // 
            this.groupBoxScheduleDate.Controls.Add(this.groupBoxStaffSelect);
            this.groupBoxScheduleDate.Controls.Add(this.groupBoxPatientSelect);
            this.groupBoxScheduleDate.Controls.Add(this.comboBoxAppointmentType);
            this.groupBoxScheduleDate.Controls.Add(this.labelAppointmentType);
            this.groupBoxScheduleDate.Controls.Add(this.dateTimePickerTime);
            this.groupBoxScheduleDate.Controls.Add(this.dateTimePickerDate);
            this.groupBoxScheduleDate.Controls.Add(this.labelDate);
            this.groupBoxScheduleDate.Location = new System.Drawing.Point(12, 12);
            this.groupBoxScheduleDate.Name = "groupBoxScheduleDate";
            this.groupBoxScheduleDate.Size = new System.Drawing.Size(592, 326);
            this.groupBoxScheduleDate.TabIndex = 6;
            this.groupBoxScheduleDate.TabStop = false;
            this.groupBoxScheduleDate.Text = "Расписание";
            // 
            // comboBoxAppointmentType
            // 
            this.comboBoxAppointmentType.FormattingEnabled = true;
            this.comboBoxAppointmentType.Location = new System.Drawing.Point(19, 279);
            this.comboBoxAppointmentType.Name = "comboBoxAppointmentType";
            this.comboBoxAppointmentType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAppointmentType.TabIndex = 9;
            // 
            // labelAppointmentType
            // 
            this.labelAppointmentType.AutoSize = true;
            this.labelAppointmentType.Location = new System.Drawing.Point(19, 263);
            this.labelAppointmentType.Name = "labelAppointmentType";
            this.labelAppointmentType.Size = new System.Drawing.Size(69, 13);
            this.labelAppointmentType.TabIndex = 8;
            this.labelAppointmentType.Text = "Тип Приема";
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(478, 279);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerTime.TabIndex = 7;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(334, 279);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(138, 20);
            this.dateTimePickerDate.TabIndex = 6;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(334, 263);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(74, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Дата приема";
            // 
            // listBoxPatients
            // 
            this.listBoxPatients.FormattingEnabled = true;
            this.listBoxPatients.Location = new System.Drawing.Point(6, 46);
            this.listBoxPatients.Name = "listBoxPatients";
            this.listBoxPatients.Size = new System.Drawing.Size(275, 134);
            this.listBoxPatients.TabIndex = 10;
            this.listBoxPatients.SelectedIndexChanged += new System.EventHandler(this.listBoxPatients_SelectedIndexChanged);
            // 
            // listBoxStaff
            // 
            this.listBoxStaff.FormattingEnabled = true;
            this.listBoxStaff.Location = new System.Drawing.Point(6, 46);
            this.listBoxStaff.Name = "listBoxStaff";
            this.listBoxStaff.Size = new System.Drawing.Size(275, 134);
            this.listBoxStaff.TabIndex = 11;
            this.listBoxStaff.SelectedIndexChanged += new System.EventHandler(this.listBoxStaff_SelectedIndexChanged);
            // 
            // groupBoxPatientSelect
            // 
            this.groupBoxPatientSelect.Controls.Add(this.labelDateOfBirthText);
            this.groupBoxPatientSelect.Controls.Add(this.labelDateOfBirth);
            this.groupBoxPatientSelect.Controls.Add(this.textBoxPatientSearch);
            this.groupBoxPatientSelect.Controls.Add(this.labelPatientSearch);
            this.groupBoxPatientSelect.Controls.Add(this.listBoxPatients);
            this.groupBoxPatientSelect.Location = new System.Drawing.Point(6, 19);
            this.groupBoxPatientSelect.Name = "groupBoxPatientSelect";
            this.groupBoxPatientSelect.Size = new System.Drawing.Size(287, 241);
            this.groupBoxPatientSelect.TabIndex = 12;
            this.groupBoxPatientSelect.TabStop = false;
            this.groupBoxPatientSelect.Text = "Пациент";
            // 
            // groupBoxStaffSelect
            // 
            this.groupBoxStaffSelect.Controls.Add(this.labelSpecialtyText);
            this.groupBoxStaffSelect.Controls.Add(this.labelPositionText);
            this.groupBoxStaffSelect.Controls.Add(this.labelSpecialty);
            this.groupBoxStaffSelect.Controls.Add(this.labelPosition);
            this.groupBoxStaffSelect.Controls.Add(this.textBoxStaffSearch);
            this.groupBoxStaffSelect.Controls.Add(this.labelStaffSearch);
            this.groupBoxStaffSelect.Controls.Add(this.listBoxStaff);
            this.groupBoxStaffSelect.Location = new System.Drawing.Point(299, 19);
            this.groupBoxStaffSelect.Name = "groupBoxStaffSelect";
            this.groupBoxStaffSelect.Size = new System.Drawing.Size(287, 241);
            this.groupBoxStaffSelect.TabIndex = 13;
            this.groupBoxStaffSelect.TabStop = false;
            this.groupBoxStaffSelect.Text = "Врач";
            // 
            // labelPatientSearch
            // 
            this.labelPatientSearch.AutoSize = true;
            this.labelPatientSearch.Location = new System.Drawing.Point(6, 20);
            this.labelPatientSearch.Name = "labelPatientSearch";
            this.labelPatientSearch.Size = new System.Drawing.Size(39, 13);
            this.labelPatientSearch.TabIndex = 12;
            this.labelPatientSearch.Text = "Поиск";
            // 
            // labelStaffSearch
            // 
            this.labelStaffSearch.AutoSize = true;
            this.labelStaffSearch.Location = new System.Drawing.Point(6, 20);
            this.labelStaffSearch.Name = "labelStaffSearch";
            this.labelStaffSearch.Size = new System.Drawing.Size(39, 13);
            this.labelStaffSearch.TabIndex = 12;
            this.labelStaffSearch.Text = "Поиск";
            // 
            // textBoxPatientSearch
            // 
            this.textBoxPatientSearch.Location = new System.Drawing.Point(51, 17);
            this.textBoxPatientSearch.Name = "textBoxPatientSearch";
            this.textBoxPatientSearch.Size = new System.Drawing.Size(122, 20);
            this.textBoxPatientSearch.TabIndex = 13;
            this.textBoxPatientSearch.TextChanged += new System.EventHandler(this.textBoxPatientSearch_TextChanged);
            // 
            // textBoxStaffSearch
            // 
            this.textBoxStaffSearch.Location = new System.Drawing.Point(51, 17);
            this.textBoxStaffSearch.Name = "textBoxStaffSearch";
            this.textBoxStaffSearch.Size = new System.Drawing.Size(122, 20);
            this.textBoxStaffSearch.TabIndex = 13;
            this.textBoxStaffSearch.TextChanged += new System.EventHandler(this.textBoxStaffSearch_TextChanged);
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(10, 194);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(89, 13);
            this.labelDateOfBirth.TabIndex = 14;
            this.labelDateOfBirth.Text = "Дата рождения:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(10, 194);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(68, 13);
            this.labelPosition.TabIndex = 14;
            this.labelPosition.Text = "Должность:";
            // 
            // labelSpecialty
            // 
            this.labelSpecialty.AutoSize = true;
            this.labelSpecialty.Location = new System.Drawing.Point(10, 216);
            this.labelSpecialty.Name = "labelSpecialty";
            this.labelSpecialty.Size = new System.Drawing.Size(88, 13);
            this.labelSpecialty.TabIndex = 15;
            this.labelSpecialty.Text = "Специальность:";
            // 
            // labelDateOfBirthText
            // 
            this.labelDateOfBirthText.AutoSize = true;
            this.labelDateOfBirthText.Location = new System.Drawing.Point(105, 194);
            this.labelDateOfBirthText.Name = "labelDateOfBirthText";
            this.labelDateOfBirthText.Size = new System.Drawing.Size(19, 13);
            this.labelDateOfBirthText.TabIndex = 15;
            this.labelDateOfBirthText.Text = "....";
            // 
            // labelPositionText
            // 
            this.labelPositionText.AutoSize = true;
            this.labelPositionText.Location = new System.Drawing.Point(84, 194);
            this.labelPositionText.Name = "labelPositionText";
            this.labelPositionText.Size = new System.Drawing.Size(19, 13);
            this.labelPositionText.TabIndex = 16;
            this.labelPositionText.Text = "....";
            // 
            // labelSpecialtyText
            // 
            this.labelSpecialtyText.AutoSize = true;
            this.labelSpecialtyText.Location = new System.Drawing.Point(104, 216);
            this.labelSpecialtyText.Name = "labelSpecialtyText";
            this.labelSpecialtyText.Size = new System.Drawing.Size(19, 13);
            this.labelSpecialtyText.TabIndex = 17;
            this.labelSpecialtyText.Text = "....";
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 386);
            this.Controls.Add(this.groupBoxScheduleDate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая запись";
            this.groupBoxScheduleDate.ResumeLayout(false);
            this.groupBoxScheduleDate.PerformLayout();
            this.groupBoxPatientSelect.ResumeLayout(false);
            this.groupBoxPatientSelect.PerformLayout();
            this.groupBoxStaffSelect.ResumeLayout(false);
            this.groupBoxStaffSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxScheduleDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxAppointmentType;
        private System.Windows.Forms.Label labelAppointmentType;
        private System.Windows.Forms.GroupBox groupBoxPatientSelect;
        private System.Windows.Forms.ListBox listBoxStaff;
        private System.Windows.Forms.ListBox listBoxPatients;
        private System.Windows.Forms.GroupBox groupBoxStaffSelect;
        private System.Windows.Forms.Label labelStaffSearch;
        private System.Windows.Forms.Label labelPatientSearch;
        private System.Windows.Forms.TextBox textBoxStaffSearch;
        private System.Windows.Forms.TextBox textBoxPatientSearch;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelSpecialty;
        private System.Windows.Forms.Label labelSpecialtyText;
        private System.Windows.Forms.Label labelPositionText;
        private System.Windows.Forms.Label labelDateOfBirthText;
    }
}