using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Order:IComparable
    {
        public List<OrderDetails> singleOrder = new List<OrderDetails>();
        public int OrderId { get; set; }
        public string ClientName { get; set; }
        public double Sum { get; set; }

        public Order()
        {
            this.OrderId = 0;
            this.ClientName = string.Empty;
            this.Sum = 0;
        }

        public Order(int orderId, string clientName)
        {
            this.OrderId = orderId;
            this.ClientName = clientName;
        }

        public int CompareTo(object obj)
        {
            Order temp = obj as Order;
            return this.OrderId.CompareTo(temp.OrderId);
        }

        public override bool Equals(object obj)
        {
            Order temp = obj as Order;
            return this.OrderId == temp.OrderId;
        }

        public void GetSum()
        {
            double i = 0;
            foreach(OrderDetails a in this.singleOrder)
            {
                i += a.PriceSum;
            }
            this.Sum = i;
        }

        public void AddOrderDetail(string productName, double productPrice, int productNumber)
        {
            OrderDetails a = new OrderDetails(productName, productPrice, productNumber);
            this.singleOrder.Add(a);
        }

        public void RemoveOrderDetail()
        {
            try
            {
                Console.WriteLine("please input the OrderDetail number:");
                int a = Convert.ToInt32(Console.ReadLine());
                this.singleOrder.RemoveAt(a);
                Console.WriteLine("removed successfully");
                Console.WriteLine("--------------------------------");
            }
            catch
            {
                Console.WriteLine("wrong OrderDetail number!");
                Console.WriteLine("--------------------------------");
            }
        }

        public override string ToString()
        {
            string str = string.Empty;
            int i = 1;
            foreach(OrderDetails a in this.singleOrder)
            {
                str += i.ToString() + " " + a.ToString() + "\r\n";
                i++;
            }
            return str;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
