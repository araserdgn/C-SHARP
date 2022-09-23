using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartı
{
    internal class Parametre
    {
        private static object[] argumans=null;

        public static void Set(object[] arg)
        {
            argumans=arg;
        }

        public static object[] Get()
        {
            return argumans;
        }
    }
}
