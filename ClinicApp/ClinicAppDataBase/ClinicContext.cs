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
        public DbSet<MessageBoard> MessageBoards { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Receipt> Receipts { get; set; }

        static ClinicContext()
        {
            Database.SetInitializer<ClinicContext>(new ClinicContextInitializer());
        }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           //modelBuilder.Entity<Receipt>().HasRequired(a => a.Appointment).WithRequiredDependent(a => a.Receipt);
           //modelBuilder.Entity<Receipt>().HasRequired(a => a.Appointment).WithRequiredPrincipal();
           //modelBuilder.Entity<Appointment>().HasRequired(a => a.Receipt).WithRequiredPrincipal();
           //modelBuilder.Entity<Appointment>().HasRequired(a=>a.Receipt).WithRequiredDependent();
           // modelBuilder.Entity<Appointment>().HasIndex(a => new { a.Id }).IsUnique(true);

        }

        //protected void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Schedule>().HasIndex(s => new {s.DateOfSchedule}).IsUnique(true);
        //}
    }
}
