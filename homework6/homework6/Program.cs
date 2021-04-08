using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderServices orderServices = new OrderServices();
            orderServices.Import();
            List<Order> orders = orderServices.orderList;
            orders.ForEach(o => Console.WriteLine(o));
        }
    }
}
