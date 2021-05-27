using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClinicAppBusinessLogic;
using ClinicAppBusinessLogic.Enumerations;

namespace ClinicAppDataBase.Entities
{
    public class Staff
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _patronymic;
        private SexType _sex; //https://en.wikipedia.org/wiki/ISO/IEC_5218 0-Неизвестно; 1-Мужчина 2-Женщина
        private DateTime _dateOfBirth;
        private DateTime _dateOfRegistration=DateTime.Now;
        private string _phoneNumber;
        private string _email;
        private string _login;
        private string _password;
        private AccessType _access;
        private string _qualification;
        private string _position;
        private string _speciality;
        private DateTime _dateOfEmployment;

        //СВЯЗЬ STAFF--->APPOINTMENT 1 К МНОГИМ
        public ICollection<Appointment> Appointments { get; set; }
        //

        //СВЯЗЬ STAFF--->SCHEDULE 1 К МНОГИМ
        public ICollection<Schedule> Schedules { get; set; }
        //

        //СВЯЗЬ STAFF--->MESSAGEBOARD 1 К МНОГИМ
        public ICollection<MessageBoard> MessageBoards { get; set; }
        //

        //ИНИЦИАЛИЗАЦИЯ СВЯЗЕЙ?
        public Staff()
        {
            Appointments = new List<Appointment>();
            Schedules = new List<Schedule>();
            MessageBoards = new List<MessageBoard>();
        }

        private static int _length=30;
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

        [Column(TypeName ="datetime2")]
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

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (Regex.IsMatch(value, @"[0-9]{11}", RegexOptions.IgnoreCase)==false)
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
                    RegexOptions.IgnoreCase)==false)
                {
                    throw new ArgumentException("Email имеет неверный формат.");
                }
                _email = value;
            }
        }

        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                //Проверить робит ли
                if (Regex.IsMatch(value, @"^(?=\w{6,10}\z)(?=[^a-z]*[a-z])(?=(?:[^A-Z]*[A-Z]){1})(?=\D*\d)") == false)
                {
                    throw new ArgumentException("Логин имеет неверный формат.");
                }
                _login = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (Regex.IsMatch(value, @"^(?=\w{6,10}\z)(?=[^a-z]*[a-z])(?=(?:[^A-Z]*[A-Z]){1})(?=\D*\d)") == false)
                {
                    throw new ArgumentException("Пароль имеет неверный формат.");
                }
                _password = value;
            }
        }

        public AccessType Access
        {
            get
            {
                return _access;
            }
            set
            {
                _access = value;
            }
        }

        public string Qualification
        {
            get
            {
                return _qualification;
            }
            set
            {
                _qualification = value;
            }
        }

        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        public string Speciality
        {
            get
            {
                return _speciality;
            }
            set
            {
                _speciality = value;
            }
        }

        [Column(TypeName = "datetime2")]
        public DateTime DateOfEmployment
        {
            get
            {
                return _dateOfEmployment;
            }
            set
            {
                _dateOfEmployment = value;
            }
        }



    }
}
