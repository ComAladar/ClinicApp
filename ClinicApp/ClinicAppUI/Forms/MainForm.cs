using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppBusinessLogic;
using ClinicAppBusinessLogic.Enumerations;
using ClinicAppUI.UserControls;
using ClinicAppDataBase;
using ClinicAppDataBase.Entities;
using ClinicAppDataBase.Repositories;

namespace ClinicAppUI.Forms
{
    public partial class MainForm : Form
    {
        private ClinicContext Db;
        private HomeUserControl homeControl;
        private PatientUserControl patientControl;
        private ScheduleUserControl scheduleControl;
        private StaffUserControl staffControl;

        public Staff CurrentUser { get; set; }


        private void SelectHomeControl()
        {
            homeControl.Db = Db;
            panelMainUC.Controls["homeUserControl"].BringToFront();
        }

        private void SelectPatientControl()
        {
            patientControl.Db = Db;
            patientControl.CurrentUser = CurrentUser;
            panelMainUC.Controls["patientUserControl"].BringToFront();

        }

        private void SelectScheduleControl()
        {
            panelMainUC.Controls["scheduleUserControl"].BringToFront();
        }

        private void SelectStaffControl()
        {
            panelMainUC.Controls["staffUserControl"].BringToFront();
        }


        public MainForm()
        {
            InitializeComponent();
            Db = new ClinicContext();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            homeControl = new HomeUserControl();
            homeControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(homeControl);

            patientControl = new PatientUserControl();
            patientControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(patientControl);

            scheduleControl = new ScheduleUserControl();
            scheduleControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(scheduleControl);

            staffControl = new StaffUserControl();
            staffControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(staffControl);

            SelectHomeControl();
            homeControl.ButtonLoginClick += new EventHandler(HomeControl_ButtonLogicClick);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            SelectHomeControl();
        }



        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void buttonPatient_Click(object sender, EventArgs e)
        {
            SelectPatientControl();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            SelectStaffControl();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            SelectScheduleControl();
        }

        protected void HomeControl_ButtonLogicClick(object sender, EventArgs e)
        {
            CurrentUser = homeControl.CurrentUser;
            buttonPatient.Enabled = true;
            buttonSchedule.Enabled = true;
            buttonStaff.Enabled = true;
        }
    }
}
