using System;

class Program
{
    static void Main()
    {
        int numar1 = 20;
        double a = 18.15;

        Console.WriteLine("Numaranın degeri {0}", numar1);
        Console.WriteLine("Büyük sayının degeri: " + a); // +a yapınca satırın devamına ekledi
        long num2 = 2548964186;
        Console.WriteLine("Long sayının örnegi {0}", num2);
        byte num3 = 245;
        Console.WriteLine("Byte sayının örnegi= {0}", num2);

        char karakter = 'F';
        char karakter1 = 'B';

        Console.WriteLine("Karakter degeri: " + (int)karakter + karakter1);

        decimal num4 = 18.5m;
        Console.WriteLine("Decimal degeri: " + num4);

        Console.WriteLine(days.Tuesday);
        Console.WriteLine((int)days.Wednesday); // ASCI ile degeri donecek

        var sayı1 = 1785; // otomatik double olarak algıladı
        sayı1 = 'b'; // ASCII degerini dondurur, cnk var oto olarak İNT algıladı

        Console.WriteLine("Var'ın atadıgı sayı degeri: " + sayı1);

        Console.ReadLine();
    }

    enum days
    {
        Monday = 20, Tuesday, Wednesday, Thursday, Friday, Saturday
        // deger atadık, ACSII degeri sırayla degisir
    }
}