using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppBusinessLogic.Enumerations
{
    /// <summary>
    /// Перечисление для хранения прав доступа пользователей приложения.
    /// </summary>
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
