using System;

namespace Part3Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            var order = new Order();
            Console.WriteLine("What would you like to order ?");
            Console.WriteLine("1 - Grocery Items");
            Console.WriteLine("2 - Bakery Items");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    order.Ord_grocery();
                    break;
                case 2:
                    order.Ord_bakery();
                    break;
            }
        }
    }
}