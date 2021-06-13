namespace ClinicAppUI.Forms
{
    partial class AddReceiptForm
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
            this.labelAppointment = new System.Windows.Forms.Label();
            this.labelStaff = new System.Windows.Forms.Label();
            this.groupBoxAppointment = new System.Windows.Forms.GroupBox();
            this.groupBoxReceipt = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelAppointmentType = new System.Windows.Forms.Label();
            this.checkBoxAdditionalCosts = new System.Windows.Forms.CheckBox();
            this.textBoxAdditionalCost = new System.Windows.Forms.TextBox();
            this.labelAdditionalName = new System.Windows.Forms.Label();
            this.labelReceiptCost = new System.Windows.Forms.Label();
            this.textBoxMainCost = new System.Windows.Forms.TextBox();
            this.labelFinalCost = new System.Windows.Forms.Label();
            this.textBoxFinalCost = new System.Windows.Forms.TextBox();
            this.groupBoxAppointment.SuspendLayout();
            this.groupBoxReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAppointment
            // 
            this.labelAppointment.AutoSize = true;
            this.labelAppointment.Location = new System.Drawing.Point(6, 16);
            this.labelAppointment.Name = "labelAppointment";
            this.labelAppointment.Size = new System.Drawing.Size(81, 13);
            this.labelAppointment.TabIndex = 0;
            this.labelAppointment.Text = "Выбор приема";
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.Location = new System.Drawing.Point(6, 77);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(67, 13);
            this.labelStaff.TabIndex = 1;
            this.labelStaff.Text = "ФИО Врача";
            // 
            // groupBoxAppointment
            // 
            this.groupBoxAppointment.Controls.Add(this.labelAppointmentType);
            this.groupBoxAppointment.Controls.Add(this.labelAppointment);
            this.groupBoxAppointment.Controls.Add(this.labelStaff);
            this.groupBoxAppointment.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAppointment.Name = "groupBoxAppointment";
            this.groupBoxAppointment.Size = new System.Drawing.Size(338, 258);
            this.groupBoxAppointment.TabIndex = 2;
            this.groupBoxAppointment.TabStop = false;
            this.groupBoxAppointment.Text = "Прием";
            // 
            // groupBoxReceipt
            // 
            this.groupBoxReceipt.Controls.Add(this.textBoxFinalCost);
            this.groupBoxReceipt.Controls.Add(this.labelFinalCost);
            this.groupBoxReceipt.Controls.Add(this.textBoxMainCost);
            this.groupBoxReceipt.Controls.Add(this.labelReceiptCost);
            this.groupBoxReceipt.Controls.Add(this.labelAdditionalName);
            this.groupBoxReceipt.Controls.Add(this.textBoxAdditionalCost);
            this.groupBoxReceipt.Controls.Add(this.checkBoxAdditionalCosts);
            this.groupBoxReceipt.Location = new System.Drawing.Point(356, 12);
            this.groupBoxReceipt.Name = "groupBoxReceipt";
            this.groupBoxReceipt.Size = new System.Drawing.Size(304, 258);
            this.groupBoxReceipt.TabIndex = 3;
            this.groupBoxReceipt.TabStop = false;
            this.groupBoxReceipt.Text = "Чек";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(490, 276);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Добавить";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(571, 276);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelAppointmentType
            // 
            this.labelAppointmentType.AutoSize = true;
            this.labelAppointmentType.Location = new System.Drawing.Point(6, 147);
            this.labelAppointmentType.Name = "labelAppointmentType";
            this.labelAppointmentType.Size = new System.Drawing.Size(69, 13);
            this.labelAppointmentType.TabIndex = 2;
            this.labelAppointmentType.Text = "Тип Приема";
            // 
            // checkBoxAdditionalCosts
            // 
            this.checkBoxAdditionalCosts.AutoSize = true;
            this.checkBoxAdditionalCosts.Location = new System.Drawing.Point(6, 58);
            this.checkBoxAdditionalCosts.Name = "checkBoxAdditionalCosts";
            this.checkBoxAdditionalCosts.Size = new System.Drawing.Size(150, 17);
            this.checkBoxAdditionalCosts.TabIndex = 0;
            this.checkBoxAdditionalCosts.Text = "Дополнительные услуги";
            this.checkBoxAdditionalCosts.UseVisualStyleBackColor = true;
            // 
            // textBoxAdditionalCost
            // 
            this.textBoxAdditionalCost.Location = new System.Drawing.Point(0, 96);
            this.textBoxAdditionalCost.Name = "textBoxAdditionalCost";
            this.textBoxAdditionalCost.Size = new System.Drawing.Size(203, 20);
            this.textBoxAdditionalCost.TabIndex = 1;
            // 
            // labelAdditionalName
            // 
            this.labelAdditionalName.AutoSize = true;
            this.labelAdditionalName.Location = new System.Drawing.Point(6, 80);
            this.labelAdditionalName.Name = "labelAdditionalName";
            this.labelAdditionalName.Size = new System.Drawing.Size(98, 13);
            this.labelAdditionalName.TabIndex = 2;
            this.labelAdditionalName.Text = "Стоимость услуги";
            // 
            // labelReceiptCost
            // 
            this.labelReceiptCost.AutoSize = true;
            this.labelReceiptCost.Location = new System.Drawing.Point(6, 16);
            this.labelReceiptCost.Name = "labelReceiptCost";
            this.labelReceiptCost.Size = new System.Drawing.Size(155, 13);
            this.labelReceiptCost.TabIndex = 3;
            this.labelReceiptCost.Text = "Основная стоимость приема";
            // 
            // textBoxMainCost
            // 
            this.textBoxMainCost.Location = new System.Drawing.Point(9, 32);
            this.textBoxMainCost.Name = "textBoxMainCost";
            this.textBoxMainCost.Size = new System.Drawing.Size(158, 20);
            this.textBoxMainCost.TabIndex = 4;
            // 
            // labelFinalCost
            // 
            this.labelFinalCost.AutoSize = true;
            this.labelFinalCost.Location = new System.Drawing.Point(174, 210);
            this.labelFinalCost.Name = "labelFinalCost";
            this.labelFinalCost.Size = new System.Drawing.Size(112, 13);
            this.labelFinalCost.TabIndex = 5;
            this.labelFinalCost.Text = "Итоговая стоимость";
            // 
            // textBoxFinalCost
            // 
            this.textBoxFinalCost.Location = new System.Drawing.Point(177, 226);
            this.textBoxFinalCost.Name = "textBoxFinalCost";
            this.textBoxFinalCost.Size = new System.Drawing.Size(121, 20);
            this.textBoxFinalCost.TabIndex = 6;
            // 
            // AddReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 305);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxReceipt);
            this.Controls.Add(this.groupBoxAppointment);
            this.Name = "AddReceiptForm";
            this.Text = "AddReceiptForm";
            this.groupBoxAppointment.ResumeLayout(false);
            this.groupBoxAppointment.PerformLayout();
            this.groupBoxReceipt.ResumeLayout(false);
            this.groupBoxReceipt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAppointment;
        private System.Windows.Forms.Label labelStaff;
        private System.Windows.Forms.GroupBox groupBoxAppointment;
        private System.Windows.Forms.GroupBox groupBoxReceipt;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelAppointmentType;
        private System.Windows.Forms.Label labelAdditionalName;
        private System.Windows.Forms.TextBox textBoxAdditionalCost;
        private System.Windows.Forms.CheckBox checkBoxAdditionalCosts;
        private System.Windows.Forms.Label labelFinalCost;
        private System.Windows.Forms.TextBox textBoxMainCost;
        private System.Windows.Forms.Label labelReceiptCost;
        private System.Windows.Forms.TextBox textBoxFinalCost;
    }
}