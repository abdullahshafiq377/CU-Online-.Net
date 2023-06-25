using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLogic
{
    public class LearningResourcesManagement
    {
        public static void addLearningResource(string title, string course)
        {
            string courseCode = course.Remove(6);
            CourseData o = new CourseData();
            o.CourseID = courseCode;
            o.Title = title;
            
            CrudLearningResources.addLearningResource(o);
        }

        public static IEnumerable getLearningResources(string courseID)
        {
            string courseCode = courseID;
            return CrudLearningResources.getLearningResources(courseCode);
        }
    }
}
