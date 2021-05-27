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
    public class Patient
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _patronymic;
        private SexType _sex; //https://en.wikipedia.org/wiki/ISO/IEC_5218 0-Неизвестно; 1-Мужчина 2-Женщина
        private DateTime _dateOfBirth;
        private DateTime _dateOfRegistration=DateTime.Now;
        private string _city;
        private string _street;
        private string _house;
        private string _flat;
        private string _porch;
        private string _phoneNumber;
        private string _email;
        private string _miscInformation;

        //СВЯЗЬ PATIENT--->APPOINTMENT 1 К МНОГИМ
        public ICollection<Appointment> Appointments { get; set; }
        //

        //СВЯЗЬ PATIENT--->SCHEDULE 1 К МНОГИМ
        public ICollection<Schedule> Schedules { get; set; }
        //

        //ИНИЦИАЛИЗАЦИЯ СВЯЗЕЙ?
        public Patient()
        {
            Appointments = new List<Appointment>();
            Schedules = new List<Schedule>();
        }
        //
        private static int _length = 30;

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

        public SexType Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }

        }

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

        [Column(TypeName = "datetime2")]
        public DateTime DateOfRegistration
        {
            get
            {
                return _dateOfRegistration;
            }
            set
            {
                _dateOfRegistration = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }

        public string House
        {
            get
            {
                return _house;
            }
            set
            {
                _house = value;
            }
        }

        public string Flat
        {
            get
            {
                return _flat;
            }
            set
            {
                _flat = value;
            }
        }

        public string Porch
        {
            get
            {
                return _porch;
            }
            set
            {
                _porch = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (Regex.IsMatch(value, @"[0-9]{11}", RegexOptions.IgnoreCase) == false)
                {
                    throw new ArgumentException("Номер телефона был задан неверно.");
                }
                _phoneNumber = value;
            }
        }

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

        public string MiscInformation
        {
            get
            {
                return _miscInformation;
            }
            set
            {
                _miscInformation = value;
            }
        }
    }
}
