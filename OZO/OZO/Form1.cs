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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            Ozosub1.Visible = false;
            Ozosub2.Visible = false;
            Ozosub3.Visible = false;
        }
        private void showSubMenu(Panel sub)
        {
            if (sub.Visible == false)
            {
                hideSubMenu();
                sub.Visible = true;
            }
            else
                sub.Visible = false;
        }
        private void Ozobtn1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(Ozosub1);
        }
        private void Ozobtn2_Click(object sender, EventArgs e)
        {
            showSubMenu(Ozosub2);
        }
        private void Ozobtn3_Click(object sender, EventArgs e)
        {
            showSubMenu(Ozosub3);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ShowChildForms.Controls.Add(childForm);
            ShowChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }
    }
}
