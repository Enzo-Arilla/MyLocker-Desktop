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
    public partial class Form3 : Form
    {
        MySqlConnection connection;
        string email, cpf, senha, cSenha;

        public Form3()
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                email = rjTextBox1.Text;
                cpf = rjTextBox2.Text;
                senha = rjTextBox3.Text;
                cSenha = rjTextBox4.Text;

                if (senha != cSenha)
                {
                    MyMessageBox.ShowBox("Você inseriu senhas diferentes!", "Erro - As senhas não estão iguais");
                }
                else
                {
                    MySqlCommand register = new MySqlCommand("insert into functionary (email, first_name, last_name, cpf, password) values ('" + rjTextBox1.Text + "', '" + rjTextBox5.Text + "','" + rjTextBox6.Text + "','" + rjTextBox2.Text + "','" + rjTextBox3.Text + "')", connection);
                    register.ExecuteNonQuery();
                    MyMessageBox.ShowBox("Você se cadastrou com sucesso!", "Sucesso - Você cadastrou sua conta");
                    connection.Close();
                    this.Hide();
                    var form2 = new Form2();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();


                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Focus();
        }

        /*
        private void clean()
        {
            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "CPF";
            }

            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "CPF";
            }

            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "CPF";
            }

            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "CPF";
            }

            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "CPF";
            }
        }
        */

        private void rjTextBox1_Enter(object sender, EventArgs e)
        {

            if (rjTextBox1.PlaceholderText == "E-mail")
            {
                rjTextBox1.PlaceholderText = "";
                rjTextBox1.ForeColor = Color.Black;
            }

            if (rjTextBox2.Text == "")
            {
                rjTextBox2.PlaceholderText = "CPF";
            }

            if (rjTextBox3.Text == "")
            {
                rjTextBox3.PlaceholderText = "Senha";
            }

            if (rjTextBox4.Text == "")
            {
                rjTextBox4.PlaceholderText = "Confirmar Senha";
            }

            if (rjTextBox5.Text == "")
            {
                rjTextBox5.PlaceholderText = "Nome";
            }

            if (rjTextBox6.Text == "")
            {
                rjTextBox6.PlaceholderText = "Último Nome";
            }

        }

        private void rjTextBox2_Enter(object sender, EventArgs e)
        {
            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "E-mail";
            }

            if (rjTextBox2.PlaceholderText == "CPF")
            {
                rjTextBox2.PlaceholderText = "";
                rjTextBox2.ForeColor = Color.Black;
            }

            if (rjTextBox3.Text == "")
            {
                rjTextBox3.PlaceholderText = "Senha";
            }

            if (rjTextBox4.Text == "")
            {
                rjTextBox4.PlaceholderText = "Confirmar Senha";
            }

            if (rjTextBox5.Text == "")
            {
                rjTextBox5.PlaceholderText = "Nome";
            }

            if (rjTextBox6.Text == "")
            {
                rjTextBox6.PlaceholderText = "Último Nome";
            }
        }

        private void rjTextBox3_Enter(object sender, EventArgs e)
        {
            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "E-mail";
            }

            if (rjTextBox2.Text == "")
            {
                rjTextBox2.PlaceholderText = "CPF";
            }

            if (rjTextBox3.PlaceholderText == "Senha")
            {
                rjTextBox3.PlaceholderText = "";
                rjTextBox3.ForeColor = Color.Black;
            }

            if (rjTextBox4.Text == "")
            {
                rjTextBox4.PlaceholderText = "Confirmar Senha";
            }

            if (rjTextBox5.Text == "")
            {
                rjTextBox5.PlaceholderText = "Nome";
            }

            if (rjTextBox6.Text == "")
            {
                rjTextBox6.PlaceholderText = "Último Nome";
            }

        }

        private void rjTextBox4_Enter(object sender, EventArgs e)
        {
            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "E-mail";
            }

            if (rjTextBox2.Text == "")
            {
                rjTextBox2.PlaceholderText = "CPF";
            }

            if (rjTextBox3.Text == "")
            {
                rjTextBox3.PlaceholderText = "Senha";
            }

            if (rjTextBox4.PlaceholderText == "Confirmar Senha")
            {
                rjTextBox4.PlaceholderText = "";
                rjTextBox4.ForeColor = Color.Black;
            }

            if (rjTextBox5.Text == "")
            {
                rjTextBox5.PlaceholderText = "Nome";
            }

            if (rjTextBox6.Text == "")
            {
                rjTextBox6.PlaceholderText = "Último Nome";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjTextBox5_Enter(object sender, EventArgs e)
        {
            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "E-mail";
            }

            if (rjTextBox2.Text == "")
            {
                rjTextBox3.PlaceholderText = "CPF";
            }

            if (rjTextBox3.Text == "")
            {
                rjTextBox3.PlaceholderText = "Senha";
            }

            if (rjTextBox4.Text == "")
            {
                rjTextBox4.PlaceholderText = "Confirmar Senha";
            }

            if (rjTextBox5.PlaceholderText == "Nome")
            {
                rjTextBox5.PlaceholderText = "";
                rjTextBox5.ForeColor = Color.Black;
            }

            if (rjTextBox6.Text == "")
            {
                rjTextBox6.PlaceholderText = "Último Nome";
            }

        }

        private void rjTextBox6_Enter(object sender, EventArgs e)
        {
            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "E-mail";
            }

            if (rjTextBox2.Text == "")
            {
                rjTextBox2.PlaceholderText = "CPF";
            }

            if (rjTextBox3.Text == "")
            {
                rjTextBox3.PlaceholderText = "Senha";
            }

            if (rjTextBox4.Text == "")
            {
                rjTextBox4.PlaceholderText = "Confirmar Senha";
            }

            if (rjTextBox5.Text == "")
            {
                rjTextBox5.PlaceholderText = "Nome";
            }

            if (rjTextBox6.PlaceholderText == "Último Nome")
            {
                rjTextBox6.PlaceholderText = "";
                rjTextBox6.ForeColor = Color.Black;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
