using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CrudInstructor
    {
        public static bool addInstructor(Instructor instructor)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            var x =db.Instructors.Add(instructor);
            db.SaveChanges(); 
            if (x != null)
                return true;
            else
                return false;
        }

        public static Instructor searchInstructor(string instructorId)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            Instructor instructor = db.Instructors.First(i => i.InstructorID.Equals(instructorId));

            return instructor;
        }

        public static bool updateInstructor(string instructorId, Instructor o)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            Instructor instructor = db.Instructors.First(i => i.InstructorID.Equals(instructorId));

            instructor.Name = o.Name;
            instructor.FatherName = o.FatherName;
            instructor.DOB = o.DOB;
            instructor.Gender = o.Gender;
            instructor.Email = o.Email;
            instructor.ContactNo = o.ContactNo;
            instructor.Nationality = o.Nationality;

            db.SaveChanges();
            return true;
        }

        public static bool removeInstructor(string instructorId)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();

            var i = db.Instructors.Find(instructorId);
            db.Instructors.Remove(i);
            db.SaveChanges();

            return true;

        }

        public static string getInstructorPassword(string instructorId)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            Instructor instructor = db.Instructors.First(i => i.InstructorID.Equals(instructorId));

            return instructor.Password;
        }

        public static bool setInstructorPassword(string instructorId, string password)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            Instructor instructor = db.Instructors.First(i => i.InstructorID.Equals(instructorId));

            instructor.Password = password;
            db.SaveChanges();
            return true;
        }
    }
}
