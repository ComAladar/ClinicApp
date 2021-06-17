using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppBusinessLogic.Enumerations;
using ClinicAppDataBase;
using ClinicAppDataBase.Entities;

namespace ClinicAppUI.Forms
{
    public partial class AddReceiptForm : Form
    {
        public Appointment SelectedAppointment { get; set; }
        public double Price { get; set; }
        public int SelectedPatientId { get; set; }
        private List<Appointment> AppointmentsList { get; set; } = new List<Appointment>();
        public EnumerationHandler EnumHandler = new EnumerationHandler();

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
                Db.Appointments.Load();
                //TODO: ПОМЕНЯТЬ ИЗ КОМПЛИТЕ ПОТОМ
                var appointments= Db.Appointments.Where(a => 
                    a.PatientId == SelectedPatientId 
                    && a.IsComplete == (ComplitionType)0 
                    && a.Receipt == null);
                foreach (var item in appointments)
                {
                    AppointmentsList.Add(item);
                }
                foreach (var item in AppointmentsList)
                {
                    listBoxAppointments.Items.Add("Дата: " + item.DateOfSchedule.Date.ToLongDateString() + " "
                        + item.DateOfSchedule.TimeOfDay.Hours + ":"
                        + item.DateOfSchedule.TimeOfDay.Minutes + ". ФИ Пациента:  "
                        + item.Patient.Surname + " " + item.Patient.Name);
                }
            }
        }


        public AddReceiptForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxAppointments.SelectedIndex==-1)
            {
                MessageBox.Show("Выберите прием!");
                return;
            }
            Appointment tempAppointment=AppointmentsList[listBoxAppointments.SelectedIndex];
            SelectedAppointment = tempAppointment;
            Price = double.Parse(textBoxFinalCost.Text) + double.Parse(textBoxAdditionalCost.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void textBoxMainCost_Leave(object sender, EventArgs e)
        {
            textBoxFinalCost.Text =
                (double.Parse(textBoxMainCost.Text) + double.Parse(textBoxAdditionalCost.Text)).ToString(CultureInfo.InvariantCulture);
        }

        private void textBoxAdditionalCost_Leave(object sender, EventArgs e)
        {
            textBoxFinalCost.Text =
                (double.Parse(textBoxMainCost.Text) + double.Parse(textBoxAdditionalCost.Text)).ToString(CultureInfo.InvariantCulture);
        }

        private void listBoxAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAppointments.SelectedIndex == -1)
            {
                return;
            }

            var fullname = AppointmentsList[listBoxAppointments.SelectedIndex].Staff.Surname + " " +
                           AppointmentsList[listBoxAppointments.SelectedIndex].Staff.Name + " " +
                           AppointmentsList[listBoxAppointments.SelectedIndex].Staff.Patronymic;
            labelStaffText.Text = fullname;
            labelAppointmentTypeText.Text = EnumHandler.GetDescription(AppointmentsList[listBoxAppointments.SelectedIndex].AppointmentType);
        }

        private void checkBoxAdditionalCosts_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdditionalCosts.Checked == true)
            {
                textBoxAdditionalCost.Enabled = true;
            }
            else textBoxAdditionalCost.Enabled = false;
        }
    }
}
