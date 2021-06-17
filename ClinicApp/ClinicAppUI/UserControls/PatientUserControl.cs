using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClinicAppBusinessLogic.Enumerations;
using ClinicAppDataBase;
using ClinicAppDataBase.Entities;
using ClinicAppDataBase.Repositories;
using ClinicAppUI.Forms;

namespace ClinicAppUI.UserControls
{
    public partial class PatientUserControl : UserControl
    {
        //TODO:СДЕЛАТЬ ОГРАНИЧЕНИЯ ПО ACCESS ЮХЕРА
        //TODO:СДЕЛАТЬ ЧТО КОНТРОЛЫ КЛЮЧАЮТСЯ И ВЫКЛЮЧАЮТСЯ В ЗАВИСИМОСТИ ОТ ПРАВ ЮЗЕРА
        public Staff CurrentUser { get; set; }

        private ClinicContext _db;

        public ClinicContext Db
        {
            get
            {
                return _db;
            }
            set
            {
                _db = value;
                UpdatePatients();
            }
            
        }

        public List<Patient> PatientsList { get; set; } = new List<Patient>();
        public List<Appointment> AppointmentsList { get; set; } = new List<Appointment>();
        public EnumerationHandler EnumHandler = new EnumerationHandler();

        private void UpdatePatients()
        {
            GetPatients();
            PatientsListBoxFillUp();
        }

        private void UpdateAppointments()
        {
            GetAppointments();
            AppointmentsListBoxFillUp();
        }

        private void GetPatients()
        {
            PatientsList.Clear();
            GenericRepository<Patient> patientRepo = new GenericRepository<Patient>(Db);
            IEnumerable<Patient> patients = patientRepo.GetList();
            foreach (var item in patients)
            {
                PatientsList.Add(item);
            }
        }

        private void GetAppointments()
        {
            AppointmentsList.Clear();
            Db.Appointments.Load();
            Db.Staffs.Load();
            Db.Patients.Load();
            var tempItem = listBoxPatients.SelectedItem;
            var testString = tempItem.ToString();
            testString = Regex.Match(testString, @"\d+").Value;
            var patientId = testString;

            var appointments = Db.Appointments.Where(a => a.PatientId.ToString() == patientId).Where(a=>a.IsComplete==(ComplitionType)1);
            foreach (var item in appointments)
            {
                AppointmentsList.Add(item);
            }

        }

        private void PatientsListBoxFillUp()
        {
            listBoxPatients.Items.Clear();
            PatientsList.OrderBy(item => item.Surname).ToList();

            foreach (var item in PatientsList)
            {
                var fullName = item.Id + ") " + item.Surname + " " + item.Name;
                listBoxPatients.Items.Add(fullName);
            }
        }

        private void AppointmentsListBoxFillUp()
        {
            listBoxAppointments.Items.Clear();
            foreach (var item in AppointmentsList)
            {
                listBoxAppointments.Items.Add(
                    "Дата: " + item.DateOfSchedule.Date.ToLongDateString()
                    + ". Врач: " + item.Staff.Surname + " " + item.Staff.Name + ". Тип: " + EnumHandler.GetDescription(item.AppointmentType));
            }
        }

        public PatientUserControl()
        {
            InitializeComponent();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxPatients.Items.Clear();
            foreach(var item in PatientsList )
            {
                var fullName = item.Id + ") " + item.Surname + " " + item.Name;
                if (item.Surname.StartsWith(textBoxSearch.Text,
                    StringComparison.CurrentCultureIgnoreCase)) listBoxPatients.Items.Add(fullName);
            }
        }

        private void listBoxPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPatients.SelectedIndex == -1)
            {
                return;
            }
            var tempItem = listBoxPatients.SelectedItem;
            var testString = tempItem.ToString();
            testString = Regex.Match(testString, @"\d+").Value;
            var tempPatient = PatientsList.Find(x => x.Id.ToString() == testString);
            textBoxSurname.Text = tempPatient.Surname;
            textBoxName.Text = tempPatient.Name;
            textBoxPatronymic.Text = tempPatient.Patronymic;
            textBoxBirthDate.Text = tempPatient.DateOfBirth.ToShortDateString();
            textBoxSex.Text = EnumHandler.GetDescription(tempPatient.Sex);
            textBoxRegistrationDate.Text = tempPatient.DateOfRegistration.ToShortDateString();
            textBoxCity.Text = tempPatient.City;
            textBoxStreet.Text = tempPatient.Street;
            textBoxHouse.Text = tempPatient.House;
            textBoxPorch.Text = tempPatient.Porch;
            textBoxFlat.Text = tempPatient.Flat;
            textBoxPhone.Text = tempPatient.PhoneNumber;
            textBoxEmail.Text = tempPatient.Email;
            richTextBoxMiscInfo.Text = tempPatient.MiscInformation;
            UpdateAppointments();
        }

        private void listBoxAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAppointments.SelectedIndex == -1)
            {
                return;
            }

        }

        private void buttonAppointmentInfo_Click(object sender, EventArgs e)
        {
            if (listBoxAppointments.SelectedIndex == -1)
            {
                return;
            }
            AddViewAppointmentForm appointmentForm = new AddViewAppointmentForm();
            GenericRepository<Appointment> appointmentRepo = new GenericRepository<Appointment>(Db);
            appointmentForm.Appointment = appointmentRepo.GetById(AppointmentsList[listBoxAppointments.SelectedIndex].Id);
            foreach (Control control in appointmentForm.Controls)
            {
                control.Enabled = false;
            }
            appointmentForm.Controls["buttonCancel"].Enabled = true;
            appointmentForm.Controls["buttonSeeTemplate"].Enabled = true;
            appointmentForm.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEditPatientForm patientForm = new AddEditPatientForm();
            patientForm.Patient = new Patient();
            patientForm.ShowDialog();
            if (patientForm.DialogResult == DialogResult.OK)
            {
                var updatedPatient = patientForm.Patient;
                GenericRepository<Patient> patientRepo = new GenericRepository<Patient>(Db);
                patientRepo.Add(updatedPatient);
            }
            UpdatePatients();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxPatients.SelectedIndex == -1)
            {
                return;
            }

            AddEditPatientForm patientForm = new AddEditPatientForm();
            var tempItem = listBoxPatients.SelectedItem;
            var testString = tempItem.ToString();
            testString = Regex.Match(testString, @"\d+").Value;
            patientForm.Patient = PatientsList.Find(x => x.Id.ToString() == testString);
            if (patientForm.Patient.InUse == 0)
            {
                //TODO: ЗАШОООООООООООООООООООО ПЕРЕКЛЕПАТЬ
                using (ClinicContext Db = new ClinicContext())
                {
                    patientForm.Patient.InUse = (InUseType)1;
                GenericRepository<Patient> patientRepo = new GenericRepository<Patient>(Db);
                patientRepo.Modify(patientForm.Patient);
                patientForm.ShowDialog();
                if (patientForm.DialogResult == DialogResult.OK)
                {
                    var updatedPatient = patientForm.Patient;
                    updatedPatient.InUse = 0;
                    patientRepo.Modify(updatedPatient);
                    UpdatePatients();
                }
                else
                {
                    patientForm.Patient.InUse = 0;
                    patientRepo.Modify(patientForm.Patient);
                    UpdatePatients();
                }
                }
            }
            else
            {
                MessageBox.Show("В данный момент запись редактируется.");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPatients.SelectedIndex == -1)
            {
                return;
            }

            DialogResult deleteResult = MessageBox.Show("Вы точно хотите удалить пациента?",
                "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (deleteResult == DialogResult.OK)
            {
                var tempItem = listBoxPatients.SelectedItem;
                var testString = tempItem.ToString();
                testString = Regex.Match(testString, @"\d+").Value;
                var selectedPatient = PatientsList.Find(x => x.Id.ToString() == testString);
                GenericRepository<Patient> patientRepo = new GenericRepository<Patient>(Db);
                patientRepo.DeleteById(selectedPatient.Id);
                UpdatePatients();
            }
            UpdatePatients();
        }

    }
}
