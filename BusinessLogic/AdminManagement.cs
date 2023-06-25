using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLogic
{
    public class AdminManagement
    {
        public static string getPassword(string id)
        {
            return AdminAuthentication.getPassword(id);
        }

        public static void setPassword(string id, string password)
        {
            AdminAuthentication.setPassword(id, password);
        }
    }
}
