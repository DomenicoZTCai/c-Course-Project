using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier2015.UserManager
{
    public class User
    {
        string account;
        string roleName;
        public User(string account, string roleName)
        {
            this.account = account;
            this.roleName = roleName;
        }
        public string getAccount()
        {
            return account;
        }
        public bool isRole(string roleName)
        {
            return this.roleName == roleName;
        }
    }
}
