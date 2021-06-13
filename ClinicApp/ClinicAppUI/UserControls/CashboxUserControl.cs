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
    public partial class CashboxUserControl : UserControl
    {
        public Staff CurrentUser { get; set; }
        public ClinicContext Db { get; set; }

        public CashboxUserControl()
        {
            InitializeComponent();
        }
    }
}
