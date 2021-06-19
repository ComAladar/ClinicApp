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
            this.buttonAppointmentInfo = new System.Windows.Forms.Button();
            this.listBoxAppointments = new System.Windows.Forms.ListBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAccess = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
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
            this.panelStaff = new System.Windows.Forms.Panel();
            this.labelStaffText = new System.Windows.Forms.Label();
            this.panelSelectedControlText = new System.Windows.Forms.Panel();
            this.labelCurrentControl = new System.Windows.Forms.Label();
            this.panelPersonalInfo = new System.Windows.Forms.Panel();
            this.textBoxRegistrationDate = new System.Windows.Forms.TextBox();
            this.textBoxSex = new System.Windows.Forms.TextBox();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRank = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.panelAppointments = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelContacts = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelStaff.SuspendLayout();
            this.panelSelectedControlText.SuspendLayout();
            this.panelPersonalInfo.SuspendLayout();
            this.panelRank.SuspendLayout();
            this.panelAppointments.SuspendLayout();
            this.panelContacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxStaff
            // 
            this.listBoxStaff.FormattingEnabled = true;
            this.listBoxStaff.Location = new System.Drawing.Point(13, 66);
            this.listBoxStaff.Name = "listBoxStaff";
            this.listBoxStaff.Size = new System.Drawing.Size(165, 459);
            this.listBoxStaff.TabIndex = 2;
            this.listBoxStaff.SelectedIndexChanged += new System.EventHandler(this.listBoxStaff_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Image = global::ClinicAppUI.Properties.Resources.AddItem;
            this.buttonAdd.Location = new System.Drawing.Point(61, 526);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(38, 38);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Image = global::ClinicAppUI.Properties.Resources.EditItem;
            this.buttonEdit.Location = new System.Drawing.Point(102, 526);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(38, 38);
            this.buttonEdit.TabIndex = 4;
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
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAppointmentInfo
            // 
            this.buttonAppointmentInfo.Location = new System.Drawing.Point(395, 268);
            this.buttonAppointmentInfo.Name = "buttonAppointmentInfo";
            this.buttonAppointmentInfo.Size = new System.Drawing.Size(95, 30);
            this.buttonAppointmentInfo.TabIndex = 5;
            this.buttonAppointmentInfo.Text = "Посмотреть";
            this.buttonAppointmentInfo.UseVisualStyleBackColor = true;
            this.buttonAppointmentInfo.Click += new System.EventHandler(this.buttonAppointmentInfo_Click);
            // 
            // listBoxAppointments
            // 
            this.listBoxAppointments.FormattingEnabled = true;
            this.listBoxAppointments.Location = new System.Drawing.Point(4, 37);
            this.listBoxAppointments.Name = "listBoxAppointments";
            this.listBoxAppointments.Size = new System.Drawing.Size(486, 225);
            this.listBoxAppointments.TabIndex = 1;
            this.listBoxAppointments.SelectedIndexChanged += new System.EventHandler(this.listBoxAppointments_SelectedIndexChanged);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(17, 63);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(223, 20);
            this.textBoxPhone.TabIndex = 20;
            // 
            // textBoxAccess
            // 
            this.textBoxAccess.Location = new System.Drawing.Point(17, 158);
            this.textBoxAccess.Name = "textBoxAccess";
            this.textBoxAccess.ReadOnly = true;
            this.textBoxAccess.Size = new System.Drawing.Size(223, 20);
            this.textBoxAccess.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Права доступа";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(17, 113);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(223, 20);
            this.textBoxEmail.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(14, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Эл. Почта";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(14, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Моб. Телефон";
            // 
            // textBoxEmploymentDate
            // 
            this.textBoxEmploymentDate.Location = new System.Drawing.Point(17, 207);
            this.textBoxEmploymentDate.Name = "textBoxEmploymentDate";
            this.textBoxEmploymentDate.ReadOnly = true;
            this.textBoxEmploymentDate.Size = new System.Drawing.Size(116, 20);
            this.textBoxEmploymentDate.TabIndex = 12;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(17, 113);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.ReadOnly = true;
            this.textBoxPosition.Size = new System.Drawing.Size(286, 20);
            this.textBoxPosition.TabIndex = 11;
            // 
            // textBoxSpecialty
            // 
            this.textBoxSpecialty.Location = new System.Drawing.Point(17, 158);
            this.textBoxSpecialty.Name = "textBoxSpecialty";
            this.textBoxSpecialty.ReadOnly = true;
            this.textBoxSpecialty.Size = new System.Drawing.Size(286, 20);
            this.textBoxSpecialty.TabIndex = 10;
            // 
            // textBoxQualification
            // 
            this.textBoxQualification.Location = new System.Drawing.Point(17, 63);
            this.textBoxQualification.Name = "textBoxQualification";
            this.textBoxQualification.ReadOnly = true;
            this.textBoxQualification.Size = new System.Drawing.Size(286, 20);
            this.textBoxQualification.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(14, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Должность";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(16, 191);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Дата трудоустройства";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(14, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Специальность";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Квалификация";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(48, 32);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(130, 20);
            this.textBoxSearch.TabIndex = 18;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(8, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Поиск";
            // 
            // panelStaff
            // 
            this.panelStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelStaff.Controls.Add(this.labelStaffText);
            this.panelStaff.Controls.Add(this.label21);
            this.panelStaff.Controls.Add(this.textBoxSearch);
            this.panelStaff.Controls.Add(this.listBoxStaff);
            this.panelStaff.Controls.Add(this.buttonAdd);
            this.panelStaff.Controls.Add(this.buttonEdit);
            this.panelStaff.Controls.Add(this.buttonDelete);
            this.panelStaff.Location = new System.Drawing.Point(3, 71);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(189, 571);
            this.panelStaff.TabIndex = 19;
            // 
            // labelStaffText
            // 
            this.labelStaffText.AutoSize = true;
            this.labelStaffText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffText.ForeColor = System.Drawing.Color.White;
            this.labelStaffText.Location = new System.Drawing.Point(6, 9);
            this.labelStaffText.Name = "labelStaffText";
            this.labelStaffText.Size = new System.Drawing.Size(184, 25);
            this.labelStaffText.TabIndex = 2;
            this.labelStaffText.Text = "Выбор персонала";
            // 
            // panelSelectedControlText
            // 
            this.panelSelectedControlText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelSelectedControlText.Controls.Add(this.labelCurrentControl);
            this.panelSelectedControlText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelectedControlText.Location = new System.Drawing.Point(0, 0);
            this.panelSelectedControlText.Name = "panelSelectedControlText";
            this.panelSelectedControlText.Size = new System.Drawing.Size(977, 65);
            this.panelSelectedControlText.TabIndex = 22;
            // 
            // labelCurrentControl
            // 
            this.labelCurrentControl.AutoSize = true;
            this.labelCurrentControl.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelCurrentControl.Location = new System.Drawing.Point(381, 19);
            this.labelCurrentControl.Name = "labelCurrentControl";
            this.labelCurrentControl.Size = new System.Drawing.Size(107, 25);
            this.labelCurrentControl.TabIndex = 5;
            this.labelCurrentControl.Text = "Персонал";
            // 
            // panelPersonalInfo
            // 
            this.panelPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelPersonalInfo.Controls.Add(this.textBoxRegistrationDate);
            this.panelPersonalInfo.Controls.Add(this.textBoxSex);
            this.panelPersonalInfo.Controls.Add(this.textBoxBirthDate);
            this.panelPersonalInfo.Controls.Add(this.textBoxPatronymic);
            this.panelPersonalInfo.Controls.Add(this.textBoxName);
            this.panelPersonalInfo.Controls.Add(this.textBoxSurname);
            this.panelPersonalInfo.Controls.Add(this.label2);
            this.panelPersonalInfo.Controls.Add(this.label11);
            this.panelPersonalInfo.Controls.Add(this.label12);
            this.panelPersonalInfo.Controls.Add(this.label13);
            this.panelPersonalInfo.Controls.Add(this.label14);
            this.panelPersonalInfo.Controls.Add(this.label15);
            this.panelPersonalInfo.Controls.Add(this.label1);
            this.panelPersonalInfo.Location = new System.Drawing.Point(199, 71);
            this.panelPersonalInfo.Name = "panelPersonalInfo";
            this.panelPersonalInfo.Size = new System.Drawing.Size(276, 304);
            this.panelPersonalInfo.TabIndex = 24;
            // 
            // textBoxRegistrationDate
            // 
            this.textBoxRegistrationDate.Location = new System.Drawing.Point(124, 257);
            this.textBoxRegistrationDate.Name = "textBoxRegistrationDate";
            this.textBoxRegistrationDate.ReadOnly = true;
            this.textBoxRegistrationDate.Size = new System.Drawing.Size(116, 20);
            this.textBoxRegistrationDate.TabIndex = 31;
            // 
            // textBoxSex
            // 
            this.textBoxSex.Location = new System.Drawing.Point(17, 207);
            this.textBoxSex.Name = "textBoxSex";
            this.textBoxSex.ReadOnly = true;
            this.textBoxSex.Size = new System.Drawing.Size(101, 20);
            this.textBoxSex.TabIndex = 30;
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(124, 207);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.ReadOnly = true;
            this.textBoxBirthDate.Size = new System.Drawing.Size(116, 20);
            this.textBoxBirthDate.TabIndex = 29;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(17, 158);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.ReadOnly = true;
            this.textBoxPatronymic.Size = new System.Drawing.Size(225, 20);
            this.textBoxPatronymic.TabIndex = 28;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(17, 113);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(225, 20);
            this.textBoxName.TabIndex = 27;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(17, 63);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(225, 20);
            this.textBoxSurname.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Дата регистрации";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Пол";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(123, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Дата Рождения";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(14, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Отчество";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(14, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Имя";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(14, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Персональные данные";
            // 
            // panelRank
            // 
            this.panelRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelRank.Controls.Add(this.textBoxEmploymentDate);
            this.panelRank.Controls.Add(this.label22);
            this.panelRank.Controls.Add(this.textBoxPosition);
            this.panelRank.Controls.Add(this.label9);
            this.panelRank.Controls.Add(this.textBoxSpecialty);
            this.panelRank.Controls.Add(this.label18);
            this.panelRank.Controls.Add(this.textBoxQualification);
            this.panelRank.Controls.Add(this.label19);
            this.panelRank.Controls.Add(this.label20);
            this.panelRank.Location = new System.Drawing.Point(481, 381);
            this.panelRank.Name = "panelRank";
            this.panelRank.Size = new System.Drawing.Size(493, 261);
            this.panelRank.TabIndex = 25;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(6, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(297, 25);
            this.label22.TabIndex = 2;
            this.label22.Text = "Специальность и должность";
            // 
            // panelAppointments
            // 
            this.panelAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelAppointments.Controls.Add(this.buttonAppointmentInfo);
            this.panelAppointments.Controls.Add(this.label3);
            this.panelAppointments.Controls.Add(this.listBoxAppointments);
            this.panelAppointments.Location = new System.Drawing.Point(481, 71);
            this.panelAppointments.Name = "panelAppointments";
            this.panelAppointments.Size = new System.Drawing.Size(493, 305);
            this.panelAppointments.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Приемы";
            // 
            // panelContacts
            // 
            this.panelContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelContacts.Controls.Add(this.textBoxPhone);
            this.panelContacts.Controls.Add(this.label4);
            this.panelContacts.Controls.Add(this.textBoxAccess);
            this.panelContacts.Controls.Add(this.label17);
            this.panelContacts.Controls.Add(this.label10);
            this.panelContacts.Controls.Add(this.label16);
            this.panelContacts.Controls.Add(this.textBoxEmail);
            this.panelContacts.Location = new System.Drawing.Point(199, 381);
            this.panelContacts.Name = "panelContacts";
            this.panelContacts.Size = new System.Drawing.Size(276, 261);
            this.panelContacts.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Контакты и доступ";
            // 
            // StaffUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panelContacts);
            this.Controls.Add(this.panelAppointments);
            this.Controls.Add(this.panelRank);
            this.Controls.Add(this.panelPersonalInfo);
            this.Controls.Add(this.panelSelectedControlText);
            this.Controls.Add(this.panelStaff);
            this.Name = "StaffUserControl";
            this.Size = new System.Drawing.Size(977, 645);
            this.panelStaff.ResumeLayout(false);
            this.panelStaff.PerformLayout();
            this.panelSelectedControlText.ResumeLayout(false);
            this.panelSelectedControlText.PerformLayout();
            this.panelPersonalInfo.ResumeLayout(false);
            this.panelPersonalInfo.PerformLayout();
            this.panelRank.ResumeLayout(false);
            this.panelRank.PerformLayout();
            this.panelAppointments.ResumeLayout(false);
            this.panelAppointments.PerformLayout();
            this.panelContacts.ResumeLayout(false);
            this.panelContacts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxStaff;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxAppointments;
        private System.Windows.Forms.Button buttonAppointmentInfo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxSpecialty;
        private System.Windows.Forms.TextBox textBoxQualification;
        private System.Windows.Forms.TextBox textBoxEmploymentDate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxAccess;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Panel panelStaff;
        private System.Windows.Forms.Label labelStaffText;
        private System.Windows.Forms.Panel panelSelectedControlText;
        private System.Windows.Forms.Label labelCurrentControl;
        private System.Windows.Forms.Panel panelPersonalInfo;
        private System.Windows.Forms.TextBox textBoxRegistrationDate;
        private System.Windows.Forms.TextBox textBoxSex;
        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRank;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panelAppointments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelContacts;
        private System.Windows.Forms.Label label4;
    }
}
