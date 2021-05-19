using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppUI.UserControls;

namespace ClinicAppUI.Forms
{
    public partial class MainForm : Form
    {
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

        private void button2_Click(object sender, EventArgs e)
        {
            SelectPatientControl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectStaffControl();
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AboutForm aboutForm = new AboutForm();
            //aboutForm.Show();
            //AddEditPatientForm testForm = new AddEditPatientForm();
            //testForm.Show();
            AddViewAppointmentForm testForm = new AddViewAppointmentForm();
            testForm.Show();
        }
    }
}
