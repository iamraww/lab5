using System;

namespace Part3Ex1
{
    public class Order
    {
        public void Ord_grocery()
        {
            Customer customer = new Customer();
            customer.customerName();
            Console.WriteLine("Hello {0}", customer.Name);
            Console.WriteLine("You have ordered grocery items ");
        }

        public void Ord_bakery()
        {
            Customer customer = new Customer();
            customer.customerName();
            Console.WriteLine("Hello {0}", customer.Name);
            Console.WriteLine("You have ordered bakery items ");
        }
    }
}