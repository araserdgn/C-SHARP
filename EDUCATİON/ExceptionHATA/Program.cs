using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHATA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exceptionİntro();

            try
            {
                Find();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }

            HandleException(() => // BU DELEGE METODUDUR. yani metot içine metot atama diyeblrz.
            {
                Find();
            });




            Console.ReadLine();

        }

        private static void HandleException(Action p) // Parametre yok ve VOİD dir. DIşarı bir şey döndürmez.
                                                        // P burada Handle'nin içi demek onu kasteder.
        {
            try
            {
                p.Invoke(); // yani dedin ki sen programa HANDLE içine git FİND çalıştır. onu da burda kontrol et
            }
            catch (Exception exception) // hata verirse buraya duş 
            {
                Console.WriteLine(exception.Message); // ekrana bunu bas
                
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Ezgi", "İso", "Aras", "Barbara" };
            if (!students.Contains("Ali")) // students listede ALİ var mı bak
            {
                throw new KendiHataMesajıOlusturma("Record is not found!!!!"); // Hata fırlat demek bu kod, İf içine girerse yani biizm hata sınıfına düşer direkt
            }                                                                  // KendiHata sınıfında ctor atadık o yzden içine mesaj ayzdırdk         
            else
            {
                Console.WriteLine("Recond");
            }
        }

        private static void Exceptionİntro()
        {
            try // kodu bi dene hata var mı yok mu diye. varsa catch yerine iner
            {
                string[] student = new string[3] { "beyza", "ezgi", "kübra" };

                student[3] = "aleyna";
            }
            catch (IndexOutOfRangeException exception) // eger hata ındexout..... ise aşşagıdakini yap. değilse diğer catche geç.
            {
                Console.WriteLine(exception.Message);
            }
            // kırmızı noktalar başlatınca programı hangisinin içinde kaldıgını gösterir
            // uygulama çalışınca sarı oluyorsa kırmızı yer yani prog. orada çalışıyor demektir

            // breakpoint denir o noktalara
            catch (dividebyzeroexception exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message); // nerede hata vermiş onu bize açıklar

                Console.WriteLine(exception.StackTrace); // hatanın hangi komundan,dosyadan ve kaçıncı satırında olduguna kadar gösterir

                Console.WriteLine(exception.InnerException); // gerek varsa hata konusunda daha fazla detay verir.

            }
        }
    }
}
