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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label7.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel4.Visible = true;
                panel5.Visible = true;
                panel5.BringToFront();
                panel2.Visible = true;
                panel4.Visible = false;
                panel7.Visible = false;
            }
            else if (panel2.Visible == true)
            {
                label1.Visible = true;
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
                panel2.Visible = false;
            }
            else if (panel7.Visible == true)
            {
                panel7.Visible = false;
                panel4.Visible = false;
                panel2.Visible = false;
            }
        }

        private void rjTextBox1_Enter(object sender, EventArgs e)
        {
            if (rjTextBox1.PlaceholderText == "RA do Aluno")
            {
                rjTextBox1.PlaceholderText = "";
                rjTextBox1.ForeColor = Color.Black;
            }

            if (rjTextBox5.Text == "")
            {
                rjTextBox5.PlaceholderText = "Número do Armário";
            }
        }

        private void rjTextBox5_Enter(object sender, EventArgs e)
        {
            if (rjTextBox5.PlaceholderText == "Número do Armário")
            {
                rjTextBox5.PlaceholderText = "";
                rjTextBox5.ForeColor = Color.Black;
            }

            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "RA do Aluno";
            }


        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox5__TextChanged(object sender, EventArgs e)
        {
            if (rjTextBox5.Text == Convert.ToString(832))
            {
                guna2CircleButton1.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                guna2Button2.Visible = true;
            }
            else
            {
                guna2CircleButton1.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                guna2Button2.Visible = false;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var form6 = new Form6();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
            this.Hide();
        }

        private void guna2Button5_Click_2(object sender, EventArgs e)
        {
            var form7 = new Form7();
            form7.Closed += (s, args) => this.Close();
            form7.Show();
            this.Hide();
        }
    }
}
