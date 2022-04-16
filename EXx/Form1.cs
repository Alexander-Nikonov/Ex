using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 4 && textBox1.Text.Length <= 50)
            {

            }
            else
            {
                MessageBox.Show("Введите корректное название");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 10 && textBox2.Text.Length <= 35)
            {

            }
            else
            {
                MessageBox.Show("Введите корректное название");
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            int col = Convert.ToInt32(textBox3.Text);
            if (col <= 0)
            {
                MessageBox.Show("Количество не может быть отрицательным");
            }
        }
    }
}
