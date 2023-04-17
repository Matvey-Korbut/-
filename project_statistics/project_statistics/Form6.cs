using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_statistics
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string login2 = textBox1.Text;
            string password2 = textBox2.Text;
            if (login2 == "test2")
            {
                if (password2 == "test2")
                {
                    this.Hide();
                    Form7 newForm = new Form7();
                    newForm.Show();



                }


            }
            else
            {
                MessageBox.Show("Не правильно веден логин или пароль");
                this.Hide();
            }

        }
    }
}
