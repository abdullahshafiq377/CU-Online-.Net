using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CrudStudent
    {
        public static bool addStudent(Student student)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            var x = db.Students.Add(student);
            db.SaveChanges();

            if (x != null)
                return true;
            else
                return false;
        }

        public static Student searchStudent(string regNum)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            Student student = db.Students.First(i => i.StudentID.Equals(regNum));
            return student;
        }

        public static bool updateStudent(string regNo, Student s)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            Student student = db.Students.First(i => i.StudentID.Equals(regNo));

            student.Batch = s.Batch;
            student.Name = s.Name;
            student.FatherName = s.FatherName;
            student.Program = s.Program;
            student.DOB = s.DOB;
            student.Gender = s.Gender;
            student.Email = s.Email;
            student.ContactNo = s.ContactNo;
            student.Nationality = s.Nationality;

            db.SaveChanges();
            return true;
        }

        public static bool removeStudent(string regNum)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            try
            {
                var s = db.Students.Find(regNum);
                db.Students.Remove(s);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string getStudentPassword(string regNum)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            Student student = db.Students.First(i => i.StudentID.Equals(regNum));

            return student.Password;
        }
        public static void setStudentPassword(string regNum, string password)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            Student student = db.Students.First(i => i.StudentID.Equals(regNum));

            student.Password = password;
            db.SaveChanges();
        }
    }
}
