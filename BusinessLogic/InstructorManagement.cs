using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLogic
{
    public class InstructorManagement
    {
        static string _defaultPassword = "cui123";

        public static bool addInstructor(string instructorId, string name, string fatherName, string dob,
            string gender, string email, string contactNo, string nationality)
        {
            Instructor instructor = new Instructor();

            instructor.InstructorID = instructorId;
            instructor.Password = _defaultPassword;
            instructor.Name = name;
            instructor.FatherName = fatherName;
            instructor.DOB = DateTime.Parse(dob);
            instructor.Gender = gender;
            instructor.Email = email;
            instructor.ContactNo = contactNo;
            instructor.Nationality = nationality;

            return CrudInstructor.addInstructor(instructor);
        }

        public static void updateInstructor(string instructorId, string name, string fatherName, string dob,
            string gender, string email, string contactNo, string nationality)
        {
            Instructor instructor = new Instructor();

            instructor.InstructorID = instructorId;
            instructor.Password = _defaultPassword;
            instructor.Name = name;
            instructor.FatherName = fatherName;
            instructor.DOB = DateTime.Parse(dob);
            instructor.Gender = gender;
            instructor.Email = email;
            instructor.ContactNo = contactNo;
            instructor.Nationality = nationality;

            CrudInstructor.updateInstructor(instructorId, instructor);
        }
        public static void updateInstructor(string instructorID, string email, string contact)
        {
            Instructor instructor = CrudInstructor.searchInstructor(instructorID);

            instructor.Email = email;
            instructor.ContactNo = contact;

            CrudInstructor.updateInstructor(instructorID, instructor);
        }

        public static IEnumerable getInstructorIDs()
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();

            var x = from i in db.Instructors
                    select
                        i.InstructorID;

            return x.ToList();
        }

        public static Instructor searchInstructor(string instructorId)
        {
            return CrudInstructor.searchInstructor(instructorId);
        }

        public static bool removeInstructor(string instructorId)
        {
            CrudInstructor.removeInstructor(instructorId);
            return true;
        }

        public static bool resetInstructorPassword(string instructorId)
        {
            CrudInstructor.setInstructorPassword(instructorId, _defaultPassword);
            return true;
        }

        public static string getPassword(string instructorID)
        {
            return CrudInstructor.getInstructorPassword(instructorID);
        }

        public static void setPassword(string InstructorID, string password)
        {
            CrudInstructor.setInstructorPassword(InstructorID, password);
        }
    }
}
