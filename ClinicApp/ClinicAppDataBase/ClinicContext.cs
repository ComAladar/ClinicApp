using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClinicAppDataBase.Entities;

namespace ClinicAppDataBase
{
    /// <summary>
    /// Класс контекста базы данных.
    /// </summary>
    public class ClinicContext : DbContext
    {
        /// <summary>
        /// Стандартный конструктор с подключением к БД по строке соединения.
        /// </summary>
        public ClinicContext() : base("DbConnection") { }

        /// <summary>
        /// Свойство для создания таблицы приемов.
        /// </summary>
        public DbSet<Appointment> Appointments { get; set; }
        /// <summary>
        /// Свойство для создания таблицы пациентов.
        /// </summary>
        public DbSet<Patient> Patients { get; set; }
        /// <summary>
        /// Свойство для создания таблицы доски для обьявлений.
        /// </summary>
        public DbSet<MessageBoard> MessageBoards { get; set; }
        /// <summary>
        /// Свойство для создания табилцы персонала.
        /// </summary>
        public DbSet<Staff> Staffs { get; set; }
        /// <summary>
        /// Свойство для создания таблицы чеков.
        /// </summary>
        public DbSet<Receipt> Receipts { get; set; }

        /// <summary>
        /// Статичное задание инициализатора контекста БД.
        /// </summary>
        static ClinicContext()
        {
            Database.SetInitializer<ClinicContext>(new ClinicContextInitializer());
        }

        /// <summary>
        /// Метод вызывающийся при создании БД.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
