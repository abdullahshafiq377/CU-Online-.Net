using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Student
    {
        private string regNo, name, fatherName, gender, email, password, nationality, contactNo;
        private string DOB;

        public Student(string regNo, string name, string fatherName, string gender, string email, string password, string nationality, string contactNo, string dOB)
        {
            this.regNo = regNo;
            this.name = name;
            this.fatherName = fatherName;
            this.gender = gender;
            this.email = email;
            this.password = password;
            this.nationality = nationality;
            this.contactNo = contactNo;
            DOB = dOB;
        }
    }
}
