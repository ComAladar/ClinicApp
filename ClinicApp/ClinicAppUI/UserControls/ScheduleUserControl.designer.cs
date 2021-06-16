namespace ClinicAppUI.UserControls
{
    partial class ScheduleUserControl
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.labelCalendarText = new System.Windows.Forms.Label();
            this.panelSchedule = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSelectedControlText = new System.Windows.Forms.Panel();
            this.labelCurrentControl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.panelCalendar.SuspendLayout();
            this.panelSchedule.SuspendLayout();
            this.panelSelectedControlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 43);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(688, 538);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 30);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(602, 538);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AllowUserToAddRows = false;
            this.dataGridViewSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(11, 37);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.ReadOnly = true;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(757, 495);
            this.dataGridViewSchedule.TabIndex = 0;
            // 
            // panelCalendar
            // 
            this.panelCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelCalendar.Controls.Add(this.monthCalendar1);
            this.panelCalendar.Controls.Add(this.labelCalendarText);
            this.panelCalendar.Location = new System.Drawing.Point(3, 71);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(185, 571);
            this.panelCalendar.TabIndex = 8;
            // 
            // labelCalendarText
            // 
            this.labelCalendarText.AutoSize = true;
            this.labelCalendarText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalendarText.ForeColor = System.Drawing.Color.White;
            this.labelCalendarText.Location = new System.Drawing.Point(6, 9);
            this.labelCalendarText.Name = "labelCalendarText";
            this.labelCalendarText.Size = new System.Drawing.Size(119, 25);
            this.labelCalendarText.TabIndex = 2;
            this.labelCalendarText.Text = "Календарь";
            // 
            // panelSchedule
            // 
            this.panelSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelSchedule.Controls.Add(this.buttonDelete);
            this.panelSchedule.Controls.Add(this.label1);
            this.panelSchedule.Controls.Add(this.buttonAdd);
            this.panelSchedule.Controls.Add(this.dataGridViewSchedule);
            this.panelSchedule.Location = new System.Drawing.Point(194, 71);
            this.panelSchedule.Name = "panelSchedule";
            this.panelSchedule.Size = new System.Drawing.Size(780, 571);
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
            this.labelCurrentControl.Size = new System.Drawing.Size(129, 25);
            this.labelCurrentControl.TabIndex = 5;
            this.labelCurrentControl.Text = "Расписание";
            // 
            // ScheduleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panelSelectedControlText);
            this.Controls.Add(this.panelSchedule);
            this.Controls.Add(this.panelCalendar);
            this.Name = "ScheduleUserControl";
            this.Size = new System.Drawing.Size(977, 645);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.panelCalendar.ResumeLayout(false);
            this.panelCalendar.PerformLayout();
            this.panelSchedule.ResumeLayout(false);
            this.panelSchedule.PerformLayout();
            this.panelSelectedControlText.ResumeLayout(false);
            this.panelSelectedControlText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.Label labelCalendarText;
        private System.Windows.Forms.Panel panelSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSelectedControlText;
        private System.Windows.Forms.Label labelCurrentControl;
    }
}
