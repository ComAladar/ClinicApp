using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicAppBusinessLogic.Enumerations;

namespace ClinicAppDataBase.Entities
{
    public class Schedule
    {
        private int _id;
        private DateTime _dateOfSchedule;

        //Проверить и разузнать насчет типа int?  СВЯЗЬ 1 К 1 SCHEDULE--->APPOINTMENT
        public Appointment Appointment { get; set; }
        //
        //СВЯЗЬ STAFF--->SCHEDULE 1 К МНОГИМ
        public int? StaffId { get; set; }
        public Staff Staff { get; set; }
        //

        //СВЯЗЬ PATIENT--->SCHEDULE 1 К МНОГИМ
        public int? PatientId { get; set; }
        public Patient Patient { get; set; }
        //

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

        [Column(TypeName = "datetime2")]
        public DateTime DateOfSchedule
        {
            get
            {
                return _dateOfSchedule;
            }
            set
            {
                _dateOfSchedule = value;
            }
        }

        public ComplitionType IsComplete { get; set; }


    }
}
