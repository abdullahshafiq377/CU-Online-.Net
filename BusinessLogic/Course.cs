using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal class Course
    {
        private string ID, name, description;

        public Course(string iD, string name, string description)
        {
            ID = iD;
            this.name = name;
            this.description = description;
        }
    }
}
