using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClinicAppBusinessLogic.Enumerations;

namespace ClinicAppDataBase.Entities
{
    /// <summary>
    /// Класс для данных пациента.
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Поле для хранения имени пациента.
        /// </summary>
        private string _name;
        /// <summary>
        /// Поле для хранения фамилии пациента.
        /// </summary>
        private string _surname;
        /// <summary>
        /// Поле для хранения отчества пациента.
        /// </summary>
        private string _patronymic;
        /// <summary>
        /// Поле для хранения даты рождения пациента.
        /// </summary>
        private DateTime _dateOfBirth=DateTime.Now;
        /// <summary>
        /// Поле для хранения номера телефона пациента.
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Поле для хранения адреса электронной почты пациента.
        /// </summary>
        private string _email;
        /// <summary>
        /// Поле для определения максимальной длинны имя, фамилии и отчества.
        /// </summary>
        private static int _length = 30;

        //СВЯЗЬ PATIENT--->APPOINTMENT 1 К МНОГИМ
        public ICollection<Appointment> Appointments { get; set; }

        /// <summary>
        /// Свойство хранящее уникальный номер пациента.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Свойство хранящее имя пациента.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Имя не может быть пустой!");
                }
                if (value.Length > _length)
                {
                    throw new ArgumentException("Максимальная длина имя не должна быть больше " + _length + " символов.");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Свойство хранящее фамилию пациента.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Фамилия не может быть пустой!");
                }
                if (value.Length > _length)
                {
                    throw new ArgumentException("Максимальная длина фамилии не должна быть больше " + _length + " символов.");
                }
                _surname = value;
            }
        }

        /// <summary>
        /// Свойство хранящее отчество пациента.
        /// </summary>
        public string Patronymic
        {
            get
            {
                return _patronymic;
            }
            set
            {
                if (value.Length > _length)
                {
                    throw new ArgumentException("Максимальная длина отчества не должна быть больше " + _length + " символов.");
                }
                _patronymic = value;
            }
        }

        //https://en.wikipedia.org/wiki/ISO/IEC_5218 0-Неизвестно; 1-Мужчина 2-Женщина
        /// <summary>
        /// Свойство хранящее пол пациента.
        /// </summary>
        public SexType Sex { get; set; }

        /// <summary>
        /// Свойство хранящее дату рождения пациента.
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value > DateTime.Now.Date)
                {
                    throw new ArgumentException("Дата рождения введена с ошибкой.");
                }
                _dateOfBirth = value;
            }
        }

        /// <summary>
        /// Свойство хранящее дату регистрации пациента.
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime DateOfRegistration { get; set; } = DateTime.Now;

        /// <summary>
        /// Свойство хранящее город проживания пациента.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Свойство хранящее адрес улицы пациента.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Свойство хранящее номер дома пациента.
        /// </summary>
        public string House { get; set; }

        /// <summary>
        /// Свойство хранящее номер квартиры пациента.
        /// </summary>
        public string Flat { get; set; }

        /// <summary>
        /// Свойство хранящее номер подьезда пациента.
        /// </summary>
        public string Porch { get; set; }

        /// <summary>
        /// Свойство хранящее номер телефона пациента.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (Regex.IsMatch(value, @"[0-9]{10,11}", RegexOptions.IgnoreCase) == false)
                {
                    throw new ArgumentException("Номер телефона был задан неверно.");
                }
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Свойство хранящее адрес электронной почты пациента.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (Regex.IsMatch(value,
                    @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})",
                    RegexOptions.IgnoreCase) == false)
                {
                    throw new ArgumentException("Email имеет неверный формат.");
                }
                _email = value;
            }
        }

        /// <summary>
        /// Свойство хранящее сторонню информацию пациента.
        /// </summary>
        public string MiscInformation { get; set; }

        /// <summary>
        /// Свойство хранящее состояние редактирования данных пациента.
        /// </summary>
        public InUseType InUse { get; set; }

        /// <summary>
        /// Конструктор пациента для инициализации связей.
        /// </summary>
        public Patient()
        {
            Appointments = new List<Appointment>();
        }
    }
}
