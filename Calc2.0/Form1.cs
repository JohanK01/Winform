using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "/";
            button4.Text = "*";

            button1.Click += new EventHandler(ButtonHandler);
            button2.Click += new EventHandler(ButtonHandler);
            button3.Click += new EventHandler(ButtonHandler);
            button4.Click += new EventHandler(ButtonHandler);
        }

        private void ButtonHandler(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            switch (btn.Text)
            {
                case "+":
                    
                    break;

                case "-":
                    break;

                case "/":
                    break;

                case "*":
                    break;

                default:
                    break;
            }
        }
    }
}