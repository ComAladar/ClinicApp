using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppBusinessLogic.Enumerations;
using ClinicAppDataBase;
using ClinicAppDataBase.Entities;
using ClinicAppTemplatesLogic;


namespace ClinicAppUI.Forms
{
    public partial class AddViewAppointmentForm : Form
    {
        //public Schedule appointmentSchedule = new Schedule();
        public Appointment Appointment = new Appointment();


        public AddViewAppointmentForm()
        {
            InitializeComponent();
            comboBoxAppointmentType.DataSource = Enum.GetNames(typeof(AppointmentType));
        }

        private void AddViewAppointmentForm_Load(object sender, EventArgs e)
        {
            textBoxStaff.Text = Appointment.Staff.Surname + " " + Appointment.Staff.Name;
            textBoxPatient.Text = Appointment.Patient.Surname + " " + Appointment.Patient.Name;
            textBoxId.Text = Appointment.AppointmentId.ToString();
            textBoxDate.Text = Appointment.DateOfSchedule.ToString();
            comboBoxAppointmentType.Text = Appointment.AppointmentType.ToString();
            Appointment.Patient = Appointment.Patient;
            try
            {
                richTextBoxComplains.Text = Appointment.Complains;
                richTextBoxAnamnesis.Text = Appointment.Anamnesis;
                richTextBoxCondition.Text = Appointment.Condition;
                richTextBoxDiagnosis.Text = Appointment.Diagnosis;
                richTextBoxRecommendations.Text = Appointment.Recommendations;
                richTextBoxMedicinalTherapy.Text = Appointment.MedicinalTherapy;
                comboBoxAppointmentType.Text = Appointment.AppointmentType.ToString();
                textBoxICD.Text = Appointment.ICDCode;

            }
            catch (Exception exception)
            {

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Appointment.Id = appointmentSchedule.Id;
            //Appointment.PatientId = appointmentSchedule.PatientId;
            //Appointment.StaffId = appointmentSchedule.StaffId;
            //Appointment.Complains = richTextBoxComplains.Text;
            //Appointment.Anamnesis = richTextBoxAnamnesis.Text;
            //Appointment.Condition = richTextBoxCondition.Text;
            //Appointment.Diagnosis = richTextBoxDiagnosis.Text;
            //Appointment.ICDCode = textBoxICD.Text;
            //Appointment.Recommendations = richTextBoxRecommendations.Text;
            //Appointment.MedicinalTherapy = richTextBoxMedicinalTherapy.Text;
            //Appointment.AppointmentType = (AppointmentType)comboBoxAppointmentType.SelectedIndex;
            ////Appointment.Schedule.IsComplete = (ComplitionType)1;
            try
            {
                //TODO:МОЖЕТ БЫТЬ И НАДО
                //Appointment.Id = appointmentSchedule.Id;
                //Appointment.PatientId = appointmentSchedule.PatientId;
                //Appointment.StaffId = appointmentSchedule.StaffId;
                Appointment.Complains = richTextBoxComplains.Text;
                Appointment.Anamnesis = richTextBoxAnamnesis.Text;
                Appointment.Condition = richTextBoxCondition.Text;
                Appointment.Diagnosis = richTextBoxDiagnosis.Text;
                Appointment.ICDCode = textBoxICD.Text;
                Appointment.Recommendations = richTextBoxRecommendations.Text;
                Appointment.MedicinalTherapy = richTextBoxMedicinalTherapy.Text;
                Appointment.AppointmentType = (AppointmentType)comboBoxAppointmentType.SelectedIndex;
                //Appointment.Schedule.IsComplete = (ComplitionType)1;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
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

        private void buttonSeeTemplate_Click(object sender, EventArgs e)
        {
            TemplateBuilder tempBuilder = new TemplateBuilder();
            tempBuilder.OpenAppointmentTemplate(Appointment);
        }
    }
}
