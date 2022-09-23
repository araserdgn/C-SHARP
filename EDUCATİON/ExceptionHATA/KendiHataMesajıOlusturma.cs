using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHATA
{
    public class KendiHataMesajıOlusturma:Exception
    {
        public KendiHataMesajıOlusturma(string message):base(message)
        {

        }

    }
}
