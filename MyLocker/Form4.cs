﻿using System;
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
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
