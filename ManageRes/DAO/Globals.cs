using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRes
{
    class Globals
    {
        public static int GlobalsUserID { get; private set; }

        public static void SetGlobalUserID(int userID)
        {
            GlobalsUserID = userID;
        }
    }
}
