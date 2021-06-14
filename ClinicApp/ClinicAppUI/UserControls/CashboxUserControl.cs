using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppDataBase;
using ClinicAppDataBase.Entities;
using ClinicAppDataBase.Repositories;
using ClinicAppUI.Forms;

namespace ClinicAppUI.UserControls
{
    public partial class CashboxUserControl : UserControl
    {
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
        public List<Receipt> ReceiptsList { get; set; } = new List<Receipt>();

        private void UpdatePatients()
        {
            GetPatients();
            PatientsListBoxFillUp();
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

        private void UpdateReceipts()
        {
            GetReceipts();
            ReceiptsDataSourceFillUp();
        }

        private void GetReceipts()
        {
            ReceiptsList.Clear();
            GenericRepository<Receipt> receiptRepo = new GenericRepository<Receipt>(Db);
            IEnumerable<Receipt> receipts = receiptRepo.GetList();
            foreach (var item in receipts)
            {
                ReceiptsList.Add(item);
            }
        }

        private void ReceiptsDataSourceFillUp()
        {
            dataGridViewReceipts.ClearSelection();
            var tempItem = listBoxPatients.SelectedItem;
            var testString = tempItem.ToString();
            testString = Regex.Match(testString, @"\d+").Value;
            var tempPatient = PatientsList.Find(x => x.Id.ToString() == testString);
            try
            {
                foreach (var item in ReceiptsList)
                {
                    if (tempPatient.Id == item.Appointment.PatientId)
                    {
                        dataGridViewReceipts.Rows.Add(item.Id, item.ReceiptNumber, item.Price, item.Status.ToString(),
                            item.Appointment.DateOfSchedule.ToString(),
                            item.Staff.Surname + " " + item.Staff.Name + " " + item.Staff.Patronymic);
                    }
                }
            }
            catch
            {

            }
        }

        public CashboxUserControl()
        {
            InitializeComponent();
        }

        private void buttonAddReceipt_Click(object sender, EventArgs e)
        {
            var tempItem = listBoxPatients.SelectedItem;
            var testString = tempItem.ToString();
            testString = Regex.Match(testString, @"\d+").Value;
            var tempPatient = PatientsList.Find(x => x.Id.ToString() == testString);

            AddReceiptForm receiptForm = new AddReceiptForm();
            receiptForm.SelectedPatientId = tempPatient.Id;
            receiptForm.Db = Db;
            receiptForm.ShowDialog();
            if (receiptForm.DialogResult == DialogResult.OK)
            {
                Receipt currentReceipt = new Receipt();
                currentReceipt.Appointment = receiptForm.SelectedAppointment;
                currentReceipt.Price = receiptForm.Price;
                currentReceipt.Staff = CurrentUser;
                //TODO:сделать номера адекватно
                currentReceipt.ReceiptNumber = 1;
                Db.Receipts.Add(currentReceipt);
                Db.SaveChanges();
            }
            else return;
        }

        private void buttonDeleteReceipt_Click(object sender, EventArgs e)
        {

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
            labelInitialsText.Text = tempPatient.Surname + " " + tempPatient.Name + " " + tempPatient.Patronymic;
            labelDateOfBirthText.Text = tempPatient.DateOfBirth.Date.ToString();
            labelSexText.Text = tempPatient.Sex.ToString();
            labelPhoneNumberText.Text = tempPatient.PhoneNumber;
            labelEmailText.Text = tempPatient.Email;
            UpdateReceipts();
        }
    }
}
