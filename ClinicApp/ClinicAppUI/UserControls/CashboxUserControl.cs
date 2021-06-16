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
using ClinicAppBusinessLogic.Enumerations;
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
            get { return _db; }
            set
            {
                _db = value;
                UpdatePatients();
            }

        }

        public List<Patient> PatientsList { get; set; } = new List<Patient>();
        public List<Receipt> ReceiptsList { get; set; } = new List<Receipt>();
        public EnumerationHandler EnumHandler = new EnumerationHandler();

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
            dataGridViewReceipts.Rows.Clear();
            if (ReceiptsList != null)
            {
                var tempItem = listBoxPatients.SelectedItem;
                var testString = tempItem.ToString();
                testString = Regex.Match(testString, @"\d+").Value;
                var tempPatient = PatientsList.Find(x => x.Id.ToString() == testString);
                foreach (var item in ReceiptsList)
                {
                    if (tempPatient.Id == item.Appointment.PatientId)
                    {
                        //var shortName = item.Staff.Name.Substring(0, 1);
                        //var shortPatronymic = item.Staff.Patronymic.Substring(0, 1);
                        //var fullname = item.Staff.Surname + " " + shortName + " " + shortPatronymic;
                        dataGridViewReceipts.Rows.Add(item.Id.ToString(),
                            item.ReceiptNumber.ToString(),
                            item.Price.ToString(),
                            EnumHandler.GetDescription(item.Status),
                            item.Appointment.DateOfSchedule.ToShortDateString());
                    }
                }
            }
            else return;
        }

        public CashboxUserControl()
        {
            InitializeComponent();
        }

        private void buttonAddReceipt_Click(object sender, EventArgs e)
        {
            if (listBoxPatients.SelectedIndex == -1)
            {
                return;
            }

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
                int tempNumber=1;
                foreach (var item in ReceiptsList)
                {
                    tempNumber++;
                }
                currentReceipt.ReceiptNumber = tempNumber;
                Db.Receipts.Add(currentReceipt);
                Db.SaveChanges();
                UpdateReceipts();
            }
            else return;
        }

        private void buttonDeleteReceipt_Click(object sender, EventArgs e)
        {
            if (listBoxPatients.SelectedIndex == -1)
            {
                return;
            }
            DialogResult deleteResult = MessageBox.Show("Вы точно хотите удалить чек?",
                "Удаление чека", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (deleteResult == DialogResult.OK)
            {
                if (dataGridViewReceipts.SelectedRows.Count > 0)
                {
                    int index = dataGridViewReceipts.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridViewReceipts[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    GenericRepository<Receipt> receiptRepo = new GenericRepository<Receipt>(Db);
                    var selectedReceipt = receiptRepo.GetById(id);
                    if (selectedReceipt.Status == 0)
                    {
                        receiptRepo.Delete(selectedReceipt);
                        UpdateReceipts();
              
                    }
                    else
                    {
                        MessageBox.Show("Невозможно удалить чек, который уже оплачен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
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
            labelInitialsText.Text = tempPatient.Surname + " " + tempPatient.Name + " " + tempPatient.Patronymic;
            labelDateOfBirthText.Text = tempPatient.DateOfBirth.Date.ToString();
            labelSexText.Text = tempPatient.Sex.ToString();
            labelPhoneNumberText.Text = tempPatient.PhoneNumber;
            labelEmailText.Text = tempPatient.Email;
            UpdateReceipts();
            double sumPaid = 0;
            int sumReceiptPaid = 0;
            double sumNotPaid = 0;
            int sumReceiptNotPaid = 0;
            foreach (var item in ReceiptsList)
            {
                if (item.Status == (ReceiptStatus) 1)
                {
                    sumPaid += item.Price;
                    sumReceiptPaid++;
                }
                else
                {
                    sumNotPaid += item.Price;
                    sumReceiptNotPaid++;
                }
            }
            labelPaidAmountText.Text = sumPaid.ToString();
            labelPaidTimesText.Text = sumReceiptPaid.ToString();
            labelNotPaidAmountText.Text = sumNotPaid.ToString();
            labelNotPaidTimesText.Text = sumReceiptNotPaid.ToString();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxPatients.Items.Clear();
            foreach (var item in PatientsList)
            {
                var fullName = item.Id + ") " + item.Surname + " " + item.Name;
                if (item.Surname.StartsWith(textBoxSearch.Text,
                    StringComparison.CurrentCultureIgnoreCase)) listBoxPatients.Items.Add(fullName);
            }
        }

        private void buttonUpdateStatus_Click(object sender, EventArgs e)
        {
            if (listBoxPatients.SelectedIndex == -1)
            {
                return;
            }

            DialogResult updateResult = MessageBox.Show("Вы точно изменить статус чека на Оплачено?",
                "Фиксирование оплаты", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (updateResult == DialogResult.OK)
            {
                if (dataGridViewReceipts.SelectedRows.Count > 0)
                {
                    int index = dataGridViewReceipts.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridViewReceipts[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    GenericRepository<Receipt> receiptRepo = new GenericRepository<Receipt>(Db);
                    var selectedReceipt = receiptRepo.GetById(id);
                    if (selectedReceipt.Status != (ReceiptStatus) 1)
                    {
                        selectedReceipt.Status = (ReceiptStatus) 1;
                    }
                    else
                    {
                        MessageBox.Show("Невозможно изменить статус уже оплаченного чека!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    receiptRepo.Modify(selectedReceipt);
                    UpdateReceipts();
                }
            }
        }
    }
}
