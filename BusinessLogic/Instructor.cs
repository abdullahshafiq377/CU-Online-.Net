using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal class Instructor
    {
        private string Id, name, fatherName, gender, email, nationality, contactNo, password;
        private string DOB;

        public Instructor(string id, string name, string fatherName, string gender, string email, string nationality, string contactNo, string password, string dOB)
        {
            Id = id;
            this.name = name;
            this.fatherName = fatherName;
            this.gender = gender;
            this.email = email;
            this.nationality = nationality;
            this.contactNo = contactNo;
            this.password = password;
            DOB = dOB;
        }
    }
}
