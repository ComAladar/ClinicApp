using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppDataBase;
using ClinicAppDataBase.Entities;
using ClinicAppDataBase.Repositories;
using ClinicAppUI.Forms;

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

        private void MessageBoardActivation()
        {
            Db.MessageBoards.Load();
            dataGridViewMessages.DataSource = Db.MessageBoards.Local.ToBindingList();
            dataGridViewMessages.Columns.Remove("Staff");
            dataGridViewMessages.Columns.Remove("StaffId");
            dataGridViewMessages.Columns.Remove("Id");
            dataGridViewMessages.Columns[1].Width = 500;
            dataGridViewMessages.Columns[0].HeaderText = "Тема";
            dataGridViewMessages.Columns[1].HeaderText = "Сообщение";
            dataGridViewMessages.Columns[2].HeaderText = "Дата";
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
            MessageBoardActivation();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonAddMessage_Click(object sender, EventArgs e)
        {
            AddMessageForm messageForm = new AddMessageForm();
            messageForm.ShowDialog();
            if (messageForm.DialogResult == DialogResult.OK)
            {
                try
                {
                    MessageBoard messageBoard = new MessageBoard();
                    messageBoard.Name = messageForm.MessageName;
                    messageBoard.Message = messageForm.MessageText;
                    messageBoard.DateOfMessage = DateTime.Now;
                    messageBoard.Staff = CurrentUser;
                    Db.MessageBoards.Add(messageBoard);
                    Db.SaveChanges();
                }
                catch(Exception exception)
                {
                    MessageBox.Show("Ошибка при создании сообщения! Заполните поля правильно.");
                }

            }
        }

    }
}
