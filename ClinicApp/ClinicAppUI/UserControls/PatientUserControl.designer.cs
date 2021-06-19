namespace ClinicAppUI.UserControls
{
    partial class PatientUserControl
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
            this.listBoxPatients = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxRegistrationDate = new System.Windows.Forms.TextBox();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxSex = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxFlat = new System.Windows.Forms.TextBox();
            this.textBoxPorch = new System.Windows.Forms.TextBox();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBoxMiscInfo = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxAppointments = new System.Windows.Forms.ListBox();
            this.buttonAppointmentInfo = new System.Windows.Forms.Button();
            this.panelSelectedControlText = new System.Windows.Forms.Panel();
            this.labelCurrentControl = new System.Windows.Forms.Label();
            this.panelPatientSelect = new System.Windows.Forms.Panel();
            this.labelPatientsText = new System.Windows.Forms.Label();
            this.panelPersonalInfo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelAppointments = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelContacts = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panelMisc = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panelSelectedControlText.SuspendLayout();
            this.panelPatientSelect.SuspendLayout();
            this.panelPersonalInfo.SuspendLayout();
            this.panelAppointments.SuspendLayout();
            this.panelContacts.SuspendLayout();
            this.panelMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPatients
            // 
            this.listBoxPatients.FormattingEnabled = true;
            this.listBoxPatients.Location = new System.Drawing.Point(13, 66);
            this.listBoxPatients.Name = "listBoxPatients";
            this.listBoxPatients.Size = new System.Drawing.Size(165, 459);
            this.listBoxPatients.TabIndex = 1;
            this.listBoxPatients.SelectedIndexChanged += new System.EventHandler(this.listBoxPatients_SelectedIndexChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Image = global::ClinicAppUI.Properties.Resources.EditItem;
            this.buttonEdit.Location = new System.Drawing.Point(102, 526);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(38, 38);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Image = global::ClinicAppUI.Properties.Resources.RemoveItem;
            this.buttonDelete.Location = new System.Drawing.Point(143, 526);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(38, 38);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxRegistrationDate
            // 
            this.textBoxRegistrationDate.Location = new System.Drawing.Point(124, 257);
            this.textBoxRegistrationDate.Name = "textBoxRegistrationDate";
            this.textBoxRegistrationDate.ReadOnly = true;
            this.textBoxRegistrationDate.Size = new System.Drawing.Size(116, 20);
            this.textBoxRegistrationDate.TabIndex = 18;
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(124, 207);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.ReadOnly = true;
            this.textBoxBirthDate.Size = new System.Drawing.Size(116, 20);
            this.textBoxBirthDate.TabIndex = 17;
            // 
            // textBoxSex
            // 
            this.textBoxSex.Location = new System.Drawing.Point(17, 207);
            this.textBoxSex.Name = "textBoxSex";
            this.textBoxSex.ReadOnly = true;
            this.textBoxSex.Size = new System.Drawing.Size(101, 20);
            this.textBoxSex.TabIndex = 17;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(17, 158);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.ReadOnly = true;
            this.textBoxPatronymic.Size = new System.Drawing.Size(225, 20);
            this.textBoxPatronymic.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(17, 113);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(225, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(17, 63);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(225, 20);
            this.textBoxSurname.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(123, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата Рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(123, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Дата регистрации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(11, 212);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(156, 20);
            this.textBoxEmail.TabIndex = 16;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(11, 162);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(156, 20);
            this.textBoxPhone.TabIndex = 15;
            // 
            // textBoxFlat
            // 
            this.textBoxFlat.Location = new System.Drawing.Point(266, 112);
            this.textBoxFlat.Name = "textBoxFlat";
            this.textBoxFlat.ReadOnly = true;
            this.textBoxFlat.Size = new System.Drawing.Size(84, 20);
            this.textBoxFlat.TabIndex = 14;
            // 
            // textBoxPorch
            // 
            this.textBoxPorch.Location = new System.Drawing.Point(139, 112);
            this.textBoxPorch.Name = "textBoxPorch";
            this.textBoxPorch.ReadOnly = true;
            this.textBoxPorch.Size = new System.Drawing.Size(84, 20);
            this.textBoxPorch.TabIndex = 13;
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Location = new System.Drawing.Point(11, 112);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.ReadOnly = true;
            this.textBoxHouse.Size = new System.Drawing.Size(84, 20);
            this.textBoxHouse.TabIndex = 12;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(188, 62);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.ReadOnly = true;
            this.textBoxStreet.Size = new System.Drawing.Size(162, 20);
            this.textBoxStreet.TabIndex = 11;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(11, 62);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.ReadOnly = true;
            this.textBoxCity.Size = new System.Drawing.Size(156, 20);
            this.textBoxCity.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(13, 146);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Моб. Телефон";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(13, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Эл. Почта";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(268, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Квартира";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(141, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Корпус";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(13, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Дом";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(185, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Улица/проспект";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Город";
            // 
            // richTextBoxMiscInfo
            // 
            this.richTextBoxMiscInfo.Location = new System.Drawing.Point(11, 37);
            this.richTextBoxMiscInfo.Name = "richTextBoxMiscInfo";
            this.richTextBoxMiscInfo.ReadOnly = true;
            this.richTextBoxMiscInfo.Size = new System.Drawing.Size(385, 214);
            this.richTextBoxMiscInfo.TabIndex = 0;
            this.richTextBoxMiscInfo.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Image = global::ClinicAppUI.Properties.Resources.AddItem;
            this.buttonAdd.Location = new System.Drawing.Point(61, 526);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(38, 38);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(13, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(53, 38);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(125, 20);
            this.textBoxSearch.TabIndex = 20;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // listBoxAppointments
            // 
            this.listBoxAppointments.FormattingEnabled = true;
            this.listBoxAppointments.Location = new System.Drawing.Point(9, 37);
            this.listBoxAppointments.Name = "listBoxAppointments";
            this.listBoxAppointments.Size = new System.Drawing.Size(489, 225);
            this.listBoxAppointments.TabIndex = 0;
            this.listBoxAppointments.SelectedIndexChanged += new System.EventHandler(this.listBoxAppointments_SelectedIndexChanged);
            // 
            // buttonAppointmentInfo
            // 
            this.buttonAppointmentInfo.Location = new System.Drawing.Point(403, 268);
            this.buttonAppointmentInfo.Name = "buttonAppointmentInfo";
            this.buttonAppointmentInfo.Size = new System.Drawing.Size(95, 30);
            this.buttonAppointmentInfo.TabIndex = 5;
            this.buttonAppointmentInfo.Text = "Посмотреть выбранный визит";
            this.buttonAppointmentInfo.UseVisualStyleBackColor = true;
            this.buttonAppointmentInfo.Click += new System.EventHandler(this.buttonAppointmentInfo_Click);
            // 
            // panelSelectedControlText
            // 
            this.panelSelectedControlText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelSelectedControlText.Controls.Add(this.labelCurrentControl);
            this.panelSelectedControlText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelectedControlText.Location = new System.Drawing.Point(0, 0);
            this.panelSelectedControlText.Name = "panelSelectedControlText";
            this.panelSelectedControlText.Size = new System.Drawing.Size(977, 65);
            this.panelSelectedControlText.TabIndex = 21;
            // 
            // labelCurrentControl
            // 
            this.labelCurrentControl.AutoSize = true;
            this.labelCurrentControl.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelCurrentControl.Location = new System.Drawing.Point(381, 19);
            this.labelCurrentControl.Name = "labelCurrentControl";
            this.labelCurrentControl.Size = new System.Drawing.Size(110, 25);
            this.labelCurrentControl.TabIndex = 5;
            this.labelCurrentControl.Text = "Пациенты";
            // 
            // panelPatientSelect
            // 
            this.panelPatientSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelPatientSelect.Controls.Add(this.labelPatientsText);
            this.panelPatientSelect.Controls.Add(this.listBoxPatients);
            this.panelPatientSelect.Controls.Add(this.label21);
            this.panelPatientSelect.Controls.Add(this.buttonEdit);
            this.panelPatientSelect.Controls.Add(this.textBoxSearch);
            this.panelPatientSelect.Controls.Add(this.buttonDelete);
            this.panelPatientSelect.Controls.Add(this.buttonAdd);
            this.panelPatientSelect.Location = new System.Drawing.Point(3, 71);
            this.panelPatientSelect.Name = "panelPatientSelect";
            this.panelPatientSelect.Size = new System.Drawing.Size(181, 571);
            this.panelPatientSelect.TabIndex = 22;
            // 
            // labelPatientsText
            // 
            this.labelPatientsText.AutoSize = true;
            this.labelPatientsText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientsText.ForeColor = System.Drawing.Color.White;
            this.labelPatientsText.Location = new System.Drawing.Point(6, 9);
            this.labelPatientsText.Name = "labelPatientsText";
            this.labelPatientsText.Size = new System.Drawing.Size(173, 25);
            this.labelPatientsText.TabIndex = 2;
            this.labelPatientsText.Text = "Выбор пациента";
            // 
            // panelPersonalInfo
            // 
            this.panelPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelPersonalInfo.Controls.Add(this.textBoxRegistrationDate);
            this.panelPersonalInfo.Controls.Add(this.label5);
            this.panelPersonalInfo.Controls.Add(this.textBoxBirthDate);
            this.panelPersonalInfo.Controls.Add(this.label1);
            this.panelPersonalInfo.Controls.Add(this.textBoxPatronymic);
            this.panelPersonalInfo.Controls.Add(this.label2);
            this.panelPersonalInfo.Controls.Add(this.textBoxName);
            this.panelPersonalInfo.Controls.Add(this.label3);
            this.panelPersonalInfo.Controls.Add(this.textBoxSex);
            this.panelPersonalInfo.Controls.Add(this.label4);
            this.panelPersonalInfo.Controls.Add(this.label7);
            this.panelPersonalInfo.Controls.Add(this.textBoxSurname);
            this.panelPersonalInfo.Controls.Add(this.label6);
            this.panelPersonalInfo.Location = new System.Drawing.Point(190, 71);
            this.panelPersonalInfo.Name = "panelPersonalInfo";
            this.panelPersonalInfo.Size = new System.Drawing.Size(276, 304);
            this.panelPersonalInfo.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Персональные данные";
            // 
            // panelAppointments
            // 
            this.panelAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelAppointments.Controls.Add(this.buttonAppointmentInfo);
            this.panelAppointments.Controls.Add(this.label8);
            this.panelAppointments.Controls.Add(this.listBoxAppointments);
            this.panelAppointments.Location = new System.Drawing.Point(472, 71);
            this.panelAppointments.Name = "panelAppointments";
            this.panelAppointments.Size = new System.Drawing.Size(505, 304);
            this.panelAppointments.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Приемы";
            // 
            // panelContacts
            // 
            this.panelContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelContacts.Controls.Add(this.textBoxEmail);
            this.panelContacts.Controls.Add(this.label9);
            this.panelContacts.Controls.Add(this.textBoxPhone);
            this.panelContacts.Controls.Add(this.label10);
            this.panelContacts.Controls.Add(this.textBoxFlat);
            this.panelContacts.Controls.Add(this.label12);
            this.panelContacts.Controls.Add(this.textBoxPorch);
            this.panelContacts.Controls.Add(this.label13);
            this.panelContacts.Controls.Add(this.textBoxHouse);
            this.panelContacts.Controls.Add(this.label14);
            this.panelContacts.Controls.Add(this.textBoxStreet);
            this.panelContacts.Controls.Add(this.label15);
            this.panelContacts.Controls.Add(this.textBoxCity);
            this.panelContacts.Controls.Add(this.label16);
            this.panelContacts.Controls.Add(this.label17);
            this.panelContacts.Location = new System.Drawing.Point(190, 381);
            this.panelContacts.Name = "panelContacts";
            this.panelContacts.Size = new System.Drawing.Size(378, 261);
            this.panelContacts.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Контакты и адрес";
            // 
            // panelMisc
            // 
            this.panelMisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelMisc.Controls.Add(this.richTextBoxMiscInfo);
            this.panelMisc.Controls.Add(this.label11);
            this.panelMisc.Location = new System.Drawing.Point(574, 381);
            this.panelMisc.Name = "panelMisc";
            this.panelMisc.Size = new System.Drawing.Size(403, 261);
            this.panelMisc.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(306, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Дополнительная информация";
            // 
            // PatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panelMisc);
            this.Controls.Add(this.panelContacts);
            this.Controls.Add(this.panelAppointments);
            this.Controls.Add(this.panelPersonalInfo);
            this.Controls.Add(this.panelPatientSelect);
            this.Controls.Add(this.panelSelectedControlText);
            this.Name = "PatientUserControl";
            this.Size = new System.Drawing.Size(977, 645);
            this.panelSelectedControlText.ResumeLayout(false);
            this.panelSelectedControlText.PerformLayout();
            this.panelPatientSelect.ResumeLayout(false);
            this.panelPatientSelect.PerformLayout();
            this.panelPersonalInfo.ResumeLayout(false);
            this.panelPersonalInfo.PerformLayout();
            this.panelAppointments.ResumeLayout(false);
            this.panelAppointments.PerformLayout();
            this.panelContacts.ResumeLayout(false);
            this.panelContacts.PerformLayout();
            this.panelMisc.ResumeLayout(false);
            this.panelMisc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxPatients;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBoxMiscInfo;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxFlat;
        private System.Windows.Forms.TextBox textBoxPorch;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxRegistrationDate;
        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.TextBox textBoxSex;
        private System.Windows.Forms.ListBox listBoxAppointments;
        private System.Windows.Forms.Button buttonAppointmentInfo;
        private System.Windows.Forms.Panel panelSelectedControlText;
        private System.Windows.Forms.Label labelCurrentControl;
        private System.Windows.Forms.Panel panelPatientSelect;
        private System.Windows.Forms.Label labelPatientsText;
        private System.Windows.Forms.Panel panelPersonalInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelAppointments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelContacts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelMisc;
        private System.Windows.Forms.Label label11;
    }
}
