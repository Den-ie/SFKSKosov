using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFKSKosov
{
    class Vault
    {
        static int _loguser = -1;

        static int _logadmin = -1;

        public Vault()
        {
        }

        public static int LogUser
        {
            get { return _loguser; } set { _loguser = value; }
        }
        
        public static int LogAdmin
        {
            get { return _logadmin; } set { _logadmin = value; }
        }
    }
}
