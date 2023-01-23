using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolos_m
{
    public partial class Form5 : Form
    {
        int sec;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sec = Convert.ToInt32(textBox1.Text);
            textBox1.Enabled = false;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = sec--.ToString();
            if(sec<0)
            {
                timer1.Stop();
                textBox1.Enabled = true;
            }    
        }
    }
}
