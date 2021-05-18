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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxPatients = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxPersonalInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxAppointments = new System.Windows.Forms.GroupBox();
            this.groupBoxContacts = new System.Windows.Forms.GroupBox();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(3, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(140, 30);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // listBoxPatients
            // 
            this.listBoxPatients.FormattingEnabled = true;
            this.listBoxPatients.Location = new System.Drawing.Point(3, 39);
            this.listBoxPatients.Name = "listBoxPatients";
            this.listBoxPatients.Size = new System.Drawing.Size(140, 342);
            this.listBoxPatients.TabIndex = 1;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(51, 383);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(42, 30);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Редакт";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(100, 383);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(43, 30);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // groupBoxPersonalInfo
            // 
            this.groupBoxPersonalInfo.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxPersonalInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxPersonalInfo.Location = new System.Drawing.Point(149, 3);
            this.groupBoxPersonalInfo.Name = "groupBoxPersonalInfo";
            this.groupBoxPersonalInfo.Size = new System.Drawing.Size(325, 202);
            this.groupBoxPersonalInfo.TabIndex = 4;
            this.groupBoxPersonalInfo.TabStop = false;
            this.groupBoxPersonalInfo.Text = "Персональные Данные";
            // 
            // groupBoxAppointments
            // 
            this.groupBoxAppointments.Location = new System.Drawing.Point(480, 3);
            this.groupBoxAppointments.Name = "groupBoxAppointments";
            this.groupBoxAppointments.Size = new System.Drawing.Size(325, 202);
            this.groupBoxAppointments.TabIndex = 5;
            this.groupBoxAppointments.TabStop = false;
            this.groupBoxAppointments.Text = "Приемы";
            // 
            // groupBoxContacts
            // 
            this.groupBoxContacts.Location = new System.Drawing.Point(149, 211);
            this.groupBoxContacts.Name = "groupBoxContacts";
            this.groupBoxContacts.Size = new System.Drawing.Size(325, 202);
            this.groupBoxContacts.TabIndex = 6;
            this.groupBoxContacts.TabStop = false;
            this.groupBoxContacts.Text = "Контакты и адрес";
            // 
            // groupBoxMisc
            // 
            this.groupBoxMisc.Location = new System.Drawing.Point(482, 211);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.Size = new System.Drawing.Size(325, 202);
            this.groupBoxMisc.TabIndex = 0;
            this.groupBoxMisc.TabStop = false;
            this.groupBoxMisc.Text = "Дополнительная информация";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 383);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(42, 30);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добав";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // PatientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxMisc);
            this.Controls.Add(this.groupBoxContacts);
            this.Controls.Add(this.groupBoxAppointments);
            this.Controls.Add(this.groupBoxPersonalInfo);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listBoxPatients);
            this.Controls.Add(this.buttonSearch);
            this.Name = "PatientControl";
            this.Size = new System.Drawing.Size(810, 416);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxPatients;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxPersonalInfo;
        private System.Windows.Forms.GroupBox groupBoxAppointments;
        private System.Windows.Forms.GroupBox groupBoxContacts;
        private System.Windows.Forms.GroupBox groupBoxMisc;
        private System.Windows.Forms.Button buttonAdd;
    }
}
