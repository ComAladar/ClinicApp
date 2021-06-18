using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppBusinessLogic.Enumerations;
using ClinicAppDataBase;
using ClinicAppDataBase.Entities;
using ClinicAppDataBase.Repositories;

namespace ClinicAppUI.Forms
{
    public partial class AddScheduleForm : Form
    {
        private DateTime _selectedDate;
        private ClinicContext _db;

        public Staff selectedStaff { get; set; }
        public Patient selectedPatient { get; set; }
        public AppointmentType SelectedAppointmentType { get; set; }
        private List<Staff> StaffList { get; set; } = new List<Staff>();
        private List<Patient> PatientsList { get; set; } = new List<Patient>();

        public DateTime selectedDate
        {
            get
            {
                return _selectedDate;
            }
            set
            {
                _selectedDate = value;
                dateTimePickerDate.Text = selectedDate.ToString();
            }
        }


        public ClinicContext Db
        {
            get
            {
                return _db;
            }
            set
            {
                _db = value;
                ListBoxPatientsFillUp();
                ListBoxStaffFillUp();
            }
        }

        private void ListBoxPatientsFillUp()
        {
            GenericRepository<Patient> patientRepo = new GenericRepository<Patient>(Db);
            IEnumerable<Patient> patients = patientRepo.GetList();
            foreach (var item in patients)
            {
                PatientsList.Add(item);
            }
            PatientsList.OrderBy(item => item.Surname).ToList();

            foreach (var item in PatientsList)
            {
                var fullName = item.Id + ") " + item.Surname + " " + item.Name;
                listBoxPatients.Items.Add(fullName);
            }
        }

        private void ListBoxStaffFillUp()
        {
            GenericRepository<Staff> staffRepo = new GenericRepository<Staff>(Db);
            IEnumerable<Staff> staff = staffRepo.GetList();
            foreach (var item in staff)
            {
                StaffList.Add(item);
            }
            StaffList.OrderBy(item => item.Surname).ToList();

            foreach (var item in StaffList)
            {
                var fullName = item.Id + ") " + item.Surname + " " + item.Name;
                listBoxStaff.Items.Add(fullName);
            }
        }


        public AddScheduleForm()
        {
            InitializeComponent();
            dateTimePickerTime.CustomFormat = "HH:mm";
            dateTimePickerTime.Format = DateTimePickerFormat.Custom;
            comboBoxAppointmentType.DataSource = Enum.GetNames(typeof(AppointmentType));
        }

        private Patient SelectedPatient()
        {
            var tempItem = listBoxPatients.SelectedItem;
            var testString = tempItem.ToString();
            testString = Regex.Match(testString, @"\d+").Value;
            var tempPatient = PatientsList.Find(x => x.Id.ToString() == testString);
            return tempPatient;
        }

        private Staff SelectedStaff()
        {
            var tempItem = listBoxStaff.SelectedItem;
            var testString = tempItem.ToString();
            testString = Regex.Match(testString, @"\d+").Value;
            var tempStaff = StaffList.Find(x => x.Id.ToString() == testString);
            return tempStaff;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxPatients.SelectedIndex == -1 || listBoxStaff.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите доктора и пациента.","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            selectedStaff = SelectedStaff();
            selectedPatient = SelectedPatient();
            //if (string.IsNullOrEmpty(comboBoxDoctor.Text) || string.IsNullOrEmpty(comboBoxPatient.Text))
            //{
            //    MessageBox.Show("Выберите доктора и пациента.");
            //    return;
            //}

            //Staff tempStaff = comboBoxDoctor.SelectedItem as Staff;
            //Patient tempPatient = comboBoxPatient.SelectedItem as Patient;
            //selectedStaff = tempStaff;
            //selectedPatient = tempPatient;


            SelectedAppointmentType = (AppointmentType)comboBoxAppointmentType.SelectedIndex;
            try
            {
                selectedDate = dateTimePickerDate.Value.Date + dateTimePickerTime.Value.TimeOfDay;
                if (selectedDate < DateTime.Now.Date)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show("Дата задана неверно.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxPatientSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxPatients.Items.Clear();
            foreach (var item in PatientsList)
            {
                var fullName = item.Id + ") " + item.Surname + " " + item.Name;
                if (item.Surname.StartsWith(textBoxPatientSearch.Text,
                    StringComparison.CurrentCultureIgnoreCase)) listBoxPatients.Items.Add(fullName);
            }
        }

        private void textBoxStaffSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxStaff.Items.Clear();
            foreach (var item in StaffList)
            {
                var fullName = item.Id + ") " + item.Surname + " " + item.Name;
                if (item.Surname.StartsWith(textBoxStaffSearch.Text,
                    StringComparison.CurrentCultureIgnoreCase))
                {
                    listBoxStaff.Items.Add(fullName);
                }
            }
        }

        private void listBoxPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tempPatient = SelectedPatient();
            labelDateOfBirthText.Text = tempPatient.DateOfBirth.ToShortDateString();
        }

        private void listBoxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tempStaff = SelectedStaff();
            labelPositionText.Text = tempStaff.Position;
            labelSpecialtyText.Text = tempStaff.Speciality;
        }
    }
}
