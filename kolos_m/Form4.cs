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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tekst = richTextBox1.Text;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            File.WriteAllText(saveFileDialog.FileName, tekst);
        }

        private void button2_Click(object sender, EventArgs e) //nie moge dodac kolejnego przycisku bo scielo fest;/ a chcialam dac stop
        {
            string tekst;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            tekst = File.ReadAllText(openFileDialog.FileName);
            richTextBox1.Text = tekst;
        }
    }
}
