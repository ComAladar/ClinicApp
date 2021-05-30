using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppDataBase.Entities
{
    public class MessageBoard
    {
        private int _id;
        private DateTime _dateOfMessage=DateTime.Now;
        private string _name;
        private string _message;

        //СВЯЗЬ STAFF--->MESSAGEBOARD 1 К МНОГИМ
        public int? StaffId { get; set; }
        public Staff Staff { get; set; }
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
                        "Поле заполнено неверно.");
                }
                _name = value;
            }
        }

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "Поле заполнено неверно.");
                }
                _message = value;
            }
        }

        [Column(TypeName = "datetime2")]
        public DateTime DateOfMessage
        {
            get
            {
                return _dateOfMessage;
            }
            set
            {
                _dateOfMessage = value;
            }
        }


    }
}
