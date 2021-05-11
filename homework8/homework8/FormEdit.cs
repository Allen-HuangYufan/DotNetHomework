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
    public partial class FormEdit : Form
    {
        private OrderService orderService;
        private bool editModel;

        public Order CurrentOrder { get; set; }

        public FormEdit(Order order, bool model, OrderService orderService)
        {
            InitializeComponent();
            bdsCustomer.Add(new Customer("1", "li"));
            bdsCustomer.Add(new Customer("2", "zhang"));
            this.orderService = orderService;
            this.editModel = model;
            this.CurrentOrder = order;
            bdsOrder.DataSource = CurrentOrder;
            tbxOrderId.Enabled = !model;
            if (!model)
            {
                CurrentOrder.Customer = (Customer)bdsCustomer.Current;
            }
        }

        public FormEdit()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormDetail formItem = new FormDetail(new OrderDetail());
            try
            {
                if (formItem.ShowDialog() == DialogResult.OK)
                {
                    uint index = 0;
                    if (CurrentOrder.Details.Count != 0)
                    {
                        index = CurrentOrder.Details.Max(i => i.Index) + 1;
                    }
                    formItem.Detail.Index = index;
                    CurrentOrder.AddItem(formItem.Detail);
                    bdsDetail.ResetBindings(false);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void EditDetail()
        {
            OrderDetail detail = bdsDetail.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行修改");
                return;
            }
            FormDetail formDetailEdit = new FormDetail(detail);
            if (formDetailEdit.ShowDialog() == DialogResult.OK)
            {
                bdsDetail.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditDetail();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OrderDetail detail = bdsDetail.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            CurrentOrder.RemoveDetail(detail);
            bdsDetail.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.editModel)
                {
                    orderService.UpdateOrder(CurrentOrder);
                }
                else
                {
                    orderService.AddOrder(CurrentOrder);
                }
                this.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }
    }
    
}
