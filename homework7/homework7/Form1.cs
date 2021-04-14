using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        double th1 = 30;
        double th2 = 20;
        double per1 = 0.6;
        double per2 = 0.7;
        int n = 10;
        double leng = 100;
        double th = -Math.PI / 2;
        Pen pen = Pens.Black;

        private void draw_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = splitContainer1.Panel2.CreateGraphics();
            else graphics.Clear(Color.White);

            if (Double.TryParse(thR.Text, out th1) && Double.TryParse(thL.Text, out th2) &&
            Double.TryParse(perR.Text, out per1) && Double.TryParse(perL.Text, out per2) &&
            Double.TryParse(length.Text, out leng) && Int32.TryParse(depth.Text, out n))
            {
                switch(color.SelectedItem)
                {
                    case "红":
                        pen = Pens.Red;
                        break;
                    case "黄":
                        pen = Pens.Yellow;
                        break;
                    case "蓝":
                        pen = Pens.Blue;
                        break;
                    case "绿":
                        pen = Pens.Green;
                        break;
                    default:
                        pen = Pens.Black;
                        break;
                }
                condition.Text = "绘图成功";
            }
            else
            {
                condition.Text = "输入错误";
            }

            DrawCayleyTree(n, 200, 310, leng, th);
        }

        private void DrawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            DrawLine(x0, y0, x1, y1);
            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1 * Math.PI / 180);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2 * Math.PI / 180);
        }

        private void DrawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (float)x0, (float)y0, (float)x1, (float)y1);
        }
    }
}
