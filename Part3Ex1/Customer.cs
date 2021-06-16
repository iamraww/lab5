using System;

namespace Part3Ex1
{
    public class Customer
    {
        public string Name { get; set; }

        public void customerName()
        {
            Console.WriteLine("Enter your name :");
            Name = Console.ReadLine();
        }
    }
}