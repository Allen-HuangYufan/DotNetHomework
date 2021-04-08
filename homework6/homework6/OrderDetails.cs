using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{

    public class OrderDetails
    {

        public Goods Goods { get; set; }

        public uint Quantity { get; set; }

        public float Amount
        {
            get => Goods.Price * Quantity;
        }

        public OrderDetails(Goods goods, uint quantity)
        {
            this.Goods = goods;
            this.Quantity = quantity;
        }

        public OrderDetails() { }

        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetails;
            return detail != null &&
                   EqualityComparer<Goods>.Default.Equals(Goods, detail.Goods);
        }

        public override string ToString()
        {
            return $"OrderDetail:{Goods},{Quantity}";
        }

        public override int GetHashCode()
        {
            return 624022166 + this.GetHashCode();
        }
    }
}