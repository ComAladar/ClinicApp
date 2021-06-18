using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppDataBase.Entities
{
    /// <summary>
    /// Класс доски для обьявлений.
    /// </summary>
    public class MessageBoard
    {
        /// <summary>
        /// Поле для хранения названия сообщения.
        /// </summary>
        private string _name;
        /// <summary>
        /// Поле для хранения текста сообщения.
        /// </summary>
        private string _message;

        //СВЯЗЬ STAFF--->MESSAGEBOARD 1 К МНОГИМ
        public int? StaffId { get; set; }
        public Staff Staff { get; set; }

        /// <summary>
        /// Свойство хранящее уникальный номер сообщения.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Свойство хранящее тему сообщения.
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
                        "Поле заполнено неверно.");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Свойство хранящее текст сообщения.
        /// </summary>
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

        /// <summary>
        /// Свойство хранящее дату отправки сообщения.
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime DateOfMessage { get; set; }
    }
}
