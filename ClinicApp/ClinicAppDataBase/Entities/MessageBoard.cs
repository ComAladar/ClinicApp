using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppDataBase.Entities
{
    public class MessageBoard
    {
        private int _id;
        private DateTime _dateOfMessage;
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

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
            }
        }


    }
}
