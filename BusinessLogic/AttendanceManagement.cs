using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLogic
{
    public class AttendanceManagement
    {
        public static void addAttendance(string regNum, string title, string date, string course, bool status)
        {
            Attendance o = new Attendance();

            o.StudentID = regNum;
            o.CourseID = course;
            o.Title = title;
            o.Status = status;

            //CrudAttendance.addAttendance(o);
        }

        public static void getAttendence()
        {

        }
    }
}
