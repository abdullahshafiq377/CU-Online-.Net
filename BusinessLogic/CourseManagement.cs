using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLogic
{
    public class CourseManagement
    {
        public static bool addCourse(string courseCode, string title, string description, string creditHours)
        {
            Course course = new Course();

            course.CourseCode = courseCode;
            course.Title = title;
            course.Description = description;
            course.CreditHours = Int32.Parse(creditHours);

            return CrudCourse.addCourse(course);
        }

        public static void updateCourse(string courseCode, string title, string description, string creditHours)
        {
            Course course = new Course();

            course.Title = title;
            course.Description = description;
            course.CreditHours = Int32.Parse(creditHours);

            CrudCourse.updateCourse(courseCode, course);
        }

        public static Course searchCourse(string courseCode)
        {
            return CrudCourse.searchCourse(courseCode);
        }

        public static void removeCourse(string courseCode)
        {
            CrudCourse.removeCourse(courseCode);
        }

        public static IEnumerable getCourseNames()
        {
            return CrudCourse.getCourseNames();
        }

        public static void RegisterCourse(string session,string year,string program, string rollNum, string course)
        {
            var studentId = session + year + "-" + program + "-" + rollNum;
            string courseID = course.Remove(6);
            CrudCourse.RegisterCourse(courseID, studentId);
        }

        public static IEnumerable GetRegistrations(string id)
        {
            return CrudCourse.GetRegistrations(id);
        }
        
        public static int GetNumofRegistrations(string id)
        {
            return CrudCourse.GetNumofRegistrations(id);
        }

        public static void assignCourse(string instructorID, string course)
        {
            string courseID = course.Remove(6);
            CrudCourse.assignCourse(courseID, instructorID);
        }

        public static IEnumerable getAssignedCourses(string id)
        {
            return CrudCourse.getAssignedCourses(id);
        }

        public static IEnumerable getAssignedCoursesNames(string id)
        {
            return CrudCourse.getAssignedCoursesNames(id);
        }

        public static IEnumerable getAllAssignedCourses()
        {
            return CrudCourse.getAllAssignedCourses();
        }

        public static void addMarks(string regNum, string courseCode, string title, string totalMarks,
            string obtainedMarks)
        {
            Result result = new Result
            {
                RegistrationID = regNum,
                CourseID = courseCode,
                Title = title,
                TotalMarks = int.Parse(totalMarks),
                MarksObtained = int.Parse(obtainedMarks)
            };
            CrudCourse.addMarks(result);
        }

        public static IEnumerable getMarks(string courseCode, string stdID)
        {
            return CrudCourse.getMarks(courseCode, stdID);
        }
    }

}
