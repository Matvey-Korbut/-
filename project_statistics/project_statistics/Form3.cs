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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string login = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
            
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            if (login == "test1")
            {
                if(password == "test1")
                {
                    this.Hide();
                    Form4 newForm = new Form4();
                    newForm.Show();



                }


            }
            else
            {
                MessageBox.Show("неверный логин или пароль");
                this.Hide();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
