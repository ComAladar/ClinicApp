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
    public partial class AddEditStaffForm : Form
    {
        private Staff _staff;

        public Staff Staff
        {
            get
            {
                return _staff;
            }
            set
            {
                _staff = value;
            }
        }



        public AddEditStaffForm()
        {
            InitializeComponent();
            comboBoxSex.DataSource = Enum.GetNames(typeof(SexType));
            comboBoxAccess.DataSource = Enum.GetNames(typeof(AccessType));
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Staff.Surname = textBoxSurname.Text;
                Staff.Name = textBoxName.Text;
                Staff.Patronymic = textBoxPatronymic.Text;
                Staff.DateOfBirth = Convert.ToDateTime(dateTimePickerBirthDate.Text);
                Staff.Sex = (SexType)comboBoxSex.SelectedIndex;
                Staff.DateOfRegistration = Convert.ToDateTime(dateTimePickerRegistrationDate.Text);
                Staff.PhoneNumber = textBoxPhone.Text;
                Staff.Email = textBoxEmail.Text;
                Staff.Login = textBoxLogin.Text;
                Staff.Password = textBoxPassword.Text;
                Staff.Access = (AccessType) comboBoxAccess.SelectedIndex;
                Staff.Qualification = textBoxQualification.Text;
                Staff.Speciality = textBoxSpecialty.Text;
                Staff.Position = textBoxPosition.Text;
                Staff.DateOfEmployment = Convert.ToDateTime(dateTimePickerEmploymentDate.Text);
            }
            catch (ArgumentException exception)
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

        private void AddEditStaffForm_Load(object sender, EventArgs e)
        {
            textBoxSurname.Text = _staff.Surname;
            textBoxName.Text = _staff.Name;
            textBoxPatronymic.Text = _staff.Patronymic;
            dateTimePickerBirthDate.Text = _staff.DateOfBirth.ToString();
            comboBoxSex.SelectedIndex = (int)_staff.Sex;
            dateTimePickerRegistrationDate.Text = _staff.DateOfRegistration.ToString();
            textBoxPhone.Text = _staff.PhoneNumber;
            textBoxEmail.Text = _staff.Email;
            textBoxLogin.Text = _staff.Login;
            textBoxPassword.Text = _staff.Password;
            comboBoxAccess.SelectedIndex = (int)_staff.Access;
            textBoxQualification.Text = _staff.Qualification;
            textBoxSpecialty.Text = _staff.Speciality;
            textBoxPosition.Text = _staff.Position;
            dateTimePickerEmploymentDate.Text = _staff.DateOfEmployment.ToString();
        }
    }
}
