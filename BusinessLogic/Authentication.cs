using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLogic
{
    public class Authentication
    {
        public static Student authenticateStudent(string id, string password)
        {
            var student = CrudStudent.searchStudent(id);

            if (student != null && student.Password.Trim().Equals(password))
            {
                return student;
            }
            return null;
        }

        public static Admin authenticateAdmin(string id, string password)
        {
            var admin = AdminAuthentication.getAdmin(id);

            if (admin != null && admin.Password.Trim().Equals(password))
            {
                return admin;
            }
            return null;
        }

        public static Instructor authenticateInstructor(string id, string password)
        {
            var instructor = CrudInstructor.searchInstructor(id);

            if (instructor != null && instructor.Password.Trim().Equals(password))
            {
                return instructor;
            }
            return null;
        }
    }
}
