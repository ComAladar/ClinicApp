using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using ClinicAppBusinessLogic;
using ClinicAppBusinessLogic.Enumerations;

namespace ClinicAppDataBase.Entities
{
    /// <summary>
    /// Класс для данных чеков.
    /// </summary>
    public class Receipt
    {
        //СВЯЗЬ Appointment ----> Receipt 1 к 1
        public virtual Appointment Appointment { get; set; }

        //Связь Staff ----> Receipt 1 к многим
        public int? StaffId { get; set; }
        public Staff Staff { get; set; }
        
        /// <summary>
        /// Свойство хранящее уникальный номер чека приема.
        /// </summary>
        [Key]
        [ForeignKey("Appointment")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        /// <summary>
        /// Свойство хранящее номер чека пациента.
        /// </summary>
        public int ReceiptNumber { get; set; }

        /// <summary>
        /// Свойство хранящее стоимость приема.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Свойство хранящее статус оплаты чека.
        /// </summary>
        public ReceiptStatus Status { get; set; }

    }
}
