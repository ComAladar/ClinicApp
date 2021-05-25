using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ClinicAppBusinessLogic
{
    public enum AppointmentType
    {
        [Description("Первичный")]
        First,
        [Description("Вторичный")]
        Second
    }
}
