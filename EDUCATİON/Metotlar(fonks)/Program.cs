using System;

namespace CsharpOne
{
    class Donguler
    {
        static void Main()
        {
            Add();
            var result = Add2(25);
            var number1 = 50;
            // Number Add3 ile çagırıldığında içerde değişir fakat sonra ESKİ değerinden devam eder
            var number2 = 100;

            var result1 = Add3(number1, number2);

            Console.WriteLine(result1);
            Console.WriteLine(number1);

            Console.WriteLine(result);
            var carpmalar = carp(5, 12, 3);
            Console.WriteLine("Çarpmaları yazdır.");
            Console.WriteLine(carpmalar);

            Console.WriteLine("Toplamları yazdır.");
            Console.WriteLine(toplam(1, 2, 3, 4, 5));





            Console.ReadLine();
        }

        static void Add()
        {
            // C dilindeki fonks. gibi düşün bunu
            Console.WriteLine("I have printed ADDED!.");
        }
        static int Add2(int sayi1, int sayi2 = 20)
        {
            var result = sayi1 + sayi2;
            // for(int i=0;i<20;i++)
            result = result;
            return result;
        }

        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int carp(int x, int y)
        {
            return x * y;
        }
        static int carp(int x, int y, int z) // imza olduğu için aynı isimle kullanabildik
        {
            return x * y * z;
        }

        static int toplam(params int[] numbers) // PARAMS işleci ile main içinde toplarken bi sınır yok istediğin kadar yazarsın
        {
            return numbers.Sum(); // SUM bir class , onu cagırdık
        }


    }
}