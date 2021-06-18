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
        private ClinicContext Db { get; set; }
        private HomeUserControl _homeControl;
        private PatientUserControl _patientControl;
        private ScheduleUserControl _scheduleControl;
        private StaffUserControl _staffControl;
        private AnalyticsUserControl _analyticsControl;
        private CashboxUserControl _cashboxControl;

        public Staff CurrentUser { get; set; }


        private void SelectHomeControl()
        {
            _homeControl.Db = Db;
            panelMainUC.Controls["homeUserControl"].BringToFront();
        }

        private void SelectPatientControl()
        {
            _patientControl.Db = Db;
            _patientControl.CurrentUser = CurrentUser;
            panelMainUC.Controls["patientUserControl"].BringToFront();

        }

        private void SelectScheduleControl()
        {
            _scheduleControl.Db = Db;
            _scheduleControl.CurrentUser = CurrentUser;
            panelMainUC.Controls["scheduleUserControl"].BringToFront();
        }

        private void SelectStaffControl()
        {
            _staffControl.Db = Db;
            _staffControl.CurrentUser = CurrentUser;
            panelMainUC.Controls["staffUserControl"].BringToFront();
        }

        private void SelectCashBoxControl()
        {
            _cashboxControl.Db = Db;
            _cashboxControl.CurrentUser = CurrentUser;
            panelMainUC.Controls["cashboxUserControl"].BringToFront();
        }

        private void SelectAnalyticsControl()
        {
            _analyticsControl.Db = Db;
            _analyticsControl.CurrentUser = CurrentUser;
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
            _homeControl = new HomeUserControl();
            _homeControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(_homeControl);

            _patientControl = new PatientUserControl();
            _patientControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(_patientControl);

            _scheduleControl = new ScheduleUserControl();
            _scheduleControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(_scheduleControl);

            _staffControl = new StaffUserControl();
            _staffControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(_staffControl);

            _analyticsControl = new AnalyticsUserControl();
            _analyticsControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(_analyticsControl);

            _cashboxControl = new CashboxUserControl();
            _cashboxControl.Dock = DockStyle.Fill;
            panelMainUC.Controls.Add(_cashboxControl);

            SelectHomeControl();
            _homeControl.ButtonLoginClick += new EventHandler(HomeControl_ButtonLogicClick);
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
            CurrentUser = _homeControl.CurrentUser;
            buttonPatient.Enabled = true;
            buttonSchedule.Enabled = true;
            buttonStaff.Enabled = true;
            buttonAnalytics.Enabled = true;
            buttonCashBox.Enabled = true;
            labelStaffFullname.Text = CurrentUser.Surname + " " + CurrentUser.Name;
            labelQualification.Text = CurrentUser.Qualification;
            labelPosition.Text = CurrentUser.Position;
            labelSpecialty.Text = CurrentUser.Speciality;
            if (CurrentUser.Access != AccessType.Admin)
            {
                buttonAnalytics.Enabled = false;
                _patientControl.Controls["panelPatientSelect"].Controls["buttonDelete"].Enabled = false;
                _staffControl.Controls["panelStaff"].Controls["buttonDelete"].Enabled = false;
                _staffControl.Controls["panelStaff"].Controls["buttonEdit"].Enabled = false;
            }

            if (CurrentUser.Access != AccessType.Doctor)
            {
                _homeControl.Controls["panelSchedule"].Enabled = false;
            }

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
