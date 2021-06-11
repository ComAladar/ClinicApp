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
        public List<Schedule> ScheduleList { get; set; } = new List<Schedule>();
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
            ScheduleList.Clear();
            Db.Schedules.Load();
            Db.Staffs.Load();
            Db.Patients.Load();

            var schedules = Db.Schedules.Where(a => a.StaffId == CurrentUser.Id).Where(a=>DbFunctions.TruncateTime(a.DateOfSchedule)==DbFunctions.TruncateTime(DateTime.Today)).Where(a=>a.IsComplete==0);
            foreach (var item in schedules)
            {
                ScheduleList.Add(item);
            }

            listBoxAppointments.Items.Clear();
            foreach (var item in ScheduleList)
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
            AppointmentsActivation();
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
            Db.Schedules.Load();
            var appointmentTime = ScheduleList[listBoxAppointments.SelectedIndex].DateOfSchedule;
            var appointmentPatientId = ScheduleList[listBoxAppointments.SelectedIndex].PatientId;
            AddViewAppointmentForm appointmentForm = new AddViewAppointmentForm();
            appointmentForm.appointmentSchedule = Db.Schedules.FirstOrDefault(a =>
                DbFunctions.TruncateTime(a.DateOfSchedule) == DbFunctions.TruncateTime(appointmentTime)
                && a.StaffId == CurrentUser.Id && a.PatientId == appointmentPatientId 
                && a.IsComplete==0 
                && a.Appointment.Id != a.Id 
                && a.DateOfSchedule == appointmentTime);
            appointmentForm.ShowDialog();
            if (appointmentForm.DialogResult == DialogResult.OK)
            {
                var tempAppointment = appointmentForm.Appointment;
                var tempSchedule=Db.Schedules.FirstOrDefault(a => a.Id == tempAppointment.Id);
                tempSchedule.IsComplete = (ComplitionType)1;
                GenericRepository<Schedule> scheduleRepo = new GenericRepository<Schedule>(Db);
                scheduleRepo.Modify(tempSchedule);
                GenericRepository<Appointment> appointmentRepo = new GenericRepository<Appointment>(Db);
                appointmentRepo.Add(tempAppointment);
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
            var tempSchedule= ScheduleList[listBoxAppointments.SelectedIndex];
            patientForm.Patient = Db.Patients.FirstOrDefault(p => p.Id == tempSchedule.PatientId);
            foreach (Control control in patientForm.Controls)
            {
                control.Enabled = false;
            }

            patientForm.Controls["buttonCancel"].Enabled = true;
            patientForm.Show();
        }
    }
}
