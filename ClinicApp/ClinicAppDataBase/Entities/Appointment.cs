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
    /// Класс для данных приема.
    /// </summary>
    public class Appointment
    {
        //СВЯЗЬ PATIENT--->APPOINTMENT 1 К МНОГИМ
        public int? PatientId { get; set; }
        public Patient Patient { get; set; }
        //Связь STAFF--->APPOINTMENT 1 К МНОГИМ
        public int? StaffId { get; set; }
        public Staff Staff { get; set; }
        //СВЯЗЬ Appointment ----> Receipt 1 к 1
        public virtual Receipt Receipt { get; set; }
        //

        /// <summary>
        /// Свойство хранящее уникальный номер пользователя.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Свойство хранящее полное название приема.
        /// </summary>
        public string AppointmentName { get; set; }

        /// <summary>
        /// Свойство хранящее тип приема.
        /// </summary>
        public AppointmentType AppointmentType { get; set; }

        /// <summary>
        /// Свойство хранящее жалобы пациента.
        /// </summary>
        public string Complains { get; set; }

        /// <summary>
        /// Свойство хранящее анамнез пациента.
        /// </summary>
        public string Anamnesis { get; set; }

        /// <summary>
        /// Свойство хранящее обьективное состояние пациента.
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// Свойство хранящее вынесенный диагноз пациента.
        /// </summary>
        public string Diagnosis { get; set; }

        /// <summary>
        /// Свойство хранящее МКБ-код вынесенного диагноза и заболевания.
        /// </summary>
        public string ICDCode { get; set; }

        /// <summary>
        /// Свойство хранящее рекомендации врача.
        /// </summary>
        public string Recommendations { get; set; }

        /// <summary>
        /// Свойство хранящее лекарственную террапию пациента.
        /// </summary>
        public string MedicinalTherapy { get; set; }

        /// <summary>
        /// Свойство хранящее дату приема.
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime DateOfSchedule { get; set; }

        /// <summary>
        /// Свойство хранящее статус приема.
        /// </summary>
        public ComplitionType IsComplete { get; set; }

    }
}
