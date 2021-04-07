using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class OrderDetails
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductNumber { get; set; }
        public double PriceSum { get; set; }

        public OrderDetails()
        {
            this.ProductName = string.Empty;
            this.ProductPrice = 0;
            this.ProductNumber = 0;
            this.PriceSum = 0;
        }

        public OrderDetails(string productName, double productPrice, int productNumber)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.ProductNumber = productNumber;
            this.PriceSum = productPrice * productNumber;
        }

        public override string ToString()
        {
            return "productName:" + ProductName + " "
                + "productPrice:" + ProductPrice + " "
                + "productNumber:" + ProductNumber + " "
                + "priceSum:" + PriceSum;
        }

    }
}
