using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClinicAppBusinessLogic;
using ClinicAppBusinessLogic.Enumerations;
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

        public class DataSourceView
        {
            public int Id { get; set; }
            public string Doctor { get; set; }
            public string Patient { get; set; }
            public DateTime DateSchedule { get; set; }

        }


        private void UpdateSchedule()
        {
            Db.Appointments.Load();
            Db.Staffs.Load();
            Db.Patients.Load();
            var selectedDate = monthCalendar1.SelectionEnd.Date;
            var table = from s in Db.Appointments
                where DbFunctions.TruncateTime(s.DateOfSchedule) == DbFunctions.TruncateTime(monthCalendar1.SelectionEnd)
                join d in Db.Staffs on s.StaffId equals d.Id
                join p in Db.Patients on s.PatientId equals p.Id
                select new
                {
                    Id=s.Id,
                    DoctorInfo = d.Surname +" " + d.Name,
                    PatientInfo = p.Surname + " " + p.Name,
                    ScheduleDate = s.DateOfSchedule
                };
            viewList = new List<DataSourceView>();
            foreach(var item in table)
            {
                var data = new DataSourceView();
                data.Id = item.Id;
                data.Doctor = item.DoctorInfo;
                data.Patient = item.PatientInfo;
                data.DateSchedule = item.ScheduleDate;
                viewList.Add(data);
            }
            dataGridViewSchedule.ClearSelection();
            dataGridViewSchedule.DataSource = viewList;
            dataGridViewSchedule.Columns[0].Width = 40;
            dataGridViewSchedule.Columns[1].Width = 200;
            dataGridViewSchedule.Columns[2].Width = 200;
            dataGridViewSchedule.Columns[3].Width = 150;
        }

        public List<DataSourceView> viewList;

        public ClinicContext Db
        {
            get
            {
                return _db;
            }
            set
            {
                _db = value;
               UpdateSchedule();
            }
        }

        public ScheduleUserControl()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //TODO:ЕСЛИ НОВЫЙ ПРИЕМ В ТЕЧЕНИИ 3 МЕСЯЦЕВ У ТОГО ЖЕ ВРАЧА- ТО ПОСОВЕТОВАТЬ ПОВТОРНЫЙ
            AddScheduleForm scheduleForm = new AddScheduleForm();
            scheduleForm.Db = Db;
            scheduleForm.selectedDate = DateTime.Now;
            scheduleForm.ShowDialog();
            if (scheduleForm.DialogResult == DialogResult.OK)
            {
                Appointment currentAppointment = new Appointment();
                currentAppointment.Patient = scheduleForm.selectedPatient;
                currentAppointment.Staff = scheduleForm.selectedStaff;
                currentAppointment.DateOfSchedule = scheduleForm.selectedDate;
                currentAppointment.AppointmentType = scheduleForm.SelectedAppointmentType;
                currentAppointment.IsComplete = 0;
                Db.Appointments.Add(currentAppointment);
                Db.SaveChanges();
                UpdateSchedule();
            }
            else return;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            UpdateSchedule();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteResult = MessageBox.Show("Вы точно хотите удалить запись?",
                "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (deleteResult == DialogResult.OK)
            {
                if (dataGridViewSchedule.SelectedRows.Count > 0)
                {
                    int index = dataGridViewSchedule.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridViewSchedule[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    GenericRepository<Appointment> appointmentRepo = new GenericRepository<Appointment>(Db);
                    var selectedAppointment = appointmentRepo.GetById(id);
                    if (selectedAppointment.IsComplete == (ComplitionType) 1 || selectedAppointment.Receipt != null)
                    {
                        MessageBox.Show("Прием уже завершен или был создан чек. Удаление невозможно.");
                        return;
                    }
                    appointmentRepo.DeleteById(id);
                    UpdateSchedule();
                }

            }
        }
    }
}
