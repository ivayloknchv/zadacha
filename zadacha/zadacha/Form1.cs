using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] array = new double[100];
        int i=0; int n;
        private void button1_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);
            textBox1.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            array[i] = double.Parse(textBox2.Text);
            listBox1.Items.Add(array[i]);
            i++;
            textBox2.Text = "";
            if (i==n)
            {
                textBox2.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (i=0;i<array.Length;i++)
            {
                if (array[i]>0)
                {
                    listBox2.Items.Add(array[i]);
                }
            }
            listBox2.Items.Add("-------------");
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    listBox2.Items.Add(array[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
