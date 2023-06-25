using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CrudLearningResources
    {
        public static void addLearningResource(CourseData o)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            var count = db.CourseDatas.Count() + 1;

            o.ID = count;
            db.CourseDatas.Add(o);
            db.SaveChanges();
        }

        public static IEnumerable getLearningResources(string courseCode)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            var x = from a in db.CourseDatas
                where a.CourseID == courseCode
                select new
                {
                    a.Title,
                };
            return x.ToList();
        }
    }
}
