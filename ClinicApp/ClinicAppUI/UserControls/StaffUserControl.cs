using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    public partial class StaffUserControl : UserControl
    {
        public Staff CurrentUser { get; set; }
        //TODO:СДЕЛАТЬ ОТОБРАЖЕНИЕ ПРИЕМОВ
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
                UpdateStaff();
                UpdateAppointments();
            }
        }

        public List<Staff> StaffList { get; set; } = new List<Staff>();
        public List<Appointment> AppointmentsList { get; set; } = new List<Appointment>();
        public EnumerationHandler EnumHandler = new EnumerationHandler();

        private void UpdateStaff()
        {
            GetStaff();
            StaffListBoxFillUp();
        }

        private void UpdateAppointments()
        {
            GetAppointments();
            AppointmentsListBoxFillUp();
        }

        private void GetStaff()
        {
            StaffList.Clear();
            GenericRepository<Staff> staffRepo = new GenericRepository<Staff>(Db);
            IEnumerable<Staff> staff = staffRepo.GetList();
            foreach (var item in staff)
            {
                StaffList.Add(item);
            }
        }

        private void GetAppointments()
        {
            AppointmentsList.Clear();
            GenericRepository<Appointment> appointmentRepo = new GenericRepository<Appointment>(Db);
            IEnumerable<Appointment> appointments = appointmentRepo.GetList();
            foreach (var item in appointments)
            {
                AppointmentsList.Add(item);
            }
        }

        private void StaffListBoxFillUp()
        {
            listBoxStaff.Items.Clear();
            StaffList.OrderBy(item => item.Surname).ToList();

            foreach (var item in StaffList)
            {
                var fullName = item.Surname + " " + item.Name;
                listBoxStaff.Items.Add(fullName);
            }
        }

        private void AppointmentsListBoxFillUp()
        {
            listBoxAppointments.Items.Clear();
            AppointmentsList.OrderByDescending(item => item.Schedule.DateOfSchedule).ToList();
            foreach (var item in AppointmentsList)
            {
                listBoxAppointments.Items.Add(item.Schedule.DateOfSchedule);
            }
        }

        public StaffUserControl()
        {
            InitializeComponent();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxStaff.Items.Clear();
            foreach (var item in StaffList)
            {
                var fullName = item.Surname + " " + item.Name;
                if (item.Surname.StartsWith(textBoxSearch.Text,
                    StringComparison.CurrentCultureIgnoreCase)) listBoxStaff.Items.Add(fullName);
            }
        }

        private void listBoxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStaff.SelectedIndex == -1)
            {
                return;
            }
            var tempStaff = StaffList[listBoxStaff.SelectedIndex];
            textBoxSurname.Text = tempStaff.Surname;
            textBoxName.Text = tempStaff.Name;
            textBoxPatronymic.Text = tempStaff.Patronymic;
            textBoxBirthDate.Text = tempStaff.DateOfBirth.ToString();
            textBoxSex.Text = EnumHandler.GetDescription(tempStaff.Sex);
            textBoxRegistrationDate.Text = tempStaff.DateOfRegistration.ToString();
            textBoxPhone.Text = tempStaff.PhoneNumber;
            textBoxEmail.Text = tempStaff.Email;
            textBoxAccess.Text = EnumHandler.GetDescription(tempStaff.Access);
            textBoxQualification.Text = tempStaff.Qualification;
            textBoxSpecialty.Text = tempStaff.Speciality;
            textBoxPosition.Text = tempStaff.Position;
            textBoxEmploymentDate.Text = tempStaff.DateOfEmployment.ToString();
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

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEditStaffForm patientForm = new AddEditStaffForm();
            patientForm.Staff = new Staff();
            patientForm.ShowDialog();
            if (patientForm.DialogResult == DialogResult.OK)
            {
                var updatedStaff = patientForm.Staff;
                GenericRepository<Staff> staffRepo = new GenericRepository<Staff>(Db);
                staffRepo.Add(updatedStaff);
                UpdateStaff();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxStaff.SelectedIndex == -1)
            {
                return;
            }

            AddEditStaffForm staffForm = new AddEditStaffForm();
            staffForm.Staff = StaffList[listBoxStaff.SelectedIndex];
            if (staffForm.Staff.InUse == 0)
            {
                //TODO: ЗАШОООООООООООООООООООО ПЕРЕКЛЕПАТЬ
                using (ClinicContext Db = new ClinicContext())
                {
                    staffForm.Staff.InUse = (InUseType)1;
                    GenericRepository<Staff> staffRepo = new GenericRepository<Staff>(Db);
                    staffRepo.Modify(staffForm.Staff);
                    staffForm.ShowDialog();
                    if (staffForm.DialogResult == DialogResult.OK)
                    {
                        var updatedStaff = staffForm.Staff;
                        updatedStaff.InUse = 0;
                        staffRepo.Modify(updatedStaff);
                        UpdateStaff();
                    }
                    else
                    {
                        staffForm.Staff.InUse = 0;
                        staffRepo.Modify(staffForm.Staff);
                        UpdateStaff();
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
            if (listBoxStaff.SelectedIndex == -1 || StaffList[listBoxStaff.SelectedIndex].Id==CurrentUser.Id)
            {
                return;
            }

            DialogResult deleteResult = MessageBox.Show("Вы точно хотите удалить персонал?",
                "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (deleteResult == DialogResult.OK)
            {
                var index = listBoxStaff.SelectedIndex;
                var selectedStaff = StaffList[index];
                GenericRepository<Staff> staffRepo = new GenericRepository<Staff>(Db);
                staffRepo.DeleteById(selectedStaff.Id);
                UpdateStaff();
            }
        }
    }
}
