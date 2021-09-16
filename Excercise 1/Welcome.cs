using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise_1
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void click_Click(object sender, EventArgs e)
        {
            int i, j;
            i = int.Parse(textBox1.Text);   
            j = int.Parse(textBox2.Text); 

            listBox1.Items.Add($" {i} + {j} = {i +j}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j;
            i = int.Parse(textBox1.Text);
            j = int.Parse(textBox2.Text);
            listBox1.Items.Add($" {i} - {j} = {i - j}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            double i, j;
            i = int.Parse(textBox1.Text);
            j = int.Parse(textBox2.Text);
            listBox1.Items.Add($" {i} / {j} = {i / j}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, j;
            i = int.Parse(textBox1.Text);
            j = int.Parse(textBox2.Text);
            listBox1.Items.Add($" {i} * {j} = {i * j}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
