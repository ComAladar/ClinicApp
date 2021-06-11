namespace ClinicAppUI.UserControls
{
    partial class HomeUserControl
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.textBoxRegistrationDate = new System.Windows.Forms.TextBox();
            this.textBoxSpecialty = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxQualification = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTemplates = new System.Windows.Forms.GroupBox();
            this.groupBoxSchedule = new System.Windows.Forms.GroupBox();
            this.buttonPatientData = new System.Windows.Forms.Button();
            this.buttonAddAppointment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxAppointments = new System.Windows.Forms.ListBox();
            this.groupBoxMessages = new System.Windows.Forms.GroupBox();
            this.buttonAddMessage = new System.Windows.Forms.Button();
            this.dataGridViewMessages = new System.Windows.Forms.DataGridView();
            this.timerAppointment = new System.Windows.Forms.Timer(this.components);
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxUserInfo.SuspendLayout();
            this.groupBoxSchedule.SuspendLayout();
            this.groupBoxMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.checkBoxShowPassword);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Controls.Add(this.labelPassword);
            this.groupBoxLogin.Controls.Add(this.textBoxLogin);
            this.groupBoxLogin.Controls.Add(this.labelLogin);
            this.groupBoxLogin.Location = new System.Drawing.Point(3, 3);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(231, 130);
            this.groupBoxLogin.TabIndex = 1;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Вход в систему";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(6, 100);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(114, 17);
            this.checkBoxShowPassword.TabIndex = 0;
            this.checkBoxShowPassword.Text = "Показать пароль";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(143, 101);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(82, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(6, 74);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "bagrpassmy";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 58);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(6, 35);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 4;
            this.textBoxLogin.Text = "bargovacc";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(6, 19);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин";
            // 
            // groupBoxUserInfo
            // 
            this.groupBoxUserInfo.Controls.Add(this.textBoxRegistrationDate);
            this.groupBoxUserInfo.Controls.Add(this.textBoxSpecialty);
            this.groupBoxUserInfo.Controls.Add(this.textBoxPosition);
            this.groupBoxUserInfo.Controls.Add(this.textBoxQualification);
            this.groupBoxUserInfo.Controls.Add(this.label8);
            this.groupBoxUserInfo.Controls.Add(this.label5);
            this.groupBoxUserInfo.Controls.Add(this.label4);
            this.groupBoxUserInfo.Controls.Add(this.label18);
            this.groupBoxUserInfo.Controls.Add(this.textBoxFullName);
            this.groupBoxUserInfo.Controls.Add(this.label1);
            this.groupBoxUserInfo.Enabled = false;
            this.groupBoxUserInfo.Location = new System.Drawing.Point(3, 139);
            this.groupBoxUserInfo.Name = "groupBoxUserInfo";
            this.groupBoxUserInfo.Size = new System.Drawing.Size(231, 274);
            this.groupBoxUserInfo.TabIndex = 2;
            this.groupBoxUserInfo.TabStop = false;
            this.groupBoxUserInfo.Text = "Информация пользователя";
            // 
            // textBoxRegistrationDate
            // 
            this.textBoxRegistrationDate.Location = new System.Drawing.Point(6, 191);
            this.textBoxRegistrationDate.Name = "textBoxRegistrationDate";
            this.textBoxRegistrationDate.ReadOnly = true;
            this.textBoxRegistrationDate.Size = new System.Drawing.Size(219, 20);
            this.textBoxRegistrationDate.TabIndex = 0;
            // 
            // textBoxSpecialty
            // 
            this.textBoxSpecialty.Location = new System.Drawing.Point(6, 152);
            this.textBoxSpecialty.Name = "textBoxSpecialty";
            this.textBoxSpecialty.ReadOnly = true;
            this.textBoxSpecialty.Size = new System.Drawing.Size(219, 20);
            this.textBoxSpecialty.TabIndex = 5;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(6, 113);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.ReadOnly = true;
            this.textBoxPosition.Size = new System.Drawing.Size(219, 20);
            this.textBoxPosition.TabIndex = 5;
            // 
            // textBoxQualification
            // 
            this.textBoxQualification.Location = new System.Drawing.Point(6, 74);
            this.textBoxQualification.Name = "textBoxQualification";
            this.textBoxQualification.ReadOnly = true;
            this.textBoxQualification.Size = new System.Drawing.Size(219, 20);
            this.textBoxQualification.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Дата регистрации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Квалификация";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Специальность";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(6, 35);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.ReadOnly = true;
            this.textBoxFullName.Size = new System.Drawing.Size(219, 20);
            this.textBoxFullName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ф.И.О. Пользователя";
            // 
            // groupBoxTemplates
            // 
            this.groupBoxTemplates.Enabled = false;
            this.groupBoxTemplates.Location = new System.Drawing.Point(576, 139);
            this.groupBoxTemplates.Name = "groupBoxTemplates";
            this.groupBoxTemplates.Size = new System.Drawing.Size(231, 274);
            this.groupBoxTemplates.TabIndex = 3;
            this.groupBoxTemplates.TabStop = false;
            this.groupBoxTemplates.Text = "Шаблоны документов";
            // 
            // groupBoxSchedule
            // 
            this.groupBoxSchedule.Controls.Add(this.buttonPatientData);
            this.groupBoxSchedule.Controls.Add(this.buttonAddAppointment);
            this.groupBoxSchedule.Controls.Add(this.label6);
            this.groupBoxSchedule.Controls.Add(this.listBoxAppointments);
            this.groupBoxSchedule.Enabled = false;
            this.groupBoxSchedule.Location = new System.Drawing.Point(240, 139);
            this.groupBoxSchedule.Name = "groupBoxSchedule";
            this.groupBoxSchedule.Size = new System.Drawing.Size(330, 274);
            this.groupBoxSchedule.TabIndex = 4;
            this.groupBoxSchedule.TabStop = false;
            this.groupBoxSchedule.Text = "Расписание";
            // 
            // buttonPatientData
            // 
            this.buttonPatientData.Location = new System.Drawing.Point(79, 240);
            this.buttonPatientData.Name = "buttonPatientData";
            this.buttonPatientData.Size = new System.Drawing.Size(119, 23);
            this.buttonPatientData.TabIndex = 5;
            this.buttonPatientData.Text = "Данные пациента";
            this.buttonPatientData.UseVisualStyleBackColor = true;
            this.buttonPatientData.Click += new System.EventHandler(this.buttonPatientData_Click);
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.Location = new System.Drawing.Point(204, 240);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(120, 23);
            this.buttonAddAppointment.TabIndex = 2;
            this.buttonAddAppointment.Text = "Начать прием";
            this.buttonAddAppointment.UseVisualStyleBackColor = true;
            this.buttonAddAppointment.Click += new System.EventHandler(this.buttonAddAppointment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Приемы сегодня";
            // 
            // listBoxAppointments
            // 
            this.listBoxAppointments.FormattingEnabled = true;
            this.listBoxAppointments.Location = new System.Drawing.Point(6, 35);
            this.listBoxAppointments.Name = "listBoxAppointments";
            this.listBoxAppointments.Size = new System.Drawing.Size(318, 199);
            this.listBoxAppointments.TabIndex = 0;
            this.listBoxAppointments.SelectedIndexChanged += new System.EventHandler(this.listBoxAppointments_SelectedIndexChanged);
            // 
            // groupBoxMessages
            // 
            this.groupBoxMessages.Controls.Add(this.buttonAddMessage);
            this.groupBoxMessages.Controls.Add(this.dataGridViewMessages);
            this.groupBoxMessages.Enabled = false;
            this.groupBoxMessages.Location = new System.Drawing.Point(246, 3);
            this.groupBoxMessages.Name = "groupBoxMessages";
            this.groupBoxMessages.Size = new System.Drawing.Size(561, 130);
            this.groupBoxMessages.TabIndex = 5;
            this.groupBoxMessages.TabStop = false;
            this.groupBoxMessages.Text = "Обьявления";
            // 
            // buttonAddMessage
            // 
            this.buttonAddMessage.Location = new System.Drawing.Point(511, 101);
            this.buttonAddMessage.Name = "buttonAddMessage";
            this.buttonAddMessage.Size = new System.Drawing.Size(44, 23);
            this.buttonAddMessage.TabIndex = 0;
            this.buttonAddMessage.Text = "Добав";
            this.buttonAddMessage.UseVisualStyleBackColor = true;
            this.buttonAddMessage.Click += new System.EventHandler(this.buttonAddMessage_Click);
            // 
            // dataGridViewMessages
            // 
            this.dataGridViewMessages.AllowUserToAddRows = false;
            this.dataGridViewMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessages.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMessages.Name = "dataGridViewMessages";
            this.dataGridViewMessages.ReadOnly = true;
            this.dataGridViewMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMessages.Size = new System.Drawing.Size(499, 105);
            this.dataGridViewMessages.TabIndex = 0;
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxMessages);
            this.Controls.Add(this.groupBoxSchedule);
            this.Controls.Add(this.groupBoxTemplates);
            this.Controls.Add(this.groupBoxUserInfo);
            this.Controls.Add(this.groupBoxLogin);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(810, 416);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxUserInfo.ResumeLayout(false);
            this.groupBoxUserInfo.PerformLayout();
            this.groupBoxSchedule.ResumeLayout(false);
            this.groupBoxSchedule.PerformLayout();
            this.groupBoxMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.GroupBox groupBoxUserInfo;
        private System.Windows.Forms.GroupBox groupBoxTemplates;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxSchedule;
        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxAppointments;
        private System.Windows.Forms.TextBox textBoxSpecialty;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxQualification;
        private System.Windows.Forms.Button buttonPatientData;
        private System.Windows.Forms.GroupBox groupBoxMessages;
        private System.Windows.Forms.DataGridView dataGridViewMessages;
        private System.Windows.Forms.Button buttonAddMessage;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.TextBox textBoxRegistrationDate;
        private System.Windows.Forms.Timer timerAppointment;
    }
}
