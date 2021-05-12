using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace homework8
{
    public partial class FormDetail : Form
    {
        public OrderDetail Detail { get; set; }

        public FormDetail()
        {
            InitializeComponent();
        }

        public FormDetail(OrderDetail detail) : this()
        {
            this.Detail = detail;
            this.bdsDetailItem.DataSource = detail;
            bdsGood.Add(new Goods("1", "apple", 100.0));
            bdsGood.Add(new Goods("2", "egg", 200.0));
        }
    }
}
