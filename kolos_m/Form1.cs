using Microsoft.VisualBasic.Logging;

namespace kolos_m
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.Text == "eloelo" && password.Text == "320") //matma
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            if (login.Text == "chce" && password.Text == "spac") //filozofia
            {
                Form4 f4 = new Form4();
                f4.Show();
            }
            else
                MessageBox.Show("Wrong login or password");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}