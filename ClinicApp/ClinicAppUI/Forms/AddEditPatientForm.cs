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
using ClinicAppDataBase.Entities;


namespace ClinicAppUI.Forms
{
    public partial class AddEditPatientForm : Form
    {
        private Patient _patient;

        public Patient Patient
        {
            get
            {
                return _patient;
            }
            set
            {
                _patient = value;
                textBoxSurname.Text = _patient.Surname;
                textBoxName.Text = _patient.Name;
                textBoxPatronymic.Text = _patient.Patronymic;
                dateTimePickerBirthDate.Text = _patient.DateOfBirth.ToString();
                comboBoxSex.SelectedIndex = (int)_patient.Sex;
                dateTimePickerRegistrationDate.Text = _patient.DateOfRegistration.ToString();
                textBoxCity.Text = _patient.City;
                textBoxStreet.Text = _patient.Street;
                textBoxHouse.Text = _patient.House;
                textBoxFlat.Text = _patient.Flat;
                textBoxPorch.Text = _patient.Porch;
                textBoxPhone.Text = _patient.PhoneNumber;
                textBoxEmail.Text = _patient.Email;
                richTextBoxMiscInfo.Text = _patient.MiscInformation;
            }
        }

        public AddEditPatientForm()
        {
            InitializeComponent();
            comboBoxSex.DataSource = Enum.GetNames(typeof(SexType));
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Patient.Surname = textBoxSurname.Text;
                Patient.Name = textBoxName.Text;
                Patient.Patronymic = textBoxPatronymic.Text;
                Patient.DateOfBirth = Convert.ToDateTime(dateTimePickerBirthDate.Text);
                Patient.Sex = (SexType)comboBoxSex.SelectedIndex;
                Patient.DateOfRegistration = Convert.ToDateTime(dateTimePickerRegistrationDate.Text);
                Patient.City = textBoxCity.Text;
                Patient.Street = textBoxStreet.Text;
                Patient.House = textBoxHouse.Text;
                Patient.Flat = textBoxFlat.Text;
                Patient.Porch = textBoxPorch.Text;
                Patient.PhoneNumber = textBoxPhone.Text;
                Patient.Email = textBoxEmail.Text;
                Patient.MiscInformation = richTextBoxMiscInfo.Text;
            }
            catch(ArgumentException exception)
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
    }
}
