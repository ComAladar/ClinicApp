using System;
using System.Windows.Forms;
using ClinicAppUI.UserControls;

namespace ClinicAppUI.Forms
{
    public partial class MainForm : Form
    {
        private void SelectHomeControl()
        {
            panelMainUC.Controls["homeControl"].BringToFront();
            buttonHome.Visible = false;
        }

        private void SelectPatientControl()
        {
            panelMainUC.Controls["patientControl"].BringToFront();
            buttonHome.Visible = true;
        }

        private void SelectScheduleControl()
        {
            panelMainUC.Controls["scheduleControl"].BringToFront();
            buttonHome.Visible = true;
        }

        private void SelectStaffControl()
        {
            panelMainUC.Controls["staffControl"].BringToFront();
            buttonHome.Visible = true;
        }

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonHome.Visible = false;

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

        private void button2_Click(object sender, EventArgs e)
        {
            SelectPatientControl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectScheduleControl();
        }
    }
}
