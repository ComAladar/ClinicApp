using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppBusinessLogic.Enumerations
{
    /// <summary>
    /// Перечисление хранящее статусы оплаты чеков.
    /// </summary>
    public enum ReceiptStatus
    {
        [Description("Неоплачен")]
        NotPaid,
        [Description("Оплачен")]
        Paid,
    }
}
