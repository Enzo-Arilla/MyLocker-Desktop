using Refit;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        async private void Form6_Load(object sender, EventArgs e)
        {
            Armario[] armarios = null;
            armarios  = await ListArmarios();

            foreach(Armario a in armarios) {
                //MessageBox.Show(a.Number.ToString());
                string[] row = new string[]{a.Number.ToString()};
                guna2DataGridView1.Rows.Add(row);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                rjTextBox1.Visible = true;
                guna2Button2.Visible = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form5 = new Form5();
            form5.Closed += (s, args) => this.Close();
            form5.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            var form7 = new Form7();
            form7.Closed += (s, args) => this.Close();
            form7.Show();
            this.Hide();
        }

        static async Task<Armario[]> ListArmarios()
        {
            var apiClient = RestService.For<IRepositorioArmarios>("https://mylocker-api.herokuapp.com");

            Armario[] response = await apiClient.ListArmarios();

            return response;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
