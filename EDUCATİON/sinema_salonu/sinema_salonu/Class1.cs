using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinema_salonu
{
    internal class parametre
    {
        private static string film;

        public static void set(string x)
        {
            film = x;
        }
        public static string get()
        {
            return film;
        }
    }
}
