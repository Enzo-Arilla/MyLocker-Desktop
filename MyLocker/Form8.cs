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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label7.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel3.Visible = true;
                panel5.Visible = true;
                panel2.Visible = true;
                panel2.BringToFront();
                panel4.Visible = false;
                panel7.Visible = false;
               
            }
            else if (panel2.Visible == true)
            {
                panel3.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == false)
            {
                panel4.Visible = true;
                panel4.BringToFront();
                panel7.Visible = true;
                panel7.BringToFront();
                panel3.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
                
            }
            else if (panel7.Visible == true)
            {
                panel4.Visible = false;
                panel7.Visible = false;
             
            }
        }

        private void rjTextBox1_Enter(object sender, EventArgs e)
        {

            if (rjTextBox1.PlaceholderText == "RA do aluno")
            {
                rjTextBox1.PlaceholderText = "";
                rjTextBox1.ForeColor = Color.Black;
            }

            if (rjTextBox2.Text == "")
            {
                rjTextBox2.PlaceholderText = "E-mail do aluno";
            }

            if (rjTextBox3.Text == "")
            {
                rjTextBox3.PlaceholderText = "Primeiro nome";
            }

            if (rjTextBox4.Text == "")
            {
                rjTextBox4.PlaceholderText = "Último nome";
            }
        }

        private void rjTextBox2_Enter(object sender, EventArgs e)
        {
            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "RA do aluno";
            }

            if (rjTextBox2.PlaceholderText == "E-mail do aluno")
            {
                rjTextBox2.PlaceholderText = "";
                rjTextBox2.ForeColor = Color.Black;
            }

            if (rjTextBox3.Text == "")
            {
                rjTextBox3.PlaceholderText = "Primeiro nome";
            }

            if (rjTextBox4.Text == "")
            {
                rjTextBox4.PlaceholderText = "Último nome";
            }
        }

        private void rjTextBox3_Enter(object sender, EventArgs e)
        {
            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "RA do aluno";
            }

            if (rjTextBox2.Text == "")
            {
                rjTextBox2.PlaceholderText = "E-mail do aluno";
            }

            if (rjTextBox3.PlaceholderText == "Primeiro nome")
            {
                rjTextBox3.PlaceholderText = "";
                rjTextBox3.ForeColor = Color.Black;
            }

            if (rjTextBox4.Text == "")
            {
                rjTextBox4.PlaceholderText = "Último nome";
            }
        }

        private void rjTextBox4_Enter(object sender, EventArgs e)
        {
            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "RA do aluno";
            }

            if (rjTextBox2.Text == "")
            {
                rjTextBox2.PlaceholderText = "E-mail do aluno";
            }

            if (rjTextBox3.Text == "")
            {
                rjTextBox3.PlaceholderText = "Primeiro nome";
            }

            if (rjTextBox4.PlaceholderText == "Último nome")
            {
                rjTextBox4.PlaceholderText = "";
                rjTextBox4.ForeColor = Color.Black;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            myLabel1.Text = "Registrar Aluno";
            guna2Button2.Text = "Registrar";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            myLabel1.Text = "Editar Aluno";
            guna2Button2.Text = "Editar";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            myLabel1.Text = "Apagar Aluno";
            guna2Button2.Text = "Apagar";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
