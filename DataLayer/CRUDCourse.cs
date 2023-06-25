using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CrudCourse
    {
        public static bool addCourse(Course course)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            var x = db.Courses.Add(course);
            db.SaveChanges();

            if (x != null)
                return true;
            else
                return false;
        }

        public static Course searchCourse(string courseCode)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            var course = db.Courses.First(i => i.CourseCode.Equals(courseCode));
            return course;
        }

        public static bool updateCourse(string courseCode, Course c)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            var course = db.Courses.First(i => i.CourseCode.Equals(courseCode));

            course.Title = c.Title;
            course.Description = c.Description;
            course.CreditHours = c.CreditHours;

            db.SaveChanges();
            return true;
        }

        public static bool removeCourse(string courseCode)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            try
            {
                var c = db.Courses.Find(courseCode);
                db.Courses.Remove(c);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static IEnumerable getCourseNames()
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();

            var x = from c in db.Courses
                    select
                        c.CourseCode + "-" + c.Title;


            return x.ToList();
        }

        public static void RegisterCourse(string courseID, string studentId)
        {
            var db = new CUOnlineDatabaseEntities();
            var count = db.Registrations.Count() + 1;
            var x = new Registration()
            {
                RegistrationID = count,
                CourseID = courseID,
                StudentID = studentId
            };
            db.Registrations.Add(x);
            db.SaveChanges();
        }

        public static IEnumerable GetRegistrations(
            string id)
        {
            var db = new CUOnlineDatabaseEntities();
            var x = from r in db.Registrations
                    join c in db.Courses on r.CourseID equals c.CourseCode
                    join ac in db.AssignedCourses on r.CourseID equals ac.CourseID
                    join i in db.Instructors on ac.InstructorID equals i.InstructorID 
                    where r.StudentID == id
                    select new
                    {
                        c.Title,
                        c.CourseCode,
                        c.CreditHours,
                        i.Name
                    };
            return x.ToList();
        }

        public static int GetNumofRegistrations(
            string id)
        {
            var db = new CUOnlineDatabaseEntities();
            var x = from r in db.Registrations
                    join c in db.Courses on r.CourseID equals c.CourseCode
                    where r.StudentID == id
                    select new
                    {
                        c.Title
                    };
            return x.ToList().Count;
        }

        public static void assignCourse(string courseID, string instructorID)
        {
            var db = new CUOnlineDatabaseEntities();
            var count = db.AssignedCourses.Count() + 1;
            var x = new AssignedCours()
            {
                Id = count,
                CourseID = courseID,
                InstructorID = instructorID
            };
            db.AssignedCourses.Add(x);
            db.SaveChanges();
        }

        public static IEnumerable getAssignedCourses(string id)
        {
            var db = new CUOnlineDatabaseEntities();
            var x = from r in db.AssignedCourses
                join c in db.Courses on r.CourseID equals c.CourseCode
                where r.InstructorID == id
                select new
                {
                    c.Title,
                    c.CourseCode,
                    c.CreditHours
                };
            return x.ToList();
        }

        public static IEnumerable getAssignedCoursesNames(string id)
        {
            var db = new CUOnlineDatabaseEntities();
            var x = from r in db.AssignedCourses
                join c in db.Courses on r.CourseID equals c.CourseCode
                where r.InstructorID == id
                select
                    c.CourseCode + "-" +  c.Title;
            return x.ToList();
        }

        public static IEnumerable getAllAssignedCourses()
        {
            var db = new CUOnlineDatabaseEntities();
            var x = from ac in db.AssignedCourses
                join c in db.Courses on ac.CourseID equals c.CourseCode
                join i in db.Instructors on ac.InstructorID equals i.InstructorID
                select new
                {
                    c.Title,
                    c.CourseCode,
                    c.CreditHours,
                    i.Name
                };
            return x.ToList();
        }

        public static void addMarks(Result o)
        {
            var db = new CUOnlineDatabaseEntities();
            var count = db.Results.Count() + 1;
            o.ID = count;
            db.Results.Add(o);
            db.SaveChanges();
        }

        public static IEnumerable getMarks(string courseCode, string stdID)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();

            var x = from r in db.Results
                join c in db.Courses on r.CourseID equals c.CourseCode
                join ac in db.AssignedCourses on r.CourseID equals ac.CourseID
                where (r.CourseID.Equals(courseCode) && r.RegistrationID.Equals(stdID))
                select new
                {
                    r.Title,
                    r.TotalMarks,
                    r.MarksObtained
                };
            return x.ToList();
        }
    }
}