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
        CalcEng Raknare = new CalcEng();
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
            double input1 = double.Parse(textBox1.Text);
            double input2 = double.Parse(textBox2.Text);
            double results = 0;
            
            switch (btn.Text)
            {
                case "+":
                   results = Raknare.Add(input1, input2);
                    
                    break;

                case "-":
                    results = Raknare.Sub(input1, input2);
                    break;

                case "/":
                    results = Raknare.Div(input1, input2);
                    break;

                case "*":
                    results = Raknare.Mult(input1, input2);
                    break;

                default:
                    break;
            }
            Show_Result(input1, input2, results, btn.Text);
        }
        private void Show_Result(double input1, double input2, double results, string OP)
        {
            listBox1.Items.Add($"{input1} {OP} {input2} = {results}");
        } 
    }
}