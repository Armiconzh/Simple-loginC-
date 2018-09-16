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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.PasswordChar = '*';
            textBox7.PasswordChar = '*';

            if (textBox1.Text == "")
            {
                MessageBox.Show("[NAMA LENGKAP] Tidak Boleh Kosong");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("[TTL] Tidak Boleh Kosong");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("[KONTAK] Tidak Boleh Kosong");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("[ALAMAT] Tidak Boleh Kosong");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("[USERNAME] Tidak Boleh Kosong");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("[PASSWORD] Tidak Boleh Kosong");
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("[CONFIRM] Tidak Boleh Kosong");
            }
            else if (textBox7.Text != textBox6.Text)
            {
                MessageBox.Show("CONFIRM PASSWORD TIDAK COCOK");
            }
            else
            {
                MessageBox.Show("REGISTRASI BERHASIL");
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
