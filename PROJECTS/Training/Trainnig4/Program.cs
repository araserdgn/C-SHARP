using System;
class Stack
{
    // Bu uyeler ozel.
    public char[] stck; // yigini tutuyor
    public int tos; // yiginin tepesinin indeksi

    // Buyuklugu verilen bos yigini yap.
    public Stack(int size)
    {
        stck = new char[size]; // yigin icin bellek ayir
        tos = 0;
    }

    // Yigina karakterler it (push).
    public void Push(char ch)
    {
        if (tos == stck.Length)
            return;

        stck[tos++] = ch;
        tos++;
        // BU KISMI DOLDURUN
        // KENDİNE VERİLEN ELAMANLARI Stack NESNESİNE DOLDURAN KODU YAZIN
    }
    // Yigindan bir karakter cek (pop).
    public char Pop()
    {
        if (tos == 0)
            Console.WriteLine("Stack is Empty");
  
            return stck[tos--];
        
        // BU KISMI DOLDURUN
        // HER ÇAĞRILDIĞINDA Stack NESNESİNİN EN ÜSTÜNDE BULUNAN ELEMANI POP EDEN KODU YAZIN


       return ' ';
    }
    public bool IsFull()
    {
        if (tos == stck.Length)
            return true;
        // BU KISMI DOLDURUN
        // Stack NESNESİ DOLU İSE true DOLU DEĞİLSE false DÖNDÜREN KODU YAZIN
        return false;
    }
    // Yigin bossa dogru don.
    public bool IsEmpty()
    {
        // BU KISMI DOLDURUN
        // Stack NESNESİ BOŞ İSE true BOŞ DEĞİLSE false DÖNDÜREN KODU YAZIN
        return true;
    }
    // Yiginin toplam kapasitesini don.
    public int Capacity()
    {
        // BU KISMI DOLDURUN
        // Stack NESNESİNİN KAPASİTESİNİ(ALABİLECEĞİ EN FAZLA SAYIDA ELEMAN SAYISINI) DÖNDÜREN KODU YAZIN

        return -1;
    }
    // O andaki yigindaki karakter sayisini don.
    public int GetNum()
    {
        // BU KISMI DOLDURUN
        // Stack NESNESİNDE O ANDA BULUNAN ELEMAN SAYISINI DÖNDÜREN KODU YAZIN
        return -1;
    }
}


namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack stk1 = new Stack(10);
            Stack stk2 = new Stack(10);
            Stack stk3 = new Stack(10);
            char ch;
            int i;
            int puan = 0;
            bool dogru = true;


            // 1. Adım:(20 PUAN)  Stack sınıfındaki Push() metodunun içini doldurun  <<<<Stack SINIFINA KOD YAZILACAK BÖLÜM>>>>
            // Push() metodu sorunsuz çalıştığında aşağıdaki kod A ve J arasi karakterleri stk1'e koyar..
            Console.WriteLine("A ve J arasi karakterleri stk1'e it.");
            for (i = 0; i < stk1.stck.Length; i++)
                stk1.Push((char)('A' + i));       //BU KISMA HERHANGİ BİRŞEY YAZMAYIN
            // 1. Adım sonu




            //1. Adımın doğru yapılıp yapılmadığını kontrol eden blok başlangıcı
            for (i = 0; i < stk1.stck.Length; i++)
                if (stk1.stck[i] != (char)('A' + i))
                    dogru = false;                              //BU KISMA HERHANGİ BİRŞEY YAZMAYIN
            if (dogru)
                puan += 20;
            dogru = true;
            i = 0;
            //1. Adımın doğru yapılıp yapılmadığını kontrol eden blok sonu


            // 2. Adım:(10 PUAN)  Stack clasındaki IsFull() metodunun içini doldurun  <<<<Stack SINIFINA KOD YAZILACAK BÖLÜM>>>>
            // IsFull() doğru çalıştığında aşağıdaki kod ekrana "stk1 doludur." yazdırır.
            if (stk1.IsFull())
            {
                Console.WriteLine("stk1 doludur.");                 //BU KISMA HERHANGİ BİRŞEY YAZMAYIN
                puan += 10;
            }
            // 2. Adım sonu





            // 3. Adım:(20 PUAN) Stack sınıfındaki Pop() metodunun içini doldurun, <<<<Stack SINIFINA KOD YAZILACAK BÖLÜM>>>>
            // Pop() metodu doğru çalıştığında stk1 içine doldurduğunuz karakterler ekrana yazdırılır.            
            Console.Write("stk1'in icerigi: ");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();                            //BU KISMA HERHANGİ BİRŞEY YAZMAYIN
                Console.Write(ch);
            }

            //3. Adımın doğru yapılıp yapılmadığını kontrol eden blok başlangıcı
            if (stk1.IsEmpty())                   //BU KISMA HERHANGİ BİRŞEY YAZMAYIN
                puan += 20;
            //3. Adımın doğru yapılıp yapılmadığını kontrol eden blok sonu


            Console.WriteLine();


            //4. Adım:(10 PUAN)  Stack sınıfındaki IsEmpty() metodunun içini doldurun    <<<<Stack SINIFINA KOD YAZILACAK BÖLÜM>>>>
            //IsEmpty() doğru çalıştığında aşağıdaki kod ekrana "stk1 bostur." yazdırır.
            if (stk1.IsEmpty())
            {
                Console.WriteLine("stk1 bostur.\n");     // //BU KISMA HERHANGİ BİRŞEY YAZMAYIN
                puan += 10;

            }
            //4. Adım sonu


            //5. Adım stk1'e tekrar A ve J arasi karakterleri dolduran kısım    //BU KISMA HERHANGİ BİRŞEY YAZMAYIN
            Console.WriteLine("Yine A ve J arasi karakterleri stk1'e it.");
            for (i = 0; i < stk1.stck.Length; i++)
                stk1.Push((char)('A' + i));
            //5. Adım sonu



            Console.WriteLine("Simdi, stk1'den karakterleri cek ve stk2'ye it.");
            // 6. Adım: stk1 deki karakterleri Pop() edip stk2 ye Push() eden kodu yazın  <<<<<BU ALANA KOD YAZILACAK >>>>>
            //
            //
            //KOD YAZILACAK
            //
            //
            ///////////////////////////////////
            // 6. Adım sonu



            //6. Adımın doğru yapılıp yapılmadığını kontrol eden blok başlangıcı
            dogru = true;
            for (i = 0; i < stk2.stck.Length; i++)
                if (stk2.stck[i] != (char)('J' - i))
                    dogru = false;                      //BU KISMA HERHANGİ BİRŞEY YAZMAYIN
            if (dogru)
                puan += 20;
            //6. Adımın doğru yapılıp yapılmadığını kontrol eden blok sonu



            //7. Adım: 6. Adım doğru yapıldıysa stk2'nin içeriğini yazdıran kod
            Console.Write("stk2'nin icerigi: ");
            while (!stk2.IsEmpty())
            {
                ch = stk2.Pop();                //BU KISMA HERHANGİ BİRŞEY YAZMAYIN
                Console.Write(ch);
            }
            Console.WriteLine("\n");
            //7. Adım sonu



            // 8. Adım:(10 PUAN)  Bu kısma stk3'e A-E arasındaki 5 karakteri Push() edecek kodu yazın
            //
            //
            //KOD YAZILACAK
            //
            //
            ///////////////////////////////////
            // 8. Adım sonu


            //8. Adımın doğru yapılıp yapılmadığını kontrol eden blok başlangıcı
            dogru = true;
            for (i = 0; i < 5; i++)
                if (stk3.stck[i] != (char)('A' + i))
                    dogru = false;                      //BU KISMA HERHANGİ BİRŞEY YAZMAYIN
            if (dogru)
                puan += 10;
            //6. Adımın doğru yapılıp yapılmadığını kontrol eden blok sonu




            // 9. Adım:(10 PUAN)  Stack sınıfındaki Capacity() metodunun içini doldurun
            // Capacity() doğru çalıştığında ekrana "stk3'un kapasitesi:10" yazdırır
            Console.WriteLine("stk3'un kapasitesi: " + stk3.Capacity());
            //9. Adım sonu

            //9.Adımın doğru yapılıp yapılmadığını kontrol eden blok başlangıcı
            if (stk3.Capacity() == stk3.stck.Length)
                puan += 10;
            //9.Adımın doğru yapılıp yapılmadığını kontrol eden blok sonu


            // 10. Adım:(10 PUAN)  Stack sınıfındaki GetNum() metodunun içini doldurun
            // GetNum() metodu doğru çalıştığında ekrana "stk3'teki nesne (karakter) sayisi:5" yazdırır
            Console.WriteLine("stk3'teki nesne (karakter) sayisi: " + stk3.GetNum());
            //10. Adım sonu


            //10.Adımın doğru yapılıp yapılmadığını kontrol eden blok başlangıcı
            if (stk3.Capacity() == stk3.tos)
                puan += 10;
            //10.Adımın doğru yapılıp yapılmadığını kontrol eden blok sonu


            Console.WriteLine("BU ÇALIŞMA SONUCUNDA ALDIĞINIZ PUAN->" + puan);

            Console.ReadLine();

        }
    }
}