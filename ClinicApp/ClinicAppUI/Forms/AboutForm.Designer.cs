namespace ClinicAppUI.Forms
{
    partial class AboutForm
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
            this.labelDeveloperName = new System.Windows.Forms.Label();
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelAppVersion = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGitHub = new System.Windows.Forms.Label();
            this.labelIcons = new System.Windows.Forms.Label();
            this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.linkLabelIcons = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelDeveloperName
            // 
            this.labelDeveloperName.AutoSize = true;
            this.labelDeveloperName.Location = new System.Drawing.Point(15, 95);
            this.labelDeveloperName.Name = "labelDeveloperName";
            this.labelDeveloperName.Size = new System.Drawing.Size(156, 13);
            this.labelDeveloperName.TabIndex = 3;
            this.labelDeveloperName.Text = "Разработчик: Никита Громов";
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelAppName.Location = new System.Drawing.Point(12, 9);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(138, 31);
            this.labelAppName.TabIndex = 4;
            this.labelAppName.Text = "ClinicApp";
            // 
            // labelAppVersion
            // 
            this.labelAppVersion.AutoSize = true;
            this.labelAppVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAppVersion.Location = new System.Drawing.Point(20, 40);
            this.labelAppVersion.Name = "labelAppVersion";
            this.labelAppVersion.Size = new System.Drawing.Size(51, 18);
            this.labelAppVersion.TabIndex = 5;
            this.labelAppVersion.Text = "v 1.0.0";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(12, 239);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(124, 13);
            this.labelAuthor.TabIndex = 8;
            this.labelAuthor.Text = "2021 Никита Громов ©";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(15, 141);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(161, 13);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Электронная почта для связи:";
            // 
            // labelGitHub
            // 
            this.labelGitHub.AutoSize = true;
            this.labelGitHub.Location = new System.Drawing.Point(15, 164);
            this.labelGitHub.Name = "labelGitHub";
            this.labelGitHub.Size = new System.Drawing.Size(43, 13);
            this.labelGitHub.TabIndex = 10;
            this.labelGitHub.Text = "GitHub:";
            // 
            // labelIcons
            // 
            this.labelIcons.AutoSize = true;
            this.labelIcons.Location = new System.Drawing.Point(15, 186);
            this.labelIcons.Name = "labelIcons";
            this.labelIcons.Size = new System.Drawing.Size(123, 13);
            this.labelIcons.TabIndex = 11;
            this.labelIcons.Text = "Иконки взяты с сайта:";
            // 
            // linkLabelEmail
            // 
            this.linkLabelEmail.AutoSize = true;
            this.linkLabelEmail.Location = new System.Drawing.Point(173, 141);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(126, 13);
            this.linkLabelEmail.TabIndex = 12;
            this.linkLabelEmail.TabStop = true;
            this.linkLabelEmail.Text = "gromovnik99@gmail.com";
            this.linkLabelEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEmail_LinkClicked);
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(55, 164);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(151, 13);
            this.linkLabelGitHub.TabIndex = 13;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "https://github.com/ComAladar";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // linkLabelIcons
            // 
            this.linkLabelIcons.AutoSize = true;
            this.linkLabelIcons.Location = new System.Drawing.Point(135, 186);
            this.linkLabelIcons.Name = "linkLabelIcons";
            this.linkLabelIcons.Size = new System.Drawing.Size(50, 13);
            this.linkLabelIcons.TabIndex = 14;
            this.linkLabelIcons.TabStop = true;
            this.linkLabelIcons.Text = "icons8.ru";
            this.linkLabelIcons.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelIcons_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.linkLabelIcons);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.linkLabelEmail);
            this.Controls.Add(this.labelIcons);
            this.Controls.Add(this.labelGitHub);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelAppVersion);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.labelDeveloperName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О Приложении";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeveloperName;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Label labelAppVersion;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGitHub;
        private System.Windows.Forms.Label labelIcons;
        private System.Windows.Forms.LinkLabel linkLabelEmail;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.LinkLabel linkLabelIcons;
    }
}