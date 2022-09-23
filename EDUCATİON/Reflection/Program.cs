using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortıslem = new DortIslem(2, 3);   A
            //Console.WriteLine(dortıslem.Topla(5,10));   B
            //Console.WriteLine(dortıslem.Topla2());      C

            var type = typeof(DortIslem);

            DortIslem dortıslem=(DortIslem)Activator.CreateInstance(type,6,7); // A ile aynı şey demek bu. Fakat
                                                                // reflection maliyetlidir, zorunda değilsen kullanma
            Console.WriteLine(dortıslem.Topla(2, 3));
            Console.WriteLine(dortıslem.Topla2());

            Console.WriteLine();

            var ınstance= Activator.CreateInstance(type,10,21); // A ile aynı , oluşturdu nesneyi 

            MethodInfo methodInfo = ınstance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(ınstance, null));
            // Invoke(ınstance, null) , hangi örneğin çalıştıryaım demek yani, burda da ınstance çalıstır dıyo

            Console.WriteLine("--------");

            var metodlar = type.GetMethods();
            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod: {0} ", info.Name); // DortIslem içindeki metodları sıraladı
                foreach (var param in info.GetParameters())
                {
                    Console.WriteLine("Parametre: {0}", param.Name); // DortIslem içindeki metodların parametrelerini sıraladı
                }
                foreach (var attrıbute in info.GetCustomAttributes()) // AttributeS yapınca butun hepsine bakar att. olanların
                                                                        // Attribute(" ") yazsaydım içine olan att. ismini isterdi
                {
                    Console.WriteLine("Attırubte: {0}", attrıbute.GetType().Name); // varsa attrıbuteleri gösterir
                }
            }
            // GetMethod , aranan metodu bulur
            // Invoke de o metodu çalıştırır
            


            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _sayı1;
        private int _sayı2;

        public DortIslem(int sayı1,int sayı2)
        {
            _sayı1 = sayı1;
            _sayı2 = sayı2;
        }

        public int Topla(int sayı1,int sayı2)
        {
            return sayı1 + sayı2;
        }
        public int Carp(int sayı1, int sayı2)
        {
            return sayı1 * sayı2;
        }
        [MethodAttrıbute("Carpma")]
        public int Topla2()
        {
            return _sayı1 + _sayı2;
        }
        public int Carp2()
        {
            return _sayı1 * _sayı2;
        }
    }

    public class MethodAttrıbute:Attribute
    {
        public MethodAttrıbute(string name)
        {

        }
    }
}
