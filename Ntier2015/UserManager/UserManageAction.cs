using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier2015.UserManager
{
    public class UserManageAction:DAL.OleDbConn
    {
        public static User validUser(string account, string password)
        {
            string sql = "select * from Account where accountId='" +
                account + "' and password ='" +
                password + "'";
            object o=executeScalar(sql);
            if (o == null) return null;
            sql = "select roleName from AccountRole ar, Role r " +
                " where ar.roleId = r.roleId " +
                " and accountId = '" + account + "'";
            o = executeScalar(sql);
            if (o == null) return null;
            string role = (string)o;
            User user = new User(account, role);
            return user;
        }
    }
}
