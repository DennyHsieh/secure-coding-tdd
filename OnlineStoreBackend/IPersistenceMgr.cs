using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreBackend
{
    public interface IPersistenceMgr
    {
        bool UsernameExists(string username);
    }
}
