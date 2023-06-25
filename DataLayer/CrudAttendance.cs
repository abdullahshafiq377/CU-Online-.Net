using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CrudAttendance
    {
        public static void addAttendance(Attendance attendance)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            db.Attendances.Add(attendance);
            db.SaveChanges();
        }

        public static void removeAttendance(int id)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            var x = db.Attendances.Find(id);
            db.Attendances.Remove(x);
            db.SaveChanges();
        }
    }
}
