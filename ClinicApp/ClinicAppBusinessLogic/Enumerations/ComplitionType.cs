using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppBusinessLogic.Enumerations
{
    /// <summary>
    /// Перечисления для хранения состояния приема.
    /// </summary>
    public enum ComplitionType
    {
        [Description("Открыт")]
        Opened,
        [Description("Заверешен")]
        Closed,

    }
}
