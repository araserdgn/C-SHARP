using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator(); // ara bulucu
            
            Teacher aras = new Teacher (mediator);
            aras.Name = "Aras";

            mediator.Teacher = aras;

            Student sule = new Student(mediator);
            sule.Name = "Şule";
            

            Student emin = new Student(mediator);
            emin.Name = "Emin";

           mediator.Students= new List<Student> { sule,emin};

            aras.SendNewımageUrl("slide1.jpg");
            aras.RecieveQuestion("is it true ?",emin);

            Console.ReadLine();

        }
    }
    abstract class CourseMember //**//
    {
        protected Mediator Mediator;
        public CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
    class Teacher : CourseMember
    {
        public string Name { get; set; }
        public Teacher(Mediator mediator) : base(mediator)
        {
        }

        public  void RecieveQuestion(string question, Student student)
        {
            Console.WriteLine("Teacher recieved a question from {0} , {1}",student.Name,question);
        }

        public void SendNewımageUrl(string url)
        {
            Console.WriteLine("Teacher changed slide : {0} ", url);
            Mediator.UpdateImage(url);
        }

        public void AnsverQuestion(string answer,Student student)
        {
            Console.WriteLine("Teacher answered questino {0} , {1}",student.Name,answer);
        }
    }

    class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {
        }

        public string Name { get;  set; }

        public void RecieveImage(string url)
        {
            Console.WriteLine("{1} recived image : {0}", url,Name);
        }


        public void RecieveAnswer(string answer)
        {
            Console.WriteLine("Student recived answer {0}", answer);
        }
    }

    class Mediator //*//
    {
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public void UpdateImage(string url)
        {
            foreach (var student in Students)
            {
                student.RecieveImage(url);
            }
        }

        public void SendQuestion(string question, Student student) // gelen soru , öğrenciden gelir
        {
            Teacher.RecieveQuestion(question,student); // soru gelir , hocaya
        }

        public void SendAnswer (string answer,Student student)
        {
            student.RecieveAnswer(answer); // cevabı oogrenci aldı
        }
    }
}
