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
    public class Receipt
    {
        private int _id;
        private int _receiptNumber;
        private double _price;
        private ReceiptStatus _status;

        //СВЯЗЬ С APPOINTMENT И STAFF
        //СВЯЗЬ Appointment ----> Receipt 1 к 1
        //public  int? AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
        //

        //Связь Staff ----> Receipt 1 к многим
        public int? StaffId { get; set; }
        public Staff Staff { get; set; }
        
        //
        [Key]
        [ForeignKey("Appointment")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public int ReceiptNumber
        {
            get
            {
                return _receiptNumber;
            }
            set
            {
                _receiptNumber = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public ReceiptStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

    }
}
