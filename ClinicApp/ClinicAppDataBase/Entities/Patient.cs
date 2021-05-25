using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppDataBase.Entities
{
    public class Patient
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _patronymic;
        private byte _sex; //https://en.wikipedia.org/wiki/ISO/IEC_5218 0-Неизвестно; 1-Мужчина 2-Женщина
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
