namespace ClinicAppUI.UserControls
{
    partial class CashboxUserControl
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
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxPatients = new System.Windows.Forms.ListBox();
            this.groupBoxReceipt = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddReceipt = new System.Windows.Forms.Button();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.labelPaid = new System.Windows.Forms.Label();
            this.labelNotPaid = new System.Windows.Forms.Label();
            this.labelPaidAmount = new System.Windows.Forms.Label();
            this.labelPaidTimes = new System.Windows.Forms.Label();
            this.labelNotPaidAmount = new System.Windows.Forms.Label();
            this.labelNotPaidTimes = new System.Windows.Forms.Label();
            this.buttonDeleteReceipt = new System.Windows.Forms.Button();
            this.groupBoxPatient.SuspendLayout();
            this.groupBoxReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.labelEmail);
            this.groupBoxPatient.Controls.Add(this.labelSex);
            this.groupBoxPatient.Controls.Add(this.labelPhoneNumber);
            this.groupBoxPatient.Controls.Add(this.label2);
            this.groupBoxPatient.Controls.Add(this.label21);
            this.groupBoxPatient.Controls.Add(this.label1);
            this.groupBoxPatient.Controls.Add(this.textBoxSearch);
            this.groupBoxPatient.Controls.Add(this.listBoxPatients);
            this.groupBoxPatient.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(185, 410);
            this.groupBoxPatient.TabIndex = 0;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Пациент";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(6, 371);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Эл. Почта";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(6, 288);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(27, 13);
            this.labelSex.TabIndex = 1;
            this.labelSex.Text = "Пол";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(6, 322);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(95, 13);
            this.labelPhoneNumber.TabIndex = 1;
            this.labelPhoneNumber.Text = "Номер Телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата рождения";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "Поиск";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(46, 13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(133, 20);
            this.textBoxSearch.TabIndex = 22;
            // 
            // listBoxPatients
            // 
            this.listBoxPatients.FormattingEnabled = true;
            this.listBoxPatients.Location = new System.Drawing.Point(6, 39);
            this.listBoxPatients.Name = "listBoxPatients";
            this.listBoxPatients.Size = new System.Drawing.Size(173, 160);
            this.listBoxPatients.TabIndex = 2;
            // 
            // groupBoxReceipt
            // 
            this.groupBoxReceipt.Controls.Add(this.buttonDeleteReceipt);
            this.groupBoxReceipt.Controls.Add(this.buttonAddReceipt);
            this.groupBoxReceipt.Controls.Add(this.dataGridView1);
            this.groupBoxReceipt.Location = new System.Drawing.Point(194, 3);
            this.groupBoxReceipt.Name = "groupBoxReceipt";
            this.groupBoxReceipt.Size = new System.Drawing.Size(613, 269);
            this.groupBoxReceipt.TabIndex = 1;
            this.groupBoxReceipt.TabStop = false;
            this.groupBoxReceipt.Text = "Счета";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAddReceipt
            // 
            this.buttonAddReceipt.Location = new System.Drawing.Point(341, 230);
            this.buttonAddReceipt.Name = "buttonAddReceipt";
            this.buttonAddReceipt.Size = new System.Drawing.Size(130, 31);
            this.buttonAddReceipt.TabIndex = 1;
            this.buttonAddReceipt.Text = "Добавить счет";
            this.buttonAddReceipt.UseVisualStyleBackColor = true;
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.labelNotPaidTimes);
            this.groupBoxStatus.Controls.Add(this.labelNotPaidAmount);
            this.groupBoxStatus.Controls.Add(this.labelPaidTimes);
            this.groupBoxStatus.Controls.Add(this.labelPaidAmount);
            this.groupBoxStatus.Controls.Add(this.labelNotPaid);
            this.groupBoxStatus.Controls.Add(this.labelPaid);
            this.groupBoxStatus.Location = new System.Drawing.Point(194, 278);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(613, 135);
            this.groupBoxStatus.TabIndex = 2;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Статистика";
            // 
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.Location = new System.Drawing.Point(50, 16);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(87, 13);
            this.labelPaid.TabIndex = 0;
            this.labelPaid.Text = "Всего оплачено";
            // 
            // labelNotPaid
            // 
            this.labelNotPaid.AutoSize = true;
            this.labelNotPaid.Location = new System.Drawing.Point(301, 13);
            this.labelNotPaid.Name = "labelNotPaid";
            this.labelNotPaid.Size = new System.Drawing.Size(102, 13);
            this.labelNotPaid.TabIndex = 1;
            this.labelNotPaid.Text = "Ожидается оплата";
            // 
            // labelPaidAmount
            // 
            this.labelPaidAmount.AutoSize = true;
            this.labelPaidAmount.Location = new System.Drawing.Point(6, 36);
            this.labelPaidAmount.Name = "labelPaidAmount";
            this.labelPaidAmount.Size = new System.Drawing.Size(119, 13);
            this.labelPaidAmount.TabIndex = 2;
            this.labelPaidAmount.Text = "Сумма всех платежей";
            // 
            // labelPaidTimes
            // 
            this.labelPaidTimes.AutoSize = true;
            this.labelPaidTimes.Location = new System.Drawing.Point(6, 61);
            this.labelPaidTimes.Name = "labelPaidTimes";
            this.labelPaidTimes.Size = new System.Drawing.Size(89, 13);
            this.labelPaidTimes.TabIndex = 3;
            this.labelPaidTimes.Text = "Всего платежей";
            // 
            // labelNotPaidAmount
            // 
            this.labelNotPaidAmount.AutoSize = true;
            this.labelNotPaidAmount.Location = new System.Drawing.Point(278, 36);
            this.labelNotPaidAmount.Name = "labelNotPaidAmount";
            this.labelNotPaidAmount.Size = new System.Drawing.Size(155, 13);
            this.labelNotPaidAmount.TabIndex = 4;
            this.labelNotPaidAmount.Text = "Сумма ожидаемых платежей";
            // 
            // labelNotPaidTimes
            // 
            this.labelNotPaidTimes.AutoSize = true;
            this.labelNotPaidTimes.Location = new System.Drawing.Point(278, 61);
            this.labelNotPaidTimes.Name = "labelNotPaidTimes";
            this.labelNotPaidTimes.Size = new System.Drawing.Size(151, 13);
            this.labelNotPaidTimes.TabIndex = 5;
            this.labelNotPaidTimes.Text = "Всего ожидаемых платажей";
            // 
            // buttonDeleteReceipt
            // 
            this.buttonDeleteReceipt.Location = new System.Drawing.Point(477, 230);
            this.buttonDeleteReceipt.Name = "buttonDeleteReceipt";
            this.buttonDeleteReceipt.Size = new System.Drawing.Size(130, 31);
            this.buttonDeleteReceipt.TabIndex = 2;
            this.buttonDeleteReceipt.Text = "Удалить счет";
            this.buttonDeleteReceipt.UseVisualStyleBackColor = true;
            // 
            // CashboxUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBoxReceipt);
            this.Controls.Add(this.groupBoxPatient);
            this.Name = "CashboxUserControl";
            this.Size = new System.Drawing.Size(810, 416);
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.groupBoxReceipt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.ListBox listBoxPatients;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxReceipt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Button buttonAddReceipt;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label labelNotPaidTimes;
        private System.Windows.Forms.Label labelNotPaidAmount;
        private System.Windows.Forms.Label labelPaidTimes;
        private System.Windows.Forms.Label labelPaidAmount;
        private System.Windows.Forms.Label labelNotPaid;
        private System.Windows.Forms.Label labelPaid;
        private System.Windows.Forms.Button buttonDeleteReceipt;
    }
}
