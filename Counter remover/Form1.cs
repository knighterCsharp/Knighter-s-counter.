using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter_remover
{
    public partial class Form1 : Form
    {

        private int counter;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter += 1;
            button1.Text = counter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter -= 1;
            button1.Text = counter.ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string textBox1 = ("knighter's counter, made in 2021");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
