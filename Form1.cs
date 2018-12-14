using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string code;
        int count;

        public Form1()
        {
            InitializeComponent();
            code = "";
            count = 0;
        }

        private void processClick(int value)
        {
            if (count < 4)
            {
                string str = value.ToString();
                code = code + str;
                textBox1.Text +="* ";
                count++;
                if (count == 4)
                {
                    button12.Enabled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            processClick(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            processClick(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            processClick(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            processClick(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            processClick(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            processClick(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            processClick(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            processClick(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            processClick(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            processClick(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            count = 0;
            code = "";
            textBox1.Text = "";
            button12.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
