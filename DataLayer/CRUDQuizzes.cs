using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CRUDQuizzes
    {
        public static void addQuiz(Quiz o)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            var count = db.Quizs.Count() + 1;

            o.ID = count;
            db.Quizs.Add(o);
            db.SaveChanges();
        }

        public static IEnumerable getQuiz(string courseCode)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            var x = from a in db.Quizs
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
