using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainnig3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building(2,250,4);
            Building office = new Building(2, 250, 4);

            Console.WriteLine("Her kişi için en az "+30+" Metre kare alan lazımsa EV için mak. insan: "+house.MaxOccupant(30));
            Console.WriteLine("Her kişi için en az " + 30 + " Metre kare alan lazımsa OFFİCE için mak. insan: " + house.MaxOccupant(30));
            house.Check(30);
            office.Check(30);

            Console.ReadLine();
        }
    }

    class Building
    {
        public int _floor;
        public int _occupants;
        public int _area;
        public Building(int floor,int area,int occupants)
        {
            _area = area;
            _floor = floor;
            _occupants = occupants;
            }
        public int AreaPerson()
        {
            return _area/_occupants;
        }

        public int MaxOccupant(int Min)
        {
            return _area / Min;
        }

        public void Check(int Min)
        {
            if (AreaPerson() > Min)
                Console.WriteLine("Yaşamak için Uygun.");
            else
                Console.WriteLine("Yaşanmaz aga");
        }

        }
    }

