using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLogic
{
    public class AssignmentManagement
    {
        public static void addAssignment(string title, string course, string startDate, string endDate, string totalMarks, string instructions)
        {
            Assignment o = new Assignment();

            o.Title = title;
            o.CourseID = course.Remove(6);
            o.StartTime = DateTime.Parse(startDate);
            o.EndTime = DateTime.Parse(endDate);
            o.TotalMarks = int.Parse(totalMarks);
            o.Discription = instructions;

            CRUDAssignment.addAssignment(o);
        }

        public static IEnumerable getAssignments(string courseID)
        {
            return CRUDAssignment.getAssignment(courseID);
        }
    }
}
