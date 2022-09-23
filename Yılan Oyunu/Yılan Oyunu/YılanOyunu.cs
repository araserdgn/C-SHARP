using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yılan_Oyunu
{
    public class YılanOyunu
    {
        SnackParts[] snackPart;
        int büyüklük = 3;
        yonu yönüm;
        public YılanOyunu()
        {
            snackPart = new SnackParts[3]; // yılan su an 3 parça
            snackPart[0] = new SnackParts(150, 150);
            snackPart[1] = new SnackParts(160, 150);
            snackPart[2] = new SnackParts(170, 150);
        }
        public void SnackGo(yonu yon)
        {
            yönüm = yon;
            if (yon.Direction_x == 0 && yon.Direction_y == 0)
            {

            }
            else
            {

                if (yon != null)
                {
                    for (int i = snackPart.Length - 1; i > 0; i--)
                    {
                        snackPart[i] = new SnackParts(snackPart[i - 1].parca_x, snackPart[i - 1].parca_y);

                    }
                    snackPart[0] = new SnackParts(snackPart[0].parca_x + yon.Direction_x, snackPart[0].parca_y + yon.Direction_y);
                } // hepsi birbirini takip edecek
            }
        }
        public void SnackSize()
        {
            Array.Resize(ref snackPart, snackPart.Length + 1); // boy her seferinde değişeceği için, her seferinde adlandır
            snackPart[snackPart.Length - 1] = new SnackParts(snackPart[snackPart.Length - 2].parca_x - yönüm.Direction_x, snackPart[snackPart.Length - 2].parca_y - yönüm.Direction_y); // yılanı büyütüyoz
            büyüklük++;
        }
        public Point pozisyon(int numara)
        {
            return new Point(snackPart[numara].parca_x, snackPart[numara].parca_y); //
        }
    }
    

       public class SnackParts
        {
            public int parca_x;
            public int parca_y;

            public readonly int size_x; // sadece okunur
            public readonly int size_y; // burda değişiklik baska yerde değişmez
            public SnackParts(int x,int y)
            {
                parca_x = x;
                parca_y = y;
                size_x = 10;
                size_y = 10;
            }
        }
        public class yonu
        {
            public readonly int Direction_x;
            public readonly int Direction_y;

            public yonu(int x,int y)
            {
                Direction_x = x;
                Direction_y = y;
            }
    }

}

