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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxStaff = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxPersonalInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxAppointments = new System.Windows.Forms.GroupBox();
            this.groupBoxContacts = new System.Windows.Forms.GroupBox();
            this.groupBoxRank = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(3, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(140, 30);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // listBoxStaff
            // 
            this.listBoxStaff.FormattingEnabled = true;
            this.listBoxStaff.Location = new System.Drawing.Point(3, 39);
            this.listBoxStaff.Name = "listBoxStaff";
            this.listBoxStaff.Size = new System.Drawing.Size(140, 342);
            this.listBoxStaff.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(4, 383);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(42, 30);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добав";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(52, 383);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(42, 30);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Редакт";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(100, 383);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(43, 30);
            this.buttonDelete.TabIndex = 5;
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
            this.groupBoxPersonalInfo.TabIndex = 6;
            this.groupBoxPersonalInfo.TabStop = false;
            this.groupBoxPersonalInfo.Text = "Персональные Данные";
            // 
            // groupBoxAppointments
            // 
            this.groupBoxAppointments.Location = new System.Drawing.Point(480, 3);
            this.groupBoxAppointments.Name = "groupBoxAppointments";
            this.groupBoxAppointments.Size = new System.Drawing.Size(325, 202);
            this.groupBoxAppointments.TabIndex = 7;
            this.groupBoxAppointments.TabStop = false;
            this.groupBoxAppointments.Text = "Приемы";
            // 
            // groupBoxContacts
            // 
            this.groupBoxContacts.Location = new System.Drawing.Point(149, 211);
            this.groupBoxContacts.Name = "groupBoxContacts";
            this.groupBoxContacts.Size = new System.Drawing.Size(325, 202);
            this.groupBoxContacts.TabIndex = 8;
            this.groupBoxContacts.TabStop = false;
            this.groupBoxContacts.Text = "Контакты и адрес";
            // 
            // groupBoxRank
            // 
            this.groupBoxRank.Location = new System.Drawing.Point(480, 211);
            this.groupBoxRank.Name = "groupBoxRank";
            this.groupBoxRank.Size = new System.Drawing.Size(325, 202);
            this.groupBoxRank.TabIndex = 9;
            this.groupBoxRank.TabStop = false;
            this.groupBoxRank.Text = "Специальность и должность";
            // 
            // StaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxRank);
            this.Controls.Add(this.groupBoxContacts);
            this.Controls.Add(this.groupBoxAppointments);
            this.Controls.Add(this.groupBoxPersonalInfo);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxStaff);
            this.Controls.Add(this.buttonSearch);
            this.Name = "StaffUserControl";
            this.Size = new System.Drawing.Size(810, 416);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxStaff;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxPersonalInfo;
        private System.Windows.Forms.GroupBox groupBoxAppointments;
        private System.Windows.Forms.GroupBox groupBoxContacts;
        private System.Windows.Forms.GroupBox groupBoxRank;
    }
}
