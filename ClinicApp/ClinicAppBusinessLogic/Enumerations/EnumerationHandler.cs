using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppBusinessLogic.Enumerations
{
    /// <summary>
    /// Класс для работы с перечислениями.
    /// </summary>
     public class EnumerationHandler
    {
        /// <summary>
        /// Метод для вывода описания выбранного элемента перечислений.
        /// </summary>
        /// <param name="enumElement">Элемент перечисления</param>
        /// <returns>Описание выбранного элемента перечисления.</returns>
        public string GetDescription(Enum enumElement)
        {
            Type type = enumElement.GetType();
            MemberInfo[] memInfo = type.GetMember(enumElement.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0) return ((DescriptionAttribute) attrs[0]).Description;
            }

            return enumElement.ToString();
        }
    }
}
