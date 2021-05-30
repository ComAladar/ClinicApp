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
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.labelPatient = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxScheduleDate = new System.Windows.Forms.GroupBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.groupBoxScheduleDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(6, 32);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDoctor.TabIndex = 0;
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(6, 72);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPatient.TabIndex = 1;
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(6, 16);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(31, 13);
            this.labelDoctor.TabIndex = 2;
            this.labelDoctor.Text = "Врач";
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Location = new System.Drawing.Point(6, 56);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(56, 13);
            this.labelPatient.TabIndex = 3;
            this.labelPatient.Text = "Пациента";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(158, 154);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 30);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(242, 154);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxScheduleDate
            // 
            this.groupBoxScheduleDate.Controls.Add(this.dateTimePickerTime);
            this.groupBoxScheduleDate.Controls.Add(this.dateTimePickerDate);
            this.groupBoxScheduleDate.Controls.Add(this.labelDate);
            this.groupBoxScheduleDate.Controls.Add(this.comboBoxDoctor);
            this.groupBoxScheduleDate.Controls.Add(this.comboBoxPatient);
            this.groupBoxScheduleDate.Controls.Add(this.labelDoctor);
            this.groupBoxScheduleDate.Controls.Add(this.labelPatient);
            this.groupBoxScheduleDate.Location = new System.Drawing.Point(12, 12);
            this.groupBoxScheduleDate.Name = "groupBoxScheduleDate";
            this.groupBoxScheduleDate.Size = new System.Drawing.Size(310, 136);
            this.groupBoxScheduleDate.TabIndex = 6;
            this.groupBoxScheduleDate.TabStop = false;
            this.groupBoxScheduleDate.Text = "groupBox1";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(6, 94);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(74, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Дата приема";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(6, 110);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(138, 20);
            this.dateTimePickerDate.TabIndex = 6;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(150, 110);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerTime.TabIndex = 7;
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.groupBoxScheduleDate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AddScheduleForm";
            this.Text = "AddSchedule";
            this.groupBoxScheduleDate.ResumeLayout(false);
            this.groupBoxScheduleDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxScheduleDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
    }
}