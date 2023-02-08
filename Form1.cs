using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фибоначчи
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            if (textBox1.Text != string.Empty && textBox1.Text.All(char.IsDigit))
            {
                int n = Convert.ToInt32(textBox1.Text);
                for(int i=1;i <= n; i++)
                {
                    richTextBox1.Text += $"{Convert.ToInt32(Fibonachi(i))} ";
                }
            }
            else richTextBox1.Text = "Кол-во чисел задано неправильно!";
            
            
        }
    }
}
