
namespace homework8
{
    partial class FormDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bdsDetailItem = new System.Windows.Forms.BindingSource(this.components);
            this.bdsGood = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxGood = new System.Windows.Forms.ComboBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.btbConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetailItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGood)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdsDetailItem
            // 
            this.bdsDetailItem.DataSource = typeof(OrderApp.OrderDetail);
            // 
            // bdsGood
            // 
            this.bdsGood.DataSource = typeof(OrderApp.Goods);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.58089F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.41911F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxGood, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxQuantity, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(70, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.98039F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.01961F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 132);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "货物名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 67);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15);
            this.label2.Size = new System.Drawing.Size(74, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "数量";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxGood
            // 
            this.cbxGood.DataSource = this.bdsGood;
            this.cbxGood.DisplayMember = "Name";
            this.cbxGood.FormattingEnabled = true;
            this.cbxGood.Location = new System.Drawing.Point(188, 18);
            this.cbxGood.Name = "cbxGood";
            this.cbxGood.Size = new System.Drawing.Size(368, 26);
            this.cbxGood.TabIndex = 2;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDetailItem, "Quantity", true));
            this.tbxQuantity.Location = new System.Drawing.Point(188, 69);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(368, 28);
            this.tbxQuantity.TabIndex = 3;
            // 
            // btbConfirm
            // 
            this.btbConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btbConfirm.Location = new System.Drawing.Point(298, 206);
            this.btbConfirm.Name = "btbConfirm";
            this.btbConfirm.Size = new System.Drawing.Size(169, 35);
            this.btbConfirm.TabIndex = 11;
            this.btbConfirm.Text = "确定";
            this.btbConfirm.UseVisualStyleBackColor = true;
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 281);
            this.Controls.Add(this.btbConfirm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormDetail";
            this.Text = "订单明细";
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetailItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGood)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsDetailItem;
        private System.Windows.Forms.BindingSource bdsGood;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxGood;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Button btbConfirm;
    }
}