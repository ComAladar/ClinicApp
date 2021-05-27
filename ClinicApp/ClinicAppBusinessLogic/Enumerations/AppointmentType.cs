using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppBusinessLogic.Enumerations
{
    public enum AppointmentType
    {
        [Description("Первичный")]
        First,
        [Description("Вторичный")]
        Second
    }
}
