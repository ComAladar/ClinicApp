using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppBusinessLogic
{
    public enum AccessType
    {
        [Description("Администратор")]
        Admin,
        [Description("Доктор")]
        Doctor,
        [Description("Регистратура")]
        Registry
    }
}
