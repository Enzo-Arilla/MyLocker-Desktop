using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MyLocker
{
    public partial class Form4 : Form
    {
        MySqlConnection connection;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                label2.Text = Usuario.getName(); 
            }
            catch (Exception erro)
            {

            }
            finally
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if(panel2.Visible == false)
            {
                label3.ForeColor = Color.FromArgb(253, 200, 0);
                label4.ForeColor = Color.White;
                panel3.Visible = true;
                panel5.Visible = true;
                panel2.Visible = true;
                panel4.Visible = false;
                panel7.Visible = false;
            }
            else if(panel2.Visible == true)
            {
                label3.ForeColor = Color.White;
                panel3.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(panel7.Visible == false)
            {
                label4.ForeColor = Color.FromArgb(253, 200, 0);
                label3.ForeColor = Color.White;
                panel4.Visible = true;
                panel7.Visible = true;
                panel3.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
            }
            else if(panel7.Visible == true)
            {
                label4.ForeColor = Color.White;
                panel4.Visible = false;
                panel7.Visible = false;
            }
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            var form7 = new Form7();
            form7.Closed += (s, args) => this.Close();
            form7.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var form8 = new Form8();
            form8.Closed += (s, args) => this.Close();
            form8.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var form9 = new Form9();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            if(panel6.Visible == false)
            {
                panel6.Visible = true;
                panel8.Visible = true;
                panel9.Visible = true;
                panel11.Visible = true;
            }
            else
            {
                panel6.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel11.Visible = false;
            }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            var form10 = new Form10();
            form10.FormClosed += (s, args) => this.Close();
            form10.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            var form11 = new Form11();
            form11.FormClosed += (s, args) => this.Close();
            form11.Show();
            this.Hide();
        }
    }
}
