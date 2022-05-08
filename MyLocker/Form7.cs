using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLocker
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form5 = new Form5();
            form5.Closed += (s, args) => this.Close();
            form5.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var form6 = new Form6();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel4.Visible = true;
                panel5.Visible = true;
                panel2.Visible = true;
                panel4.Visible = false;
            }
            else if (panel2.Visible == true)
            {
                panel5.Visible = false;
                panel2.Visible = false;
                panel7.Visible = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == false)
            {
                panel4.Visible = true;
                panel7.Visible = true;
                panel5.Visible = false;
                panel2.Visible = false;
            }
            else if (panel7.Visible == true)
            {
                panel4.Visible = false;
                panel2.Visible = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
