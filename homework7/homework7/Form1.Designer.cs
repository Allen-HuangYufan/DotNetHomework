
namespace homework7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.depth = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.perR = new System.Windows.Forms.TextBox();
            this.perL = new System.Windows.Forms.TextBox();
            this.thR = new System.Windows.Forms.TextBox();
            this.thL = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.ComboBox();
            this.draw = new System.Windows.Forms.Button();
            this.condition = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.condition);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.depth);
            this.flowLayoutPanel1.Controls.Add(this.length);
            this.flowLayoutPanel1.Controls.Add(this.perR);
            this.flowLayoutPanel1.Controls.Add(this.perL);
            this.flowLayoutPanel1.Controls.Add(this.thR);
            this.flowLayoutPanel1.Controls.Add(this.thL);
            this.flowLayoutPanel1.Controls.Add(this.color);
            this.flowLayoutPanel1.Controls.Add(this.draw);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(76, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(107, 297);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(3, 3);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(100, 28);
            this.depth.TabIndex = 0;
            this.depth.Text = "递归深度";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(3, 37);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(100, 28);
            this.length.TabIndex = 1;
            this.length.Text = "主干长度";
            // 
            // perR
            // 
            this.perR.Location = new System.Drawing.Point(3, 71);
            this.perR.Name = "perR";
            this.perR.Size = new System.Drawing.Size(100, 28);
            this.perR.TabIndex = 2;
            this.perR.Text = "右长度比";
            // 
            // perL
            // 
            this.perL.Location = new System.Drawing.Point(3, 105);
            this.perL.Name = "perL";
            this.perL.Size = new System.Drawing.Size(100, 28);
            this.perL.TabIndex = 3;
            this.perL.Text = "左长度比";
            // 
            // thR
            // 
            this.thR.Location = new System.Drawing.Point(3, 139);
            this.thR.Name = "thR";
            this.thR.Size = new System.Drawing.Size(100, 28);
            this.thR.TabIndex = 4;
            this.thR.Text = "右角度";
            // 
            // thL
            // 
            this.thL.Location = new System.Drawing.Point(3, 173);
            this.thL.Name = "thL";
            this.thL.Size = new System.Drawing.Size(100, 28);
            this.thL.TabIndex = 5;
            this.thL.Text = "左角度";
            // 
            // color
            // 
            this.color.FormattingEnabled = true;
            this.color.Items.AddRange(new object[] {
            "红",
            "黄",
            "蓝",
            "绿",
            "黑"});
            this.color.Location = new System.Drawing.Point(3, 207);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(100, 26);
            this.color.TabIndex = 6;
            this.color.Text = "颜色";
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(3, 239);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(100, 28);
            this.draw.TabIndex = 7;
            this.draw.Text = "绘图";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // condition
            // 
            this.condition.Location = new System.Drawing.Point(76, 362);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(107, 28);
            this.condition.TabIndex = 1;
            this.condition.Text = "绘图状态";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "CayleyTree";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox perR;
        private System.Windows.Forms.TextBox perL;
        private System.Windows.Forms.TextBox thR;
        private System.Windows.Forms.TextBox thL;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.TextBox condition;
    }
}

