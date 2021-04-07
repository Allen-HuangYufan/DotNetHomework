using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class OrderServices
    {
        public List<Order> allOrder = new List<Order>();

        public OrderServices()
        {

        }

        public override string ToString()
        {
            string x = string.Empty;
            int j = 1;
            foreach(Order a in allOrder)
            {
                x += j.ToString() + " " + a.ToString() + "\n\r";
                j++;
            }
            return x;
        }

        public void AddOrder()
        {
            try
            {
                Console.WriteLine("please input orderId:");
                int orderId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please input clientName:");
                string clientName = Console.ReadLine();
                Order a = new Order(orderId, clientName);
                bool orderSameFlag = false;
                bool detailFlag = true;
                foreach (Order o in this.allOrder) 
                    if (o.Equals(a)) 
                        orderSameFlag = true;
                if (orderSameFlag)
                {
                    Console.WriteLine("repeated orderId!");
                    Console.WriteLine("--------------------------------");
                }
                else
                {
                    while (!orderSameFlag && detailFlag)
                    {
                        Console.WriteLine("please input productName:");
                        string productName = Console.ReadLine();
                        Console.WriteLine("please input productPrice:");
                        double productPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("please input productNumber:");
                        int productNumber = Convert.ToInt32(Console.ReadLine());
                        a.AddOrderDetail(productName, productPrice, productNumber);
                        Console.WriteLine("continue to add details? (please input yes or no)");
                        string x = Console.ReadLine();
                        if (x == "yes") continue;
                        else if (x == "no") detailFlag = false;
                        else
                        {
                            Exception e = new Exception();
                            throw e;
                        }
                    }
                    this.allOrder.Add(a);
                    a.GetSum();
                    Console.WriteLine("order added successfully");
                    Console.WriteLine("--------------------------------");
                }
            }
            catch
            {
                Console.WriteLine("*****WRONG INPUT!!!*****");
                Console.WriteLine("--------------------------------");
            }
        }

        public void RemoveOrder()
        {
            Console.WriteLine("please input order number:");
            int orderNumber = Convert.ToInt32(Console.ReadLine());
            int orderIndex = 0;
            foreach(Order p in this.allOrder)
            {
                if (p.OrderId == orderNumber) orderIndex = orderNumber;
            }
            if (orderIndex == 0)
            {
                Console.WriteLine("order doesn't exist");
                Console.WriteLine("--------------------------------");
                return;
            }
            else
            {
                Console.WriteLine("order found");
                Console.WriteLine("input o for deleting order, d for deleting details");
                string q = Console.ReadLine();
                switch(q)
                {
                    case "o":
                        this.allOrder.RemoveAt(orderIndex);
                        Console.WriteLine("order deleted succesfully!");
                        Console.WriteLine("--------------------------------");
                        break;
                    case "d":
                        this.allOrder[orderIndex].RemoveOrderDetail();
                        break;
                    default:
                        Console.WriteLine("wrong input!");
                        Console.WriteLine("--------------------------------");
                        break;
                }
            }
        }

        public void OrderQuery(int i)
        {
            try
            {
                switch (i)
                {
                    case 1:
                        double min, max;
                        Console.WriteLine("please input minimum sum:");
                        min = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("please input maximum sum:");
                        max = Convert.ToDouble(Console.ReadLine());
                        var query1 = from order1 in this.allOrder
                                     where max > order1.Sum
                                     orderby order1.Sum
                                     select order1;
                        var query2 = from order2 in query1
                                     where order2.Sum > min
                                     orderby order2.Sum
                                     select order2;
                        List<Order> list1 = query2.ToList();

                        foreach (Order r in list1)
                        {
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine(r.ToString());
                        }
                        break;

                    case 2:
                        Console.WriteLine("please input clientName:");
                        string name1 = Console.ReadLine();
                        var query3 = from order3 in this.allOrder
                                     where order3.ClientName == name1
                                     orderby order3.Sum
                                     select order3;
                        List<Order> list2 = query3.ToList();

                        foreach (Order s in list2)
                        {
                            Console.WriteLine(s.ToString());
                            Console.WriteLine("--------------------------------");
                            
                        }
                        break;

                    default: 
                        Console.WriteLine("输入错误");
                        Console.WriteLine("--------------------------------");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("输入错误");
                Console.WriteLine("--------------------------------");
            }
        }

        public void OrderSort()
        {
            var query = from order in this.allOrder
                        orderby order.OrderId
                        select order;
            this.allOrder = query.ToList();
            Console.WriteLine("order sorted successfully");
            Console.WriteLine("--------------------------------");
        }
    }
}
