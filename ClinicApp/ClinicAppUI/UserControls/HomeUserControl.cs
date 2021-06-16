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
using ClinicAppBusinessLogic.Enumerations;
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
        public List<Appointment> AppointmentsList { get; set; } = new List<Appointment>();
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

            AppointmentsActivation();
        }

        private void MessageBoardActivation()
        {
            Db.MessageBoards.Load();
            dataGridViewMessages.DataSource = Db.MessageBoards.Local.ToBindingList();
            dataGridViewMessages.Columns.Remove("Staff");
            dataGridViewMessages.Columns.Remove("StaffId");
            dataGridViewMessages.Columns.Remove("Id");
            dataGridViewMessages.Columns[1].Width = 200;
            dataGridViewMessages.Columns[0].HeaderText = "Тема";
            dataGridViewMessages.Columns[1].HeaderText = "Сообщение";
            dataGridViewMessages.Columns[2].HeaderText = "Дата";
        }

        private void AppointmentsActivation()
        {
            AppointmentsList.Clear();
            Db.Appointments.Load();
            Db.Staffs.Load();
            Db.Patients.Load();

            var appointments = Db.Appointments.Where(a => a.StaffId == CurrentUser.Id).Where(a=>DbFunctions.TruncateTime(a.DateOfSchedule)==DbFunctions.TruncateTime(DateTime.Today)).Where(a=>a.IsComplete==0);
            foreach (var item in appointments)
            {
                AppointmentsList.Add(item);
            }

            listBoxAppointments.Items.Clear();
            foreach (var item in AppointmentsList)
            {
                listBoxAppointments.Items.Add(item.Patient.Surname + " " +item.Patient.Name + " => " + item.DateOfSchedule.TimeOfDay.Hours + ":" + item.DateOfSchedule.TimeOfDay.Minutes);
            }
        }

        public HomeUserControl()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;

            timerAppointment.Interval = (10 * 1000);//10sec
            timerAppointment.Tick += new EventHandler(timerAppointment_Tick);
            timerAppointment.Start();

        }

        private void timerAppointment_Tick(object sender, EventArgs e)
        {
            if (CurrentUser != null)
            {
                AppointmentsActivation();
                Db.MessageBoards.Load();
                dataGridViewMessages.DataSource = Db.MessageBoards.Local.ToBindingList();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Db.Staffs.Load();
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

        private void listBoxAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAppointments.SelectedIndex == -1)
            {
                return;
            }

        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            if (listBoxAppointments.SelectedIndex == -1)
            {
                return;
            }
            Db.Staffs.Load();
            Db.Patients.Load();
            Db.Appointments.Load();
            var appointmentTime = AppointmentsList[listBoxAppointments.SelectedIndex].DateOfSchedule;
            var appointmentPatientId = AppointmentsList[listBoxAppointments.SelectedIndex].PatientId;
            AddViewAppointmentForm appointmentForm = new AddViewAppointmentForm();
            appointmentForm.Appointment = Db.Appointments.FirstOrDefault(a =>
                DbFunctions.TruncateTime(a.DateOfSchedule) == DbFunctions.TruncateTime(appointmentTime)
                && a.StaffId == CurrentUser.Id && a.PatientId == appointmentPatientId 
                && a.IsComplete==0 
                //&& a.Appointment.Id != a.Id 
                && a.DateOfSchedule == appointmentTime);
            if (appointmentForm.Appointment.Receipt == null || appointmentForm.Appointment.Receipt.Status == 0)
            {
                MessageBox.Show("Невозможно начать приема пока чек не был создан и оплачен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            appointmentForm.ShowDialog();
            if (appointmentForm.DialogResult == DialogResult.OK)
            {
                var tempAppointment = appointmentForm.Appointment;
                //var tempSchedule=Db.Appointments.FirstOrDefault(a => a.Id == tempAppointment.Id);
                tempAppointment.IsComplete = (ComplitionType)1;
                GenericRepository<Appointment> appointmentRepo = new GenericRepository<Appointment>(Db);
                appointmentRepo.Modify(tempAppointment);
                AppointmentsActivation();
            }
        }

        private void buttonPatientData_Click(object sender, EventArgs e)
        {
            if (listBoxAppointments.SelectedIndex == -1)
            {
                return;
            }
            AddEditPatientForm patientForm = new AddEditPatientForm();
            Db.Patients.Load();
            var tempAppointment= AppointmentsList[listBoxAppointments.SelectedIndex];
            patientForm.Patient = Db.Patients.FirstOrDefault(p => p.Id == tempAppointment.PatientId);
            foreach (Control control in patientForm.Controls)
            {
                control.Enabled = false;
            }

            patientForm.Controls["buttonCancel"].Enabled = true;
            patientForm.Show();
        }
    }
}
