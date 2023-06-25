using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLogic
{
    public class StudentManagement
    {
        static string _defaultPassword = "cui123";

        public static bool addStudent(string session, string year, string rollNum, string name, string fatherName,
            string program, string dob, string gender, string email, string contact, string nationality)
        {
            Student student = new Student();

            student.StudentID = session + year + "-" + program + "-" + rollNum;
            student.Password = _defaultPassword;
            student.Batch = session + year;
            student.Name = name;
            student.FatherName = fatherName;
            student.Program = program;
            student.DOB = DateTime.Parse(dob);
            student.Gender = gender;
            student.Email = email;
            student.ContactNo = contact;
            student.Nationality = nationality;

            return CrudStudent.addStudent(student);

        }

        public static void updateStudent(string session, string year, string rollNum, string name, string fatherName,
            string program, string dob, string gender, string email, string contact, string nationality, string regNum)
        {
            Student student = new Student();
            student.StudentID = session + year + "-" + program + "-" + rollNum;
            student.Password = _defaultPassword;
            student.Batch = session + year;
            student.Name = name;
            student.FatherName = fatherName;
            student.Program = program;
            student.DOB = DateTime.Parse(dob);
            student.Gender = gender;
            student.Email = email;
            student.ContactNo = contact;
            student.Nationality = nationality;

            CrudStudent.updateStudent(regNum, student);
        }

        public static void updateStudent(string regNum, string email, string contact)
        {
            Student student = CrudStudent.searchStudent(regNum);
            
            student.Email = email;
            student.ContactNo = contact;

            CrudStudent.updateStudent(regNum, student);
        }

        public static Student searchStudent(string session, string year, string program, string rollNum)
        {
            string regNum = session + year + "-" + program + "-" + rollNum;
            return CrudStudent.searchStudent(regNum);
        }

        public static Student searchStudent(string regNum)
        {
            return CrudStudent.searchStudent(regNum);
        }

        public static bool removeStudent(string regNum)
        {
            CrudStudent.removeStudent(regNum);
            return true;
        }

        public static bool resetStudentPassword(string session, string year, string program, string rollNum)
        {
            string regNum = session + year + "-" + program + "-" + rollNum;
            CrudStudent.setStudentPassword(regNum, _defaultPassword);
            return true;
        }

        public static string getPassword(string regNum)
        {
            return CrudStudent.getStudentPassword(regNum);
        }

        public static void setPassword(string regNum, string password)
        {
            CrudStudent.setStudentPassword(regNum, password);
        }

    }
}
