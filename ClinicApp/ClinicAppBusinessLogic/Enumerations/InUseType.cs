using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppBusinessLogic.Enumerations
{
    public enum InUseType
    {
        [Description("Не используется")]
        NoUse,
        [Description("Используется")]
        InUse

    }
}
