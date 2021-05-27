using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppDataBase;
using ClinicAppDataBase.Entities;
using ClinicAppDataBase.Repositories;

namespace ClinicAppUI.UserControls
{
    public partial class HomeUserControl : UserControl
    {
        public Staff CurrentUser { get; set; }
        public ClinicContext Db { get; set; }
        public event EventHandler ButtonLoginClick;

        private void LoginSuccess()
        {
            checkBoxShowPassword.Checked = false;
            groupBoxLogin.Visible = false;
            groupBoxMessages.Enabled = true;
            groupBoxSchedule.Enabled = true;
            groupBoxTemplates.Enabled = true;
            groupBoxUserInfo.Enabled = true;

            textBoxFullName.Text = CurrentUser.Surname + " " + CurrentUser.Name + " " + CurrentUser.Patronymic;
            textBoxPosition.Text = CurrentUser.Position;
            textBoxQualification.Text = CurrentUser.Qualification;
            textBoxSpecialty.Text = CurrentUser.Speciality;
            textBoxRegistrationDate.Text = CurrentUser.DateOfRegistration.ToString();
        }

        public HomeUserControl()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            CurrentUser = Db.Staffs.FirstOrDefault(s=>s.Login==textBoxLogin.Text 
                                                    && s.Password==textBoxPassword.Text);
            if (CurrentUser == null)
            {
                MessageBox.Show("Такого несуществует!");
                return;
            }

            LoginSuccess();
            if (ButtonLoginClick != null) ButtonLoginClick.Invoke(this, e);
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else textBoxPassword.UseSystemPasswordChar = true;
        }

        //public HomeUserControl(ClinicContext mainDb)
        //{
        //    Db = mainDb;
        //}
    }
}
