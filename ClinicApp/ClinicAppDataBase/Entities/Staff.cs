using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicAppBusinessLogic;

namespace ClinicAppDataBase.Entities
{
    public class Staff
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _patronymic;
        private byte _sex; //https://en.wikipedia.org/wiki/ISO/IEC_5218 0-Неизвестно; 1-Мужчина 2-Женщина
        private DateTime _dateOfBirth;
        private DateTime _dateOfRegistration = DateTime.Now;
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
                _patronymic = value;
            }
        }

        private byte Sex
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

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
            }
        }

        public DateTime DateOfRegistration
        {
            get
            {
                return _dateOfRegistration;
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
                _email = value;
            }
        }

        //private string _login;
        //private string _password;
        //private string _access;
        //private string _qualification;
        //private string _position;
        //private string _speciality;
        //private DateTime _dateOfEmployment;

        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
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
