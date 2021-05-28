namespace ClinicAppUI.UserControls
{
    partial class StaffUserControl
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
            this.listBoxStaff = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxPersonalInfo = new System.Windows.Forms.GroupBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxAppointments = new System.Windows.Forms.GroupBox();
            this.textBoxAllAppointments = new System.Windows.Forms.TextBox();
            this.textBoxTodayAppointments = new System.Windows.Forms.TextBox();
            this.buttonAppointmentInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAppointments = new System.Windows.Forms.ListBox();
            this.groupBoxContacts = new System.Windows.Forms.GroupBox();
            this.textBoxAccess = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBoxRank = new System.Windows.Forms.GroupBox();
            this.textBoxEmploymentDate = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxSpecialty = new System.Windows.Forms.TextBox();
            this.textBoxQualification = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxSex = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationDate = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.groupBoxPersonalInfo.SuspendLayout();
            this.groupBoxAppointments.SuspendLayout();
            this.groupBoxContacts.SuspendLayout();
            this.groupBoxRank.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxStaff
            // 
            this.listBoxStaff.FormattingEnabled = true;
            this.listBoxStaff.Location = new System.Drawing.Point(3, 39);
            this.listBoxStaff.Name = "listBoxStaff";
            this.listBoxStaff.Size = new System.Drawing.Size(140, 342);
            this.listBoxStaff.TabIndex = 2;
            this.listBoxStaff.SelectedIndexChanged += new System.EventHandler(this.listBoxStaff_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(4, 383);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(42, 30);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добав";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(52, 383);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(42, 30);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Редакт";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(100, 383);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(43, 30);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxPersonalInfo
            // 
            this.groupBoxPersonalInfo.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxRegistrationDate);
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxSex);
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxBirthDate);
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxPatronymic);
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxName);
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxSurname);
            this.groupBoxPersonalInfo.Controls.Add(this.label8);
            this.groupBoxPersonalInfo.Controls.Add(this.label7);
            this.groupBoxPersonalInfo.Controls.Add(this.label6);
            this.groupBoxPersonalInfo.Controls.Add(this.label5);
            this.groupBoxPersonalInfo.Controls.Add(this.label4);
            this.groupBoxPersonalInfo.Controls.Add(this.label3);
            this.groupBoxPersonalInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxPersonalInfo.Location = new System.Drawing.Point(149, 3);
            this.groupBoxPersonalInfo.Name = "groupBoxPersonalInfo";
            this.groupBoxPersonalInfo.Size = new System.Drawing.Size(325, 125);
            this.groupBoxPersonalInfo.TabIndex = 6;
            this.groupBoxPersonalInfo.TabStop = false;
            this.groupBoxPersonalInfo.Text = "Персональные Данные";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(223, 36);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.ReadOnly = true;
            this.textBoxPatronymic.Size = new System.Drawing.Size(84, 20);
            this.textBoxPatronymic.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(125, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(84, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(9, 36);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(84, 20);
            this.textBoxSurname.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Дата регистрации";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Пол";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Дата Рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Фамилия";
            // 
            // groupBoxAppointments
            // 
            this.groupBoxAppointments.Controls.Add(this.textBoxAllAppointments);
            this.groupBoxAppointments.Controls.Add(this.textBoxTodayAppointments);
            this.groupBoxAppointments.Controls.Add(this.buttonAppointmentInfo);
            this.groupBoxAppointments.Controls.Add(this.label2);
            this.groupBoxAppointments.Controls.Add(this.label1);
            this.groupBoxAppointments.Controls.Add(this.listBoxAppointments);
            this.groupBoxAppointments.Location = new System.Drawing.Point(480, 3);
            this.groupBoxAppointments.Name = "groupBoxAppointments";
            this.groupBoxAppointments.Size = new System.Drawing.Size(325, 279);
            this.groupBoxAppointments.TabIndex = 7;
            this.groupBoxAppointments.TabStop = false;
            this.groupBoxAppointments.Text = "Приемы";
            // 
            // textBoxAllAppointments
            // 
            this.textBoxAllAppointments.Location = new System.Drawing.Point(155, 101);
            this.textBoxAllAppointments.Name = "textBoxAllAppointments";
            this.textBoxAllAppointments.ReadOnly = true;
            this.textBoxAllAppointments.Size = new System.Drawing.Size(84, 20);
            this.textBoxAllAppointments.TabIndex = 10;
            // 
            // textBoxTodayAppointments
            // 
            this.textBoxTodayAppointments.Location = new System.Drawing.Point(155, 35);
            this.textBoxTodayAppointments.Name = "textBoxTodayAppointments";
            this.textBoxTodayAppointments.ReadOnly = true;
            this.textBoxTodayAppointments.Size = new System.Drawing.Size(84, 20);
            this.textBoxTodayAppointments.TabIndex = 9;
            // 
            // buttonAppointmentInfo
            // 
            this.buttonAppointmentInfo.Location = new System.Drawing.Point(152, 247);
            this.buttonAppointmentInfo.Name = "buttonAppointmentInfo";
            this.buttonAppointmentInfo.Size = new System.Drawing.Size(95, 23);
            this.buttonAppointmentInfo.TabIndex = 5;
            this.buttonAppointmentInfo.Text = "Посмотреть";
            this.buttonAppointmentInfo.UseVisualStyleBackColor = true;
            this.buttonAppointmentInfo.Click += new System.EventHandler(this.buttonAppointmentInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество приемов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Приемов сегодня";
            // 
            // listBoxAppointments
            // 
            this.listBoxAppointments.FormattingEnabled = true;
            this.listBoxAppointments.Location = new System.Drawing.Point(6, 19);
            this.listBoxAppointments.Name = "listBoxAppointments";
            this.listBoxAppointments.Size = new System.Drawing.Size(140, 251);
            this.listBoxAppointments.TabIndex = 1;
            this.listBoxAppointments.SelectedIndexChanged += new System.EventHandler(this.listBoxAppointments_SelectedIndexChanged);
            // 
            // groupBoxContacts
            // 
            this.groupBoxContacts.Controls.Add(this.textBoxPhone);
            this.groupBoxContacts.Controls.Add(this.textBoxAccess);
            this.groupBoxContacts.Controls.Add(this.label10);
            this.groupBoxContacts.Controls.Add(this.textBoxEmail);
            this.groupBoxContacts.Controls.Add(this.label16);
            this.groupBoxContacts.Controls.Add(this.label17);
            this.groupBoxContacts.Location = new System.Drawing.Point(149, 134);
            this.groupBoxContacts.Name = "groupBoxContacts";
            this.groupBoxContacts.Size = new System.Drawing.Size(325, 148);
            this.groupBoxContacts.TabIndex = 8;
            this.groupBoxContacts.TabStop = false;
            this.groupBoxContacts.Text = "Контакты и доступ";
            // 
            // textBoxAccess
            // 
            this.textBoxAccess.Location = new System.Drawing.Point(125, 35);
            this.textBoxAccess.Name = "textBoxAccess";
            this.textBoxAccess.ReadOnly = true;
            this.textBoxAccess.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccess.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Права доступа";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(9, 85);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(84, 20);
            this.textBoxEmail.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Эл. Почта";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Моб. Телефон";
            // 
            // groupBoxRank
            // 
            this.groupBoxRank.Controls.Add(this.textBoxEmploymentDate);
            this.groupBoxRank.Controls.Add(this.textBoxPosition);
            this.groupBoxRank.Controls.Add(this.textBoxSpecialty);
            this.groupBoxRank.Controls.Add(this.textBoxQualification);
            this.groupBoxRank.Controls.Add(this.label20);
            this.groupBoxRank.Controls.Add(this.label19);
            this.groupBoxRank.Controls.Add(this.label18);
            this.groupBoxRank.Controls.Add(this.label9);
            this.groupBoxRank.Location = new System.Drawing.Point(149, 288);
            this.groupBoxRank.Name = "groupBoxRank";
            this.groupBoxRank.Size = new System.Drawing.Size(325, 125);
            this.groupBoxRank.TabIndex = 9;
            this.groupBoxRank.TabStop = false;
            this.groupBoxRank.Text = "Специальность и должность";
            // 
            // textBoxEmploymentDate
            // 
            this.textBoxEmploymentDate.Location = new System.Drawing.Point(223, 85);
            this.textBoxEmploymentDate.Name = "textBoxEmploymentDate";
            this.textBoxEmploymentDate.ReadOnly = true;
            this.textBoxEmploymentDate.Size = new System.Drawing.Size(84, 20);
            this.textBoxEmploymentDate.TabIndex = 12;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(9, 85);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.ReadOnly = true;
            this.textBoxPosition.Size = new System.Drawing.Size(84, 20);
            this.textBoxPosition.TabIndex = 11;
            // 
            // textBoxSpecialty
            // 
            this.textBoxSpecialty.Location = new System.Drawing.Point(223, 35);
            this.textBoxSpecialty.Name = "textBoxSpecialty";
            this.textBoxSpecialty.ReadOnly = true;
            this.textBoxSpecialty.Size = new System.Drawing.Size(84, 20);
            this.textBoxSpecialty.TabIndex = 10;
            // 
            // textBoxQualification
            // 
            this.textBoxQualification.Location = new System.Drawing.Point(9, 35);
            this.textBoxQualification.Name = "textBoxQualification";
            this.textBoxQualification.ReadOnly = true;
            this.textBoxQualification.Size = new System.Drawing.Size(84, 20);
            this.textBoxQualification.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Должность";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(220, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Дата трудоустройства";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(220, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Специальность";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Квалификация";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(43, 11);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 18;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Поиск";
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(9, 85);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.ReadOnly = true;
            this.textBoxBirthDate.Size = new System.Drawing.Size(84, 20);
            this.textBoxBirthDate.TabIndex = 17;
            // 
            // textBoxSex
            // 
            this.textBoxSex.Location = new System.Drawing.Point(125, 85);
            this.textBoxSex.Name = "textBoxSex";
            this.textBoxSex.ReadOnly = true;
            this.textBoxSex.Size = new System.Drawing.Size(84, 20);
            this.textBoxSex.TabIndex = 18;
            // 
            // textBoxRegistrationDate
            // 
            this.textBoxRegistrationDate.Location = new System.Drawing.Point(223, 85);
            this.textBoxRegistrationDate.Name = "textBoxRegistrationDate";
            this.textBoxRegistrationDate.ReadOnly = true;
            this.textBoxRegistrationDate.Size = new System.Drawing.Size(84, 20);
            this.textBoxRegistrationDate.TabIndex = 19;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(9, 35);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(84, 20);
            this.textBoxPhone.TabIndex = 20;
            // 
            // StaffUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.groupBoxRank);
            this.Controls.Add(this.groupBoxContacts);
            this.Controls.Add(this.groupBoxAppointments);
            this.Controls.Add(this.groupBoxPersonalInfo);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxStaff);
            this.Name = "StaffUserControl";
            this.Size = new System.Drawing.Size(810, 416);
            this.groupBoxPersonalInfo.ResumeLayout(false);
            this.groupBoxPersonalInfo.PerformLayout();
            this.groupBoxAppointments.ResumeLayout(false);
            this.groupBoxAppointments.PerformLayout();
            this.groupBoxContacts.ResumeLayout(false);
            this.groupBoxContacts.PerformLayout();
            this.groupBoxRank.ResumeLayout(false);
            this.groupBoxRank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxStaff;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxPersonalInfo;
        private System.Windows.Forms.GroupBox groupBoxAppointments;
        private System.Windows.Forms.GroupBox groupBoxContacts;
        private System.Windows.Forms.GroupBox groupBoxRank;
        private System.Windows.Forms.ListBox listBoxAppointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAppointmentInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxSpecialty;
        private System.Windows.Forms.TextBox textBoxQualification;
        private System.Windows.Forms.TextBox textBoxEmploymentDate;
        private System.Windows.Forms.TextBox textBoxAllAppointments;
        private System.Windows.Forms.TextBox textBoxTodayAppointments;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxAccess;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.TextBox textBoxSex;
        private System.Windows.Forms.TextBox textBoxRegistrationDate;
        private System.Windows.Forms.TextBox textBoxPhone;
    }
}
