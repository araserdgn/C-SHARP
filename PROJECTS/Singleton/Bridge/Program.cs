﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.MessageSenderBase = new SmsSender();
            customerManager.UpdateCustomer();

            Console.ReadLine();
        }
    }

    abstract class MessageSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Saved.!");
        }

        public abstract void Send(Body body); // SONRADAN DEĞİŞEN SOYUT OLD İÇİN abstract

    }

     class Body
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }

    class SmsSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via SmsSender", body.Title);
        }
    }
    class EmailSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via ,EmailSender", body.Title);
        }
    }

    class CustomerManager // KULLANCAGMZ KISM
    {
        public MessageSenderBase MessageSenderBase { get; set; }
        public void UpdateCustomer ()
        {
            MessageSenderBase.Send(new Body { Title="About the course!"});
            Console.WriteLine("Customer Updated..");
        }
    }
}
