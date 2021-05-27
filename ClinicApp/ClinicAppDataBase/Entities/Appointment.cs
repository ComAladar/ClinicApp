using System;
using System.Collections.Generic;
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
    public class Appointment
    {
        private int _id;
        //private string _appointmentType;
        private AppointmentType _appointmentType;
        private string _complaints;
        private string _anamnesis;
        private string _condition;
        private string _diagnosis;
        private string _icdCode;
        private string _recommendations;
        private string _medicinalTherapy;

        //Проверить и разузнать насчет типа int?  СВЯЗЬ 1 К 1 SCHEDULE--->APPOINTMENT
        //public int? ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        //
        //СВЯЗЬ PATIENT--->APPOINTMENT 1 К МНОГИМ
        public int? PatientId { get; set; }
        public Patient Patients { get; set; }
        //
        //Связь STAFF--->APPOINTMENT 1 К МНОГИМ
        public int? StaffId { get; set; }
        public Staff Staff { get; set; }
        //
        [ForeignKey("Schedule")]
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

        public AppointmentType AppointmentType
        {
            get
            {
                return _appointmentType;
            }
            set
            {
                _appointmentType = value;
            }
        }

        public string Complains
        {
            get
            {
                return _complaints;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Поле заполнено неверно.");
                }
                _complaints = value;
            }
        }

        public string Anamnesis
        {
            get
            {
                return _anamnesis;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Поле заполнено неверно.");
                }
                _anamnesis = value;
            }
        }

        public string Condition
        {
            get
            {
                return _condition;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Поле заполнено неверно.");
                }
                _condition = value;
            }
        }

        public string Diagnosis
        {
            get
            {
                return _diagnosis;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Поле заполнено неверно.");
                }
                _diagnosis = value;
            }
        }

        public string ICDCode
        {
            get
            {
                return _icdCode;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Поле заполнено неверно.");
                }
                _icdCode = value;
            }
        }

        public string Recommendations
        {
            get
            {
                return _recommendations;
            }
            set
            {
                _recommendations = value;
            }
        }

        public string MedicinalTherapy
        {
            get
            {
                return _medicinalTherapy;
            }
            set
            {
                _medicinalTherapy = value;
            }
        }






    }
}
