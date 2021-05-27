using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClinicAppDataBase.Entities;

namespace ClinicAppDataBase
{
    public class ClinicContext : DbContext
    {
        public ClinicContext() : base("DbConnection") { }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<MessageBoard> MessageBoards { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        static ClinicContext()
        {
            Database.SetInitializer<ClinicContext>(new ClinicContextInitializer());
        }
    }
}
