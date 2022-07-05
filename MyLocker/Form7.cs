using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Refit;

namespace MyLocker
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        static async Task<Armario[]> ListArmarios()
        {
            var apiClient = RestService.For<IRepositorioArmarios>("https://mylocker-api.herokuapp.com");

            Armario[] response = await apiClient.ListArmarios();

            return response;
        }

        async private void Form7_Load(object sender, EventArgs e)
        {
            Armario[] armarios = null;
            armarios = await ListArmarios();

            foreach (Armario a in armarios)
            {
                //MessageBox.Show(a.Number.ToString());
                string[] row = new string[] { a.Number.ToString() };
                guna2DataGridView1.Rows.Add(row);
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var form8 = new Form8();
            form8.Closed += (s, args) => this.Close();
            form8.Show();
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
                panel7.Visible = false;
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
                panel7.Visible = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var form9 = new Form9();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

            if (panel3.Visible == false)
            {
                panel3.Visible = true;
                panel8.Visible = true;
                panel9.Visible = true;
                panel11.Visible = true;
            }
            else if (panel3.Visible == true)
            {
                panel3.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel11.Visible = false;
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            var form10 = new Form10();
            form10.Closed += (s, args) => this.Close();
            form10.Show();
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            var form11 = new Form11();
            form11.FormClosed += (s, args) => this.Close();
            form11.Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex==2 && e.RowIndex>=0)
            {
                int number = e.RowIndex;
                string number2 = guna2DataGridView1[0, number].Value.ToString();
                MessageBox.Show("Teste:" + number2);
            }
           
        }

        private void guna2DataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex>=0)
            {
                guna2DataGridView1.Cursor = Cursors.Hand;
            }
            else
            {
                guna2DataGridView1.Cursor = Cursors.Arrow;
            }
        }
    }
}
