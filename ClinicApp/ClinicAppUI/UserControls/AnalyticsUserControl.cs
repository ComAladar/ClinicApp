using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClinicAppDataBase;
using ClinicAppDataBase.Entities;
using ClinicAppDataBase.Repositories;

namespace ClinicAppUI.UserControls
{
    public partial class AnalyticsUserControl : UserControl
    {
        public Staff CurrentUser;
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
                StaffDataInitialization();
                PatientDataInitialization();
                ReceiptDataInitialization();
            }
        }

        private List<Staff> StaffsList { get; set; } = new List<Staff>();

        public AnalyticsUserControl()
        {
            InitializeComponent();
        }

        private void PatientDataInitialization()
        {
            GenericRepository<Patient> patientRepo = new GenericRepository<Patient>(Db);
            IEnumerable<Patient> patients = patientRepo.GetList();
            int patientCount = 0;
            int patientAgeCount1 = 0;
            int patientAgeCount2 = 0;
            int patientAgeCount3 = 0;
            int patientAgeCount4 = 0;
            int patientAgeCount5 = 0;
            int patientAge1 = 18;
            int patientAge2 = 25;
            int patientAge3 = 35;
            int patientAge4 = 55;
            foreach (var item in patients)
            {
                patientCount++;
                if (DateTime.Now.Year - item.DateOfBirth.Year < patientAge1)
                {
                    patientAgeCount1++;
                }
                else if (DateTime.Now.Year - item.DateOfBirth.Year < patientAge2)
                {
                    patientAgeCount2++;
                }
                else if (DateTime.Now.Year - item.DateOfBirth.Year < patientAge3)
                {
                    patientAgeCount3++;
                }
                else if (DateTime.Now.Year - item.DateOfBirth.Year < patientAge4)
                {
                    patientAgeCount4++;
                }
                else
                {
                    patientAgeCount5++;
                }
            }

            labelPatientAmountText.Text = patientCount.ToString();
            labelPatientAgeText1.Text = patientAgeCount1.ToString();
            labelPatientAgeText2.Text = patientAgeCount2.ToString();
            labelPatientAgeText3.Text = patientAgeCount3.ToString();
            labelPatientAgeText4.Text = patientAgeCount4.ToString();
            labelPatientAgeText5.Text = patientAgeCount5.ToString();
        }

        private void StaffDataInitialization()
        {
            StaffsList.Clear();
            GenericRepository<Staff> staffRepo = new GenericRepository<Staff>(Db);
            IEnumerable<Staff> staffs = staffRepo.GetList();
            int staffCount = 0;
            foreach (var item in staffs)
            {
                StaffsList.Add(item);
                staffCount++;
            }
            listBoxStaffAnalytic.Items.Clear();
            foreach (var item in StaffsList)
            {
                listBoxStaffAnalytic.Items.Add("Врач: " + item.Surname + " " + item.Name);
            }

            labelStaffAmountText.Text = staffCount.ToString();

        }

        private void ReceiptDataInitialization()
        {
            GenericRepository<Receipt> receiptRepo = new GenericRepository<Receipt>(Db);
            IEnumerable<Receipt> receipts = receiptRepo.GetList();
            int receiptsAmount = 0;
            int receiptsPaidAmount = 0;
            double receiptsPaidPrice = 0;
            int receiptsNotPaidAmount = 0;
            double receiptsNotPaidPrice = 0;
            double receiptsAveragePrice = 0;
            foreach (var item in receipts)
            {
                receiptsAmount++;
                if (item.Status == 0)
                {
                    receiptsNotPaidAmount++;
                    receiptsNotPaidPrice += item.Price;
                }
                else
                {
                    receiptsPaidAmount++;
                    receiptsPaidPrice += item.Price;
                    receiptsAveragePrice += item.Price / receipts.Count();
                }
            }

            labelReceiptAmountText.Text = receiptsAmount.ToString();
            labelReceiptPaidText.Text = receiptsPaidAmount.ToString();
            labelReceiptPaidPriceText.Text = receiptsPaidPrice.ToString();
            labelReceiptUnpaidText.Text = receiptsNotPaidAmount.ToString();
            labelReceiptUnpaidPriceText.Text = receiptsNotPaidPrice.ToString();
            labelReceiptAveragePriceText.Text = receiptsAveragePrice.ToString();

        }

        private void StaffDateTimeChanged()
        {
            var selectedStaff = StaffsList[listBoxStaffAnalytic.SelectedIndex];
            GenericRepository<Appointment> appointmentRepo = new GenericRepository<Appointment>(Db);
            IEnumerable<Appointment> appointments =
                appointmentRepo.GetList().Where
                (a => a.StaffId == selectedStaff.Id
                      && a.DateOfSchedule <= dateTimePickerFinishDate.Value
                      && a.DateOfSchedule >= dateTimePickerStartDate.Value);
            int appointmentsCount = 0;
            int appointmentsFinisedCount = 0;
            int appointmentsUnfinishedCount = 0;
            foreach (var item in appointments)
            {
                appointmentsCount++;
                if (item.IsComplete == 0)
                {
                    appointmentsUnfinishedCount++;
                }
                else appointmentsFinisedCount++;
            }

            labelAppointmentsAmountText.Text = appointmentsCount.ToString();
            labelFinishedAppointmentsText.Text = appointmentsFinisedCount.ToString();
            labelUnfinishedAppointmentsText.Text = appointmentsUnfinishedCount.ToString();
        }

        private void listBoxStaffAnalytic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStaffAnalytic.SelectedIndex == -1)
            {
                return;
            }
            StaffDateTimeChanged();
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            StaffDateTimeChanged();
        }

        private void dateTimePickerFinishDate_ValueChanged(object sender, EventArgs e)
        {
            StaffDateTimeChanged();
        }
    }
}
