using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppBusinessLogic.Enumerations
{
    public enum ReceiptStatus
    {
        [Description("Неоплачен")]
        NotPaid,
        [Description("Оплачен")]
        Paid,
    }
}
