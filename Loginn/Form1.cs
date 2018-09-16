using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

            if (textBox1.Text == "")
            {
                MessageBox.Show("USERNAME Tidak Boleh Kosong!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("PASSWORD Tidak Boleh Kosong!");
            }
            else
            {
                if (textBox1.Text != "Mico" && textBox2.Text != "12345" || textBox1.Text != "armico" && textBox2.Text != "12345")
                {
                    MessageBox.Show("LOGIN GAGAL");
                }
                else
                {
                    MessageBox.Show("LOGIN BERHASIL");
                    Form2 form = new Form2();
                    form.Show();
                    this.Visible = false;
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
