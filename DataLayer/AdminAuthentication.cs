using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AdminAuthentication
    {
        public static string getPassword(string adminId)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();

            Admin admin = db.Admins.First(i => i.AdminID.Equals(adminId));

            return admin.Password;
        }

        public static void setPassword(string adminId, string password)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            Admin admin = db.Admins.First(i => i.AdminID.Equals(adminId));

            admin.Password = password;
            db.SaveChanges();
        }

        public static Admin getAdmin(string adminId)
        {
            CUOnlineDatabaseEntities db = new CUOnlineDatabaseEntities();
            Admin admin = db.Admins.First(i => i.AdminID.Equals(adminId));

            return admin;
        }
    }
}
