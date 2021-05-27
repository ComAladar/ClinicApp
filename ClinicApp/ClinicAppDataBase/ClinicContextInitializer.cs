using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClinicAppBusinessLogic;
using ClinicAppBusinessLogic.Enumerations;
using ClinicAppDataBase.Entities;

namespace ClinicAppDataBase
{
    public class ClinicContextInitializer:CreateDatabaseIfNotExists<ClinicContext>
    {
        protected override void Seed(ClinicContext db)
        {
            Staff adminStaff = new Staff{Access =(AccessType) 0,Name = "Администратор",Login = "admin",Password = "admin"};
            db.Staffs.Add(adminStaff);
            db.SaveChanges();
        }
    }
}
