using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace homework6.Test
{
    [TestClass]
    public class OrderServicesTest
    {
        [TestMethod]
        public void AddOrderTest()
        {
            Order order = new Order();
            OrderServices orderServices = new OrderServices();
            orderServices.AddOrder(order);
            Assert.IsTrue(orderServices.orderList.Contains(order));
        }

        [TestMethod]
        public void UpdateTest()
        {
            Order order = new Order();
            OrderServices orderServices = new OrderServices();
            orderServices.AddOrder(order);
            Assert.IsTrue(orderServices.orderList.Contains(order));
        }

        [TestMethod]
        public void GetByIdTest()
        {
            Customer customer = new Customer();
            Order order1 = new Order(1, customer);
            Order order2 = new Order(2, customer);
            Order order3 = new Order(3, customer);
            OrderServices orderServices = new OrderServices();
            orderServices.AddOrder(order1);
            orderServices.AddOrder(order2);
            orderServices.AddOrder(order3);
            Assert.AreEqual(orderServices.GetById(2), order2);
        }

        [TestMethod]
        public void RemoveOrderTest()
        {
            Customer customer = new Customer();
            Order order1 = new Order(1, customer);
            Order order2 = new Order(2, customer);
            Order order3 = new Order(3, customer);
            OrderServices orderServices = new OrderServices();
            orderServices.AddOrder(order1);
            orderServices.AddOrder(order2);
            orderServices.AddOrder(order3);

            orderServices.RemoveOrder(1);
            Assert.IsNull(orderServices.GetById(1));
        }

        [TestMethod]
        public void QueryByGoodNameTest()
        {
            Customer customer1 = new Customer(1, "a");
            Customer customer2 = new Customer(2, "b");

            Goods goods1 = new Goods(1, "book1", 1);
            Goods goods2 = new Goods(2, "book2", 2);
            Goods goods3 = new Goods(3, "book3", 3);

            Order order1 = new Order(1, customer1);
            order1.AddDetails(new OrderDetails(goods1, 1));
            order1.AddDetails(new OrderDetails(goods2, 2));

            Order order2 = new Order(2, customer2);
            order2.AddDetails(new OrderDetails(goods1, 1));
            order2.AddDetails(new OrderDetails(goods3, 3));

            OrderServices orderServices = new OrderServices();
            orderServices.AddOrder(order1);
            orderServices.AddOrder(order2);

            List<Order> expected = new List<Order>();
            Order order3 = new Order(1, customer1);
            order3.AddDetails(new OrderDetails(goods1, 1));
            Order order4 = new Order(2, customer2);
            order4.AddDetails(new OrderDetails(goods1, 1));
            expected.Add(order3);
            expected.Add(order4);

            Assert.IsTrue(orderServices.QueryByGoodsName("book1").SequenceEqual(expected));
        }

        [TestMethod]
        public void QueryByGoodTotalAmountTest()
        {
            Customer customer1 = new Customer(1, "a");
            Customer customer2 = new Customer(2, "b");

            Goods goods1 = new Goods(1, "book1", 1);
            Goods goods2 = new Goods(2, "book2", 2);
            Goods goods3 = new Goods(3, "book3", 3);

            Order order1 = new Order(1, customer1);
            order1.AddDetails(new OrderDetails(goods1, 1));
            order1.AddDetails(new OrderDetails(goods2, 2));

            Order order2 = new Order(2, customer2);
            order2.AddDetails(new OrderDetails(goods2, 2));
            order2.AddDetails(new OrderDetails(goods3, 3));

            OrderServices orderServices = new OrderServices();
            orderServices.AddOrder(order1);
            orderServices.AddOrder(order2);

            List<Order> expected = new List<Order>();
            expected.Add(order2);

            Assert.IsTrue(orderServices.QueryByTotalAmount(13).SequenceEqual(expected));
        }

        [TestMethod]
        public void QueryByCustomerNameTest()
        {
            Customer customer1 = new Customer(1, "a");
            Customer customer2 = new Customer(2, "b");

            Goods goods1 = new Goods(1, "book1", 1);
            Goods goods2 = new Goods(2, "book2", 2);
            Goods goods3 = new Goods(3, "book3", 3);

            Order order1 = new Order(1, customer1);
            order1.AddDetails(new OrderDetails(goods1, 1));
            order1.AddDetails(new OrderDetails(goods2, 2));

            Order order2 = new Order(2, customer2);
            order2.AddDetails(new OrderDetails(goods1, 1));

            OrderServices orderServices = new OrderServices();
            orderServices.AddOrder(order1);
            orderServices.AddOrder(order2);

            List<Order> expected = new List<Order>();
            expected.Add(order2);

            Assert.IsTrue(orderServices.QueryByCustomerName("b").SequenceEqual(expected));
        }


    }


}
