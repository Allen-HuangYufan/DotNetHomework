using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void Form1_Load()
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.Items.Add("%");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedItem.ToString() == "")
                textBox3.Text = "Wrong";
            else
            {
                string str = comboBox1.SelectedItem.ToString();
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
            
                switch (str)
                {
                    case "+":
                        textBox3.Text = Convert.ToString(a + b);
                        break;
                    case "-":
                        textBox3.Text = Convert.ToString(a - b);
                        break;
                    case "*":
                        textBox3.Text = Convert.ToString(a * b);
                        break;
                    case "/":
                        textBox3.Text = Convert.ToString(a / b);
                        break;
                    case "%":
                        textBox3.Text = Convert.ToString(a % b);
                        break;
                    default:
                        textBox3.Text = "Wrong";
                        break;
                }
            }
            
        }
    }
}
