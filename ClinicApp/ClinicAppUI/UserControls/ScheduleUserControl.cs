using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClinicAppBusinessLogic;
using WindowsFormsCalendar;
using ClinicAppDataBase;
using ClinicAppDataBase.Entities;
using ClinicAppDataBase.Repositories;
using ClinicAppUI.Forms;


namespace ClinicAppUI.UserControls
{
    //https://sourceforge.net/projects/winformscalenda/
    public partial class ScheduleUserControl : UserControl
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
                Db.Schedules.Load();
                Db.Staffs.Load();
                Db.Patients.Load();
                dataGridViewSchedule.DataSource = Db.Schedules.Local.ToBindingList().Where(s => s.DateOfSchedule.Date == DateTime.Today).ToList();
                dataGridViewSchedule.Refresh();
                HideColumnsName();


            }
        }

        private void HideColumnsName()
        {
            if (dataGridViewSchedule.Columns.Count != 0)
            {
                dataGridViewSchedule.Columns.Remove("Appointment");
                dataGridViewSchedule.Columns.Remove("StaffId");
                dataGridViewSchedule.Columns.Remove("PatientId");
                dataGridViewSchedule.Columns.Remove("Id");
                dataGridViewSchedule.Columns.Remove("InUse");
            }
        }

        public ScheduleUserControl()
        {
            InitializeComponent();
        }

        private void monthViewMain_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewSchedule.DataSource = Db.Schedules.Local.ToBindingList().Where(s => s.DateOfSchedule.Date == monthViewMain.SelectionStart.Date).ToList();
            HideColumnsName();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddScheduleForm scheduleForm = new AddScheduleForm();
            scheduleForm.Db = Db;
            scheduleForm.selectedDate = DateTime.Now;
            scheduleForm.ShowDialog();
            if (scheduleForm.DialogResult == DialogResult.OK)
            {
                Schedule currentSchedule = new Schedule();
                currentSchedule.Patient = scheduleForm.selectedPatient;
                currentSchedule.Staff = scheduleForm.selectedStaff;
                currentSchedule.DateOfSchedule = scheduleForm.selectedDate;
                Db.Schedules.Add(currentSchedule);
                Db.SaveChanges();
            }
            else return;
        }
    }
}
