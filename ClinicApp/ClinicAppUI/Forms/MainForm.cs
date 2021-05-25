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
using ClinicAppUI.UserControls;
using ClinicAppBusinessLogic;
using ClinicAppDataBase;

namespace ClinicAppUI.Forms
{
    public partial class MainForm : Form
    {
        private ClinicContext db;
        private EnumerationHandler enumerationHandler;

        private void SelectHomeControl()
        {
            panelMainUC.Controls["homeUserControl"].BringToFront();
            buttonHome.Visible = true;
        }

        private void SelectPatientControl()
        {
            panelMainUC.Controls["patientUserControl"].BringToFront();
            buttonHome.Visible = true;
        }

        private void SelectScheduleControl()
        {
            panelMainUC.Controls["scheduleUserControl"].BringToFront();
            buttonHome.Visible = true;
        }

        private void SelectStaffControl()
        {
            panelMainUC.Controls["staffUserControl"].BringToFront();
            buttonHome.Visible = true;
        }

        public MainForm()
        {
            InitializeComponent();
            db = new ClinicContext();
            db.Schedules.Load();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonHome.Visible = true;

            HomeUserControl homeControl = new HomeUserControl();
            homeControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(homeControl);

            PatientUserControl patientControl = new PatientUserControl();
            patientControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(patientControl);

            ScheduleUserControl scheduleControl = new ScheduleUserControl();
            scheduleControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(scheduleControl);

            StaffUserControl staffControl = new StaffUserControl();
            staffControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(staffControl);

            SelectHomeControl();
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
    }
}
