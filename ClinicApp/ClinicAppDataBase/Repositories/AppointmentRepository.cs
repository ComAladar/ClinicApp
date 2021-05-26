using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using ClinicAppDataBase.Entities;

namespace ClinicAppDataBase.Repositories
{
    public class AppointmentRepository
    {
        private readonly Context _db;

        public AppointmentRepository(Context context)
        {
            _db = context;
        }

        public void GetAppointment(Appointment appointment)
        {

        }

        public void GetAppointmentList(Appointment appointment)
        {

        }

        public void AddAppointment(Appointment appointment)
        {

        }

        public void DeleteAppointment(Appointment appointment)
        {

        }

        public void EditAppointment(Appointment appointment)
        {

        }
    }
}
