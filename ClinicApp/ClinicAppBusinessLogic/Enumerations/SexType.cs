using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppBusinessLogic.Enumerations
{
    public enum SexType
    {
        [Description("Не определенно")]
        Unknown,
        [Description("Мужчина")]
        Male,
        [Description("Женщина")]
        Female
    }
}
