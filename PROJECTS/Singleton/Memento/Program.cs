using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            book book = new book
            {
                Title ="Düşmann",
                Isbn = "12345",
                Author ="Victor Beylerzade"
                
            };

            book.ShowBook();
            // ASAGIDA SİMDİ DEĞİŞİYOO
            CareTaker history= new CareTaker();
            history.Memento = book.CreateUndo();

            book.Title = "Sefiller kankks";
            book.Isbn = "00000";
            book.ShowBook();
            // ASAGIDA ŞİMDİ ORİJİNE DÖNOYO

            book.restoreFromUndo(history.Memento);
            book.ShowBook();
            

            Console.ReadLine();
        }
    }
    class book
    {
        private string _title;
        private string _author;
        private string _isbn;
        private DateTime _lastEdited; // tarih gösterir

        public string Title 
        { 
            get { return _title; }
            set { // nesnenin değiştiği yer SET kısmıdır.


                _title = value; 
                SetLastEdited();
            } 
        }
        public string Author
        {
            get { return _author; }
            set { 
                
                _author = value;
                SetLastEdited();
            }
        }
        public string Isbn
        {
            get { return _isbn; }
            set { 
                
                
                _isbn = value;
                SetLastEdited();
            }
        }
        private void SetLastEdited () // nesnenin değiştiğini ispat edecek
        {
            _lastEdited = DateTime.UtcNow; // anlık tarihi yazar
        }
        public Memento CreateUndo () // yeni hali
        {
            return new Memento (_title, _author, _isbn, _lastEdited);
        }
        public void restoreFromUndo(Memento memento) // eski halleri , orijinal olan yani
        {
            _title = memento.Title;
            _author = memento.Author;
            _isbn = memento.Isbn;
            _lastEdited = memento.LastEdited;
        }
        public void ShowBook()
        {
            Console.WriteLine("{0} , {1},{2} edited : {3}", Title, Isbn, Author, _lastEdited);
        }

    }
    class Memento
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public DateTime LastEdited { get; set; }
        public Memento(string title,string author, string isbn, DateTime lastedited)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            LastEdited = lastedited;
        }
    }
    class CareTaker // eski değeri tutar
    {
        public Memento Memento { get; set; }
    }
}
