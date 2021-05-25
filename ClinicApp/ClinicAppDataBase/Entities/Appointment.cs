using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using ClinicAppBusinessLogic;

namespace ClinicAppDataBase.Entities
{
    public class Appointment
    {
        private int _id;
        //private string _appointmentType;
        private AppointmentType _appointmentType;
        private DateTime _dateOfAppointment;
        private string _complaints;
        private string _anamnesis;
        private string _condition;
        private string _diagnosis;
        private string _icdCode;
        private string _recomendations;
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

        public DateTime DateOfAppointment
        {
            get
            {
                return _dateOfAppointment;
            }
            set
            {
                _dateOfAppointment = value;
            }
        }

        //private string _complaints;
        //private string _anamnesis;
        //private string _condition;
        //private string _diagnosis;
        //private string _icdCode;
        //private string _recomendations;
        //private string _medicinalTherapy;

        public string Complains
        {
            get
            {
                return _complaints;
            }
            set
            {
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
                _icdCode = value;
            }
        }

        public string Recomendations
        {
            get
            {
                return _recomendations;
            }
            set
            {
                _recomendations = value;
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
