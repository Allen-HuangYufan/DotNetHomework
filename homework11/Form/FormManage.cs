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
    public partial class FormManage : Form
    {
        OrderService orderService;
        public String QueryString { get; set; }

        public FormManage()
        {
            InitializeComponent();
            orderService = new OrderService();
            bdsOrder.DataSource = orderService.Orders;
            cbxQuery.SelectedIndex = 0;
            tbxKey.DataBindings.Add("Text", this, "QueryString");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit(new Order(), false, orderService);
            formEdit.ShowDialog();
        }

        public void QueryAll()
        {
            bdsOrder.DataSource = orderService.Orders;
            bdsOrder.ResetBindings(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditOrder();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Order order = bdsOrder.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            orderService.RemoveOrder(order.OrderId);
            QueryAll();
        }

        private void EditOrder()
        {
            Order order = bdsOrder.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            FormEdit form2 = new FormEdit(order, true, orderService);
            form2.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                orderService.Export(fileName);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                orderService.Import(fileName);
                QueryAll();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            switch (cbxQuery.SelectedIndex)
            {
                case 0://所有订单
                    bdsOrder.DataSource = orderService.Orders;
                    break;
                case 1://根据ID查询
                    int.TryParse(QueryString, out int id);
                    Order order = orderService.GetOrder(QueryString);
                    List<Order> result = new List<Order>();
                    if (order != null) result.Add(order);
                    bdsOrder.DataSource = result;
                    break;
                case 2://根据客户查询
                    bdsOrder.DataSource = orderService.QueryOrdersByCustomerName(QueryString);
                    break;
                case 3://根据货物查询
                    bdsOrder.DataSource = orderService.QueryOrdersByGoodsName(QueryString);
                    break;
                case 4://根据总价格查询（大于某个总价）
                    float.TryParse(QueryString, out float totalPrice);
                    bdsOrder.DataSource =
                           orderService.QueryByTotalAmount(totalPrice);
                    break;
            }
            bdsOrder.ResetBindings(false);
        }
    }
}
