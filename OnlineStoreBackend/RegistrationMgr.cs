using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OnlineStoreBackend
{
    public class RegistrationMgr
    {
        public RegistrationMgr(IPersistenceMgr persistenceMgr)
        {

        }

        public RegistrationMgr()
        {

        }
        public bool IsValidUsername(string username)
        {
            // Length must between [3, 10]
            if (username.Length < 3 || username.Length >10)
            {
                return false;
            }

            // Chars must be alphanumeric
            Regex r = new Regex("^[a-zA-Z0-9]+$");
            if (!r.IsMatch(username))
            {
                return false;
            }
            return true;
        }
    }
}
