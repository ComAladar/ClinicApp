using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppBusinessLogic.Enumerations;
using ClinicAppDataBase;
using ClinicAppDataBase.Entities;

namespace ClinicAppUI.Forms
{
    public partial class AddScheduleForm : Form
    {
        public Staff selectedStaff { get; set; }
        private DateTime _selectedDate;

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

        public Patient selectedPatient { get; set; }
        public AppointmentType SelectedAppointmentType { get; set; }

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
                Db.Patients.Load();
                Db.Staffs.Load();
                comboBoxDoctor.DataSource = Db.Staffs.Local.ToBindingList();
                comboBoxDoctor.DisplayMember = "Surname";
                comboBoxDoctor.ValueMember = "Surname";
                comboBoxPatient.DataSource = Db.Patients.Local.ToBindingList();
                comboBoxPatient.DisplayMember = "Surname";
                comboBoxPatient.ValueMember = "Surname";
            }
        }


        public AddScheduleForm()
        {
            InitializeComponent();
            dateTimePickerTime.CustomFormat = "HH:mm";
            dateTimePickerTime.Format = DateTimePickerFormat.Custom;
            comboBoxAppointmentType.DataSource = Enum.GetNames(typeof(AppointmentType));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxDoctor.Text) || string.IsNullOrEmpty(comboBoxPatient.Text))
            {
                MessageBox.Show("Выберите доктора и пациента.");
                return;
            }

            Staff tempStaff = comboBoxDoctor.SelectedItem as Staff;
            Patient tempPatient = comboBoxPatient.SelectedItem as Patient;
            selectedStaff = tempStaff;
            selectedPatient = tempPatient;
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
    }
}
