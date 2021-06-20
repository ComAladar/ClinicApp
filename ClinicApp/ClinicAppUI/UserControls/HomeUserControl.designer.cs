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
            this.buttonPatientData = new System.Windows.Forms.Button();
            this.buttonAddAppointment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxAppointments = new System.Windows.Forms.ListBox();
            this.buttonAddMessage = new System.Windows.Forms.Button();
            this.dataGridViewMessages = new System.Windows.Forms.DataGridView();
            this.timerAppointment = new System.Windows.Forms.Timer(this.components);
            this.panelSelectedControlText = new System.Windows.Forms.Panel();
            this.labelCurrentControl = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelLoginText = new System.Windows.Forms.Label();
            this.panelTemplates = new System.Windows.Forms.Panel();
            this.buttonServiceFees = new System.Windows.Forms.Button();
            this.buttonPersonalDataProcessing = new System.Windows.Forms.Button();
            this.buttonMedicinalIntervation = new System.Windows.Forms.Button();
            this.labelTemplatesText = new System.Windows.Forms.Label();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.labelMessagesText = new System.Windows.Forms.Label();
            this.panelSchedule = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).BeginInit();
            this.panelSelectedControlText.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelTemplates.SuspendLayout();
            this.panelMessages.SuspendLayout();
            this.panelSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPatientData
            // 
            this.buttonPatientData.Location = new System.Drawing.Point(9, 253);
            this.buttonPatientData.Name = "buttonPatientData";
            this.buttonPatientData.Size = new System.Drawing.Size(119, 30);
            this.buttonPatientData.TabIndex = 5;
            this.buttonPatientData.Text = "Данные пациента";
            this.buttonPatientData.UseVisualStyleBackColor = true;
            this.buttonPatientData.Click += new System.EventHandler(this.buttonPatientData_Click);
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.Location = new System.Drawing.Point(134, 253);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(120, 30);
            this.buttonAddAppointment.TabIndex = 2;
            this.buttonAddAppointment.Text = "Начать прием";
            this.buttonAddAppointment.UseVisualStyleBackColor = true;
            this.buttonAddAppointment.Click += new System.EventHandler(this.buttonAddAppointment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Приемы сегодня";
            // 
            // listBoxAppointments
            // 
            this.listBoxAppointments.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxAppointments.FormattingEnabled = true;
            this.listBoxAppointments.Location = new System.Drawing.Point(9, 48);
            this.listBoxAppointments.Name = "listBoxAppointments";
            this.listBoxAppointments.Size = new System.Drawing.Size(716, 199);
            this.listBoxAppointments.TabIndex = 0;
            this.listBoxAppointments.SelectedIndexChanged += new System.EventHandler(this.listBoxAppointments_SelectedIndexChanged);
            // 
            // buttonAddMessage
            // 
            this.buttonAddMessage.Location = new System.Drawing.Point(642, 227);
            this.buttonAddMessage.Name = "buttonAddMessage";
            this.buttonAddMessage.Size = new System.Drawing.Size(80, 30);
            this.buttonAddMessage.TabIndex = 0;
            this.buttonAddMessage.Text = "Добавить";
            this.buttonAddMessage.UseVisualStyleBackColor = true;
            this.buttonAddMessage.Click += new System.EventHandler(this.buttonAddMessage_Click);
            // 
            // dataGridViewMessages
            // 
            this.dataGridViewMessages.AllowUserToAddRows = false;
            this.dataGridViewMessages.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessages.Location = new System.Drawing.Point(9, 36);
            this.dataGridViewMessages.Name = "dataGridViewMessages";
            this.dataGridViewMessages.ReadOnly = true;
            this.dataGridViewMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMessages.Size = new System.Drawing.Size(722, 185);
            this.dataGridViewMessages.TabIndex = 0;
            // 
            // panelSelectedControlText
            // 
            this.panelSelectedControlText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelSelectedControlText.Controls.Add(this.labelCurrentControl);
            this.panelSelectedControlText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelectedControlText.Location = new System.Drawing.Point(0, 0);
            this.panelSelectedControlText.Name = "panelSelectedControlText";
            this.panelSelectedControlText.Size = new System.Drawing.Size(977, 65);
            this.panelSelectedControlText.TabIndex = 6;
            // 
            // labelCurrentControl
            // 
            this.labelCurrentControl.AutoSize = true;
            this.labelCurrentControl.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelCurrentControl.Location = new System.Drawing.Point(381, 19);
            this.labelCurrentControl.Name = "labelCurrentControl";
            this.labelCurrentControl.Size = new System.Drawing.Size(210, 25);
            this.labelCurrentControl.TabIndex = 5;
            this.labelCurrentControl.Text = "Домашняя страница";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(16, 81);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(16, 97);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(16, 42);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(148, 117);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(80, 30);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(16, 58);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 4;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.ForeColor = System.Drawing.Color.White;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(19, 122);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(114, 17);
            this.checkBoxShowPassword.TabIndex = 0;
            this.checkBoxShowPassword.Text = "Показать пароль";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelLogin.Controls.Add(this.labelLoginText);
            this.panelLogin.Controls.Add(this.checkBoxShowPassword);
            this.panelLogin.Controls.Add(this.textBoxLogin);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Location = new System.Drawing.Point(3, 71);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(231, 150);
            this.panelLogin.TabIndex = 1;
            // 
            // labelLoginText
            // 
            this.labelLoginText.AutoSize = true;
            this.labelLoginText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginText.ForeColor = System.Drawing.Color.White;
            this.labelLoginText.Location = new System.Drawing.Point(6, 9);
            this.labelLoginText.Name = "labelLoginText";
            this.labelLoginText.Size = new System.Drawing.Size(164, 25);
            this.labelLoginText.TabIndex = 1;
            this.labelLoginText.Text = "Вход в систему";
            // 
            // panelTemplates
            // 
            this.panelTemplates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelTemplates.Controls.Add(this.buttonServiceFees);
            this.panelTemplates.Controls.Add(this.buttonPersonalDataProcessing);
            this.panelTemplates.Controls.Add(this.buttonMedicinalIntervation);
            this.panelTemplates.Controls.Add(this.labelTemplatesText);
            this.panelTemplates.Enabled = false;
            this.panelTemplates.Location = new System.Drawing.Point(3, 227);
            this.panelTemplates.Name = "panelTemplates";
            this.panelTemplates.Size = new System.Drawing.Size(231, 413);
            this.panelTemplates.TabIndex = 7;
            // 
            // buttonServiceFees
            // 
            this.buttonServiceFees.Location = new System.Drawing.Point(11, 150);
            this.buttonServiceFees.Name = "buttonServiceFees";
            this.buttonServiceFees.Size = new System.Drawing.Size(211, 30);
            this.buttonServiceFees.TabIndex = 4;
            this.buttonServiceFees.Text = "Оказания платных услуг";
            this.buttonServiceFees.UseVisualStyleBackColor = true;
            this.buttonServiceFees.Click += new System.EventHandler(this.buttonServiceFees_Click);
            // 
            // buttonPersonalDataProcessing
            // 
            this.buttonPersonalDataProcessing.Location = new System.Drawing.Point(11, 50);
            this.buttonPersonalDataProcessing.Name = "buttonPersonalDataProcessing";
            this.buttonPersonalDataProcessing.Size = new System.Drawing.Size(211, 30);
            this.buttonPersonalDataProcessing.TabIndex = 3;
            this.buttonPersonalDataProcessing.Text = "Обработка персональных данных";
            this.buttonPersonalDataProcessing.UseVisualStyleBackColor = true;
            this.buttonPersonalDataProcessing.Click += new System.EventHandler(this.buttonPersonalDataProcessing_Click);
            // 
            // buttonMedicinalIntervation
            // 
            this.buttonMedicinalIntervation.Location = new System.Drawing.Point(11, 100);
            this.buttonMedicinalIntervation.Name = "buttonMedicinalIntervation";
            this.buttonMedicinalIntervation.Size = new System.Drawing.Size(211, 30);
            this.buttonMedicinalIntervation.TabIndex = 3;
            this.buttonMedicinalIntervation.Text = "Медицинское вмешательство";
            this.buttonMedicinalIntervation.UseVisualStyleBackColor = true;
            this.buttonMedicinalIntervation.Click += new System.EventHandler(this.buttonMedicinalIntervation_Click);
            // 
            // labelTemplatesText
            // 
            this.labelTemplatesText.AutoSize = true;
            this.labelTemplatesText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemplatesText.ForeColor = System.Drawing.Color.White;
            this.labelTemplatesText.Location = new System.Drawing.Point(6, 9);
            this.labelTemplatesText.Name = "labelTemplatesText";
            this.labelTemplatesText.Size = new System.Drawing.Size(222, 25);
            this.labelTemplatesText.TabIndex = 2;
            this.labelTemplatesText.Text = "Шаблоны документов";
            // 
            // panelMessages
            // 
            this.panelMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelMessages.Controls.Add(this.buttonAddMessage);
            this.panelMessages.Controls.Add(this.labelMessagesText);
            this.panelMessages.Controls.Add(this.dataGridViewMessages);
            this.panelMessages.Enabled = false;
            this.panelMessages.Location = new System.Drawing.Point(240, 71);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(734, 272);
            this.panelMessages.TabIndex = 8;
            // 
            // labelMessagesText
            // 
            this.labelMessagesText.AutoSize = true;
            this.labelMessagesText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessagesText.ForeColor = System.Drawing.Color.White;
            this.labelMessagesText.Location = new System.Drawing.Point(6, 9);
            this.labelMessagesText.Name = "labelMessagesText";
            this.labelMessagesText.Size = new System.Drawing.Size(133, 25);
            this.labelMessagesText.TabIndex = 2;
            this.labelMessagesText.Text = "Обьявления";
            // 
            // panelSchedule
            // 
            this.panelSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelSchedule.Controls.Add(this.label1);
            this.panelSchedule.Controls.Add(this.buttonAddAppointment);
            this.panelSchedule.Controls.Add(this.buttonPatientData);
            this.panelSchedule.Controls.Add(this.label6);
            this.panelSchedule.Controls.Add(this.listBoxAppointments);
            this.panelSchedule.Enabled = false;
            this.panelSchedule.Location = new System.Drawing.Point(240, 349);
            this.panelSchedule.Name = "panelSchedule";
            this.panelSchedule.Size = new System.Drawing.Size(734, 291);
            this.panelSchedule.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Расписание";
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panelSchedule);
            this.Controls.Add(this.panelMessages);
            this.Controls.Add(this.panelTemplates);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelSelectedControlText);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(977, 645);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).EndInit();
            this.panelSelectedControlText.ResumeLayout(false);
            this.panelSelectedControlText.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelTemplates.ResumeLayout(false);
            this.panelTemplates.PerformLayout();
            this.panelMessages.ResumeLayout(false);
            this.panelMessages.PerformLayout();
            this.panelSchedule.ResumeLayout(false);
            this.panelSchedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxAppointments;
        private System.Windows.Forms.Button buttonPatientData;
        private System.Windows.Forms.DataGridView dataGridViewMessages;
        private System.Windows.Forms.Button buttonAddMessage;
        private System.Windows.Forms.Timer timerAppointment;
        private System.Windows.Forms.Panel panelSelectedControlText;
        private System.Windows.Forms.Label labelCurrentControl;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelLoginText;
        private System.Windows.Forms.Panel panelTemplates;
        private System.Windows.Forms.Label labelTemplatesText;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.Label labelMessagesText;
        private System.Windows.Forms.Panel panelSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonServiceFees;
        private System.Windows.Forms.Button buttonPersonalDataProcessing;
        private System.Windows.Forms.Button buttonMedicinalIntervation;
    }
}
