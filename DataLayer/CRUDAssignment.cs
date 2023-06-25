using System;
using System.Collections;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CRUDAssignment
    {
        public static void addAssignment(Assignment o)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            var count = db.Assignments.Count() + 1;

            o.ID = count;
            db.Assignments.Add(o);
            db.SaveChanges();
        }

        public static IEnumerable getAssignment(string courseCode)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            var x = from a in db.Assignments
                where a.CourseID == courseCode
                select new
                {
                    a.Title,
                    a.StartTime,
                    a.EndTime,
                    a.TotalMarks
                };
            return x.ToList();
        }
    }
}
