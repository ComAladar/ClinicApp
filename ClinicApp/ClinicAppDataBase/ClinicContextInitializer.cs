using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClinicAppDataBase.Entities;

namespace ClinicAppDataBase
{
    public class ClinicContextInitializer:CreateDatabaseIfNotExists<ClinicContext>
    {
        protected override void Seed(ClinicContext db)
        {
            Staff adminStaff = new Staff();
            db.Staffs.Add(adminStaff);
            db.SaveChanges();
        }
    }
}
