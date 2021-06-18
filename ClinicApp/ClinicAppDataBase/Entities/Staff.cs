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
    /// <summary>
    /// Класс для данных персонала.
    /// </summary>
    public class Staff
    {
        /// <summary>
        /// Поле для хранения имени персонала.
        /// </summary>
        private string _name;
        /// <summary>
        /// Поле для хранение фамилии персонала.
        /// </summary>
        private string _surname;
        /// <summary>
        /// Поле для хранения отчества персонала.
        /// </summary>
        private string _patronymic;
        /// <summary>
        /// Поле для хранения даты рождения персонала.
        /// </summary>
        private DateTime _dateOfBirth=DateTime.Now;
        /// <summary>
        /// Поле для хранения номера телефона персонала.
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Поле для хранения электронной почты персонала.
        /// </summary>
        private string _email;
        /// <summary>
        /// Поле для хранения логина входа в систему персонала.
        /// </summary>
        private string _login;
        /// <summary>
        /// Поле для хранения пароля входа в систему персонала.
        /// </summary>
        private string _password;
        /// <summary>
        /// Поле для определения максимальной длинны имя, фамилии и отчества.
        /// </summary>
        private static int _length = 30;

        //СВЯЗЬ STAFF--->APPOINTMENT 1 К МНОГИМ
        public ICollection<Appointment> Appointments { get; set; }


        //СВЯЗЬ STAFF--->MESSAGEBOARD 1 К МНОГИМ
        public ICollection<MessageBoard> MessageBoards { get; set; }


        //Связь Staff ----> Receipt 1 к МНОГИМ
        public ICollection<Receipt> Receipts { get; set; }

        /// <summary>
        /// Свойство хранящее уникальный номер персонала.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Свойство хранящее имя персонала.
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
        /// Свойство хранящее фамилию персонала.
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
        /// Свойство хранящее отчество персонала.
        /// </summary>
        public string Patronymic
        {
            get
            {
                return _patronymic;
            }
            set
            {
                if (value.Length > _length && value != null)
                {
                    throw new ArgumentException("Максимальная длина отчества не должна быть больше " + _length + " символов.");
                }
                _patronymic = value;
            }
        }

        //https://en.wikipedia.org/wiki/ISO/IEC_5218 0-Неизвестно; 1-Мужчина 2-Женщина
        /// <summary>
        /// Свойство хранящее пол персонала.
        /// </summary>
        public SexType Sex { get; set; }

        /// <summary>
        /// Свойство хранящее дату рождения персонала.
        /// </summary>
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

        /// <summary>
        /// Свойство хранящее телефонный номер персонала.
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime DateOfRegistration { get; set; } = DateTime.Now;

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (Regex.IsMatch(value, @"[0-9]{10}", RegexOptions.IgnoreCase)==false)
                {
                    throw new ArgumentException("Номер телефона был задан неверно.");
                }
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Свойство хранящее адрес электронной почты персонала.
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
                    RegexOptions.IgnoreCase)==false)
                {
                    throw new ArgumentException("Email имеет неверный формат.");
                }
                _email = value;
            }
        }

        /// <summary>
        /// Свойство хранящее логин для входа в систему персонала.
        /// </summary>
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                if (Regex.IsMatch(value, @"^(?=.{5,10}$)(?=[a-zA-Z]){5}(?=[^0-9])") == false)
                {
                    throw new ArgumentException("Логин имеет неверный формат.");
                }
                _login = value;
            }
        }

        /// <summary>
        /// Свойство хранящее пароль для входа в систему персонала.
        /// </summary>
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (Regex.IsMatch(value, @"^(?=.{5,10}$)(?=[a-zA-Z]){5}(?=[^0-9])") == false)
                {
                    throw new ArgumentException("Пароль имеет неверный формат.");
                }
                _password = value;
            }
        }

        /// <summary>
        /// Свойство хранящее права доступа персонала.
        /// </summary>
        public AccessType Access { get; set; }

        /// <summary>
        /// Свойство хранящее квалификацию персонала.
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// Свойство хранящее должность персонала.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Свойство хранящее специальность персонала.
        /// </summary>
        public string Speciality { get; set; }

        /// <summary>
        /// Свойство хранящее дату трудоустройства персонала.
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime DateOfEmployment { get; set; } = DateTime.Now;

        /// <summary>
        /// Свойство хранящее состояние редактирования данных персонала.
        /// </summary>
        public InUseType InUse { get; set; }

        /// <summary>
        /// Конструктор персонала для инициализации связей.
        /// </summary>
        public Staff()
        {
            Appointments = new List<Appointment>();
            MessageBoards = new List<MessageBoard>();
            Receipts = new List<Receipt>();
        }

    }
}
