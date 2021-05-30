namespace ClinicAppUI.Forms
{
    partial class AddViewAppointmentForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStaff = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPatient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBoxComplains = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAppointmentType = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBoxAnamnesis = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.richTextBoxCondition = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxICD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxDiagnosis = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.richTextBoxRecommendations = new System.Windows.Forms.RichTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.richTextBoxMedicinalTherapy = new System.Windows.Forms.RichTextBox();
            this.buttonSeeTemplate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxStaff);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о враче";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ф.И.О Врача";
            // 
            // textBoxStaff
            // 
            this.textBoxStaff.Location = new System.Drawing.Point(6, 35);
            this.textBoxStaff.Name = "textBoxStaff";
            this.textBoxStaff.ReadOnly = true;
            this.textBoxStaff.Size = new System.Drawing.Size(188, 20);
            this.textBoxStaff.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPatient);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о пациенте";
            // 
            // textBoxPatient
            // 
            this.textBoxPatient.Location = new System.Drawing.Point(1, 35);
            this.textBoxPatient.Name = "textBoxPatient";
            this.textBoxPatient.ReadOnly = true;
            this.textBoxPatient.Size = new System.Drawing.Size(188, 20);
            this.textBoxPatient.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ф.И.О. Пациента";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBoxComplains);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Жалобы";
            // 
            // richTextBoxComplains
            // 
            this.richTextBoxComplains.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxComplains.Name = "richTextBoxComplains";
            this.richTextBoxComplains.Size = new System.Drawing.Size(188, 159);
            this.richTextBoxComplains.TabIndex = 4;
            this.richTextBoxComplains.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxDate);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBoxId);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboBoxAppointmentType);
            this.groupBox4.Location = new System.Drawing.Point(424, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 146);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Информация о приеме";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(6, 119);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(115, 20);
            this.textBoxDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Уникальный номер приема";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(6, 34);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(67, 20);
            this.textBoxId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата приема";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип приема";
            // 
            // comboBoxAppointmentType
            // 
            this.comboBoxAppointmentType.FormattingEnabled = true;
            this.comboBoxAppointmentType.Location = new System.Drawing.Point(6, 79);
            this.comboBoxAppointmentType.Name = "comboBoxAppointmentType";
            this.comboBoxAppointmentType.Size = new System.Drawing.Size(115, 21);
            this.comboBoxAppointmentType.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBoxAnamnesis);
            this.groupBox5.Location = new System.Drawing.Point(218, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 184);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Анамнез";
            // 
            // richTextBoxAnamnesis
            // 
            this.richTextBoxAnamnesis.Location = new System.Drawing.Point(1, 19);
            this.richTextBoxAnamnesis.Name = "richTextBoxAnamnesis";
            this.richTextBoxAnamnesis.Size = new System.Drawing.Size(193, 159);
            this.richTextBoxAnamnesis.TabIndex = 5;
            this.richTextBoxAnamnesis.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.richTextBoxCondition);
            this.groupBox6.Location = new System.Drawing.Point(12, 308);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 184);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Состояние пациента";
            // 
            // richTextBoxCondition
            // 
            this.richTextBoxCondition.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxCondition.Name = "richTextBoxCondition";
            this.richTextBoxCondition.Size = new System.Drawing.Size(188, 159);
            this.richTextBoxCondition.TabIndex = 7;
            this.richTextBoxCondition.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxICD);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.richTextBoxDiagnosis);
            this.groupBox7.Location = new System.Drawing.Point(218, 308);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 184);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Диагноз";
            // 
            // textBoxICD
            // 
            this.textBoxICD.Location = new System.Drawing.Point(6, 158);
            this.textBoxICD.Name = "textBoxICD";
            this.textBoxICD.Size = new System.Drawing.Size(61, 20);
            this.textBoxICD.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Код МКБ заболевания";
            // 
            // richTextBoxDiagnosis
            // 
            this.richTextBoxDiagnosis.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxDiagnosis.Name = "richTextBoxDiagnosis";
            this.richTextBoxDiagnosis.Size = new System.Drawing.Size(188, 115);
            this.richTextBoxDiagnosis.TabIndex = 8;
            this.richTextBoxDiagnosis.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(506, 463);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 30);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Завершить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(592, 463);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.richTextBoxRecommendations);
            this.groupBox8.Location = new System.Drawing.Point(424, 164);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(248, 138);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Рекомендации врача";
            // 
            // richTextBoxRecommendations
            // 
            this.richTextBoxRecommendations.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxRecommendations.Name = "richTextBoxRecommendations";
            this.richTextBoxRecommendations.Size = new System.Drawing.Size(236, 113);
            this.richTextBoxRecommendations.TabIndex = 0;
            this.richTextBoxRecommendations.Text = "";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.richTextBoxMedicinalTherapy);
            this.groupBox9.Location = new System.Drawing.Point(424, 308);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(248, 150);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Лекарственная терапия";
            // 
            // richTextBoxMedicinalTherapy
            // 
            this.richTextBoxMedicinalTherapy.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxMedicinalTherapy.Name = "richTextBoxMedicinalTherapy";
            this.richTextBoxMedicinalTherapy.Size = new System.Drawing.Size(236, 125);
            this.richTextBoxMedicinalTherapy.TabIndex = 0;
            this.richTextBoxMedicinalTherapy.Text = "";
            // 
            // buttonSeeTemplate
            // 
            this.buttonSeeTemplate.Location = new System.Drawing.Point(420, 462);
            this.buttonSeeTemplate.Name = "buttonSeeTemplate";
            this.buttonSeeTemplate.Size = new System.Drawing.Size(80, 30);
            this.buttonSeeTemplate.TabIndex = 11;
            this.buttonSeeTemplate.Text = "Шаблон";
            this.buttonSeeTemplate.UseVisualStyleBackColor = true;
            // 
            // AddViewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 499);
            this.Controls.Add(this.buttonSeeTemplate);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddViewAppointmentForm";
            this.Text = "AddViewAppointmentForm";
            this.Load += new System.EventHandler(this.AddViewAppointmentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStaff;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxComplains;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAppointmentType;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBoxAnamnesis;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox richTextBoxCondition;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox richTextBoxDiagnosis;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxICD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button buttonSeeTemplate;
        private System.Windows.Forms.RichTextBox richTextBoxRecommendations;
        private System.Windows.Forms.RichTextBox richTextBoxMedicinalTherapy;
        private System.Windows.Forms.TextBox textBoxPatient;
        private System.Windows.Forms.TextBox textBoxDate;
    }
}