using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderServices orderServices = new OrderServices();
            bool flag = true;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Welcome to order managing system");
            Console.WriteLine("--------------------------------");
            while(flag)
            {
                Console.WriteLine("input 1 for adding order, input 2 for deleting order,");
                Console.WriteLine("input 3 for showing orders, input 4 for sorting orders,");
                Console.WriteLine("input 5 for order query, input 6 to EXIT");
                string str = Console.ReadLine();
                switch(str)
                {
                    case "1":
                        orderServices.AddOrder();
                        break;
                    case "2":
                        orderServices.RemoveOrder();
                        break;
                    case "3":
                        Console.WriteLine(orderServices.ToString());
                        break;
                    case "4":
                        orderServices.OrderSort();
                        break;
                    case "5":
                        Console.WriteLine("input 1 for price query");
                        Console.WriteLine("input 2 for clientName query");
                        int i = Convert.ToInt32(Console.ReadLine());
                        orderServices.OrderQuery(i);
                        break;
                    case "6":
                        Console.WriteLine("thank you for using this system!");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
            }
        }
    }
}
