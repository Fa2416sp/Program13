using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i, j;
        string stroka;
        public string[] b = new string[20];
        public int k;

        private void button1_Click(object sender, EventArgs e)
        {
            k = 0;
            stroka = textBox1.Text;
            string[] b = stroka.Split(' ');
            foreach (string word in b)
            {
                listBox1.Items.Add(word);
                k += 1;
            }
            textBox2.Text = k.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] b = stroka.Split(' ');
            Array.Sort(b);
            foreach (string word in b)
            {
                listBox2.Items.Add(word);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stroka = textBox1.Text;
            string[] b = stroka.Split(' ');
            Array.Reverse(b);
            k = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < k; i++)
            {
                if (b[i].Length > 3)
                {
                    listBox3.Items.Add(b[i].Remove(3));
                }
            }
        }
    }
}