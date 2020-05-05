using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OZO
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            password.BackgroundImage = Properties.Resources.passwordclick;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(78, 184, 206);

            user.BackgroundImage = Properties.Resources.user1_64x64;
            panel1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            user.BackgroundImage = Properties.Resources.userclick;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);

            password.BackgroundImage = Properties.Resources.pngwave;
            panel2.BackColor = Color.White;
            textBox2.ForeColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
