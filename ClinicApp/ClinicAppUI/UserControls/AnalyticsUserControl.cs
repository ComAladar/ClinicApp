using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppDataBase;
using ClinicAppDataBase.Entities;

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
            }
        }

        public AnalyticsUserControl()
        {
            InitializeComponent();
        }
    }
}
