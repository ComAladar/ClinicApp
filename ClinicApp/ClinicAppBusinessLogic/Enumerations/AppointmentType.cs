using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppBusinessLogic.Enumerations
{
    /// <summary>
    /// Перечисления для хранение типов приемов.
    /// </summary>
    public enum AppointmentType
    {
        [Description("Первичный")]
        First,
        [Description("Вторичный")]
        Second
    }
}
