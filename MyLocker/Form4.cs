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
            try
            {
                connection = new MySqlConnection(global_variables.bdConnnection);
            }
            catch
            {
                MessageBox.Show("Falha na Conexão");
            }
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
                panel3.Visible = true;
                panel5.Visible = true;
                panel2.Visible = true;
                panel4.Visible = false;
                panel7.Visible = false;
            }
            else if(panel2.Visible == true)
            {
                panel3.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(panel7.Visible == false)
            {
                panel4.Visible = true;
                panel7.Visible = true;
                panel3.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
            }
            else if(panel7.Visible == true)
            {
                panel4.Visible = false;
                panel7.Visible = false;
            }
        }
    }
}
