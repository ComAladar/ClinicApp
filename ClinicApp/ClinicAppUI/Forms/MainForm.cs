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
using ClinicAppTemplatesLogic;

namespace ClinicAppUI.Forms
{
    public partial class MainForm : Form
    {
        private ClinicContext Db;
        private HomeUserControl homeControl;
        private PatientUserControl patientControl;
        private ScheduleUserControl scheduleControl;
        private StaffUserControl staffControl;
        private AnalyticsUserControl analyticsControl;
        private CashboxUserControl cashboxControl;

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
            scheduleControl.Db = Db;
            scheduleControl.CurrentUser = CurrentUser;
            panelMainUC.Controls["scheduleUserControl"].BringToFront();
        }

        private void SelectStaffControl()
        {
            staffControl.Db = Db;
            staffControl.CurrentUser = CurrentUser;
            panelMainUC.Controls["staffUserControl"].BringToFront();
        }

        private void SelectCashBoxControl()
        {
            cashboxControl.Db = Db;
            cashboxControl.CurrentUser = CurrentUser;
            panelMainUC.Controls["cashboxUserControl"].BringToFront();
        }

        private void SelectAnalyticsControl()
        {
            analyticsControl.Db = Db;
            analyticsControl.CurrentUser = CurrentUser;
            panelMainUC.Controls["analyticsUserControl"].BringToFront();
        }

        private void NavigationPanelInitialize(Button button)
        {
            panelNavigation.Height = button.Height;
            panelNavigation.Top = button.Top;
            panelNavigation.Left = button.Left;
            button.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void NavigationPanelChangeButton(Button button)
        {
            button.BackColor = Color.FromArgb(24, 30, 54);
        }

        public MainForm()
        {
            InitializeComponent();
            Db = new ClinicContext();
            NavigationPanelInitialize(buttonHome);
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

            analyticsControl = new AnalyticsUserControl();
            analyticsControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(analyticsControl);

            cashboxControl = new CashboxUserControl();
            cashboxControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(cashboxControl);

            SelectHomeControl();
            homeControl.ButtonLoginClick += new EventHandler(HomeControl_ButtonLogicClick);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            NavigationPanelInitialize(buttonHome);
            SelectHomeControl();
        }

        private void buttonPatient_Click(object sender, EventArgs e)
        {
            NavigationPanelInitialize(buttonPatient);
            SelectPatientControl();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            NavigationPanelInitialize(buttonStaff);
            SelectStaffControl();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            NavigationPanelInitialize(buttonSchedule);
            SelectScheduleControl();
        }

        private void buttonAnalytics_Click(object sender, EventArgs e)
        {
            NavigationPanelInitialize(buttonAnalytics);
            SelectAnalyticsControl();
        }

        private void buttonCashBox_Click(object sender, EventArgs e)
        {
            NavigationPanelInitialize(buttonCashBox);
            SelectCashBoxControl();
        }

        protected void HomeControl_ButtonLogicClick(object sender, EventArgs e)
        {
            CurrentUser = homeControl.CurrentUser;
            buttonPatient.Enabled = true;
            buttonSchedule.Enabled = true;
            buttonStaff.Enabled = true;
            buttonAnalytics.Enabled = true;
            buttonCashBox.Enabled = true;
            labelStaffFullname.Text = CurrentUser.Surname + " " + CurrentUser.Name;
            labelQualification.Text = CurrentUser.Qualification;
            labelPosition.Text = CurrentUser.Position;
            labelSpecialty.Text = CurrentUser.Speciality;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void buttonHome_Leave(object sender, EventArgs e)
        {
            NavigationPanelChangeButton(buttonHome);
        }

        private void buttonPatient_Leave(object sender, EventArgs e)
        {
            NavigationPanelChangeButton(buttonPatient);
        }

        private void buttonStaff_Leave(object sender, EventArgs e)
        {
            NavigationPanelChangeButton(buttonStaff);
        }

        private void buttonSchedule_Leave(object sender, EventArgs e)
        {
            NavigationPanelChangeButton(buttonSchedule);
        }

        private void buttonCashBox_Leave(object sender, EventArgs e)
        {
            NavigationPanelChangeButton(buttonCashBox);
        }

        private void buttonAnalytics_Leave(object sender, EventArgs e)
        {
            NavigationPanelChangeButton(buttonAnalytics);
        }
    }
}
