using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;
using System.Text;
using System.Security.Cryptography;
using BC = BCrypt.Net.BCrypt ;
using Refit;

namespace MyLocker
{
    public partial class Form2 : Form
    {
        MySqlConnection connection;
        string cpf, senha, first_nameDB, last_nameDB, emailDB, cpfDB, senhaDB;
        Funcionario funcionario;

        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                cpf = rjTextBox1.Text;
                senha = rjTextBox2.Text;

                Funcionario funcionario = await GetFuncionario(cpf);

                Usuario usuario = new Usuario(funcionario.First_name, funcionario.Last_name, funcionario.Email, funcionario.Cpf, funcionario.Status);


                if (BC.Verify(senha, funcionario.Password))
                {
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                }
                else
                {
                    MyMessageBox.ShowBox("Você inseriu dados incorretos!", "Erro - Credênciais Incorretas");
                }

            }
            catch (ApiException erro)
            {
                string[] mensagemErro = erro.Content.Split('"');
                MessageBox.Show(mensagemErro[3]);
            }
            finally
            {
                connection.Close();
            }
        }

        private void rjTextBox1_Enter(object sender, EventArgs e)
        {
            if (rjTextBox1.PlaceholderText == "CPF")
            {
                rjTextBox1.PlaceholderText = "";
                rjTextBox1.ForeColor = Color.Black;
            }

            if (rjTextBox2.Text == "")
            {
                rjTextBox2.PlaceholderText = "Senha";
            }
        }

        private void rjTextBox2_Enter(object sender, EventArgs e)
        {
            if (rjTextBox2.PlaceholderText == "Senha")
            {
                rjTextBox2.PlaceholderText = "";
                rjTextBox2.ForeColor = Color.Black;
            }

            if (rjTextBox1.Text == "")
            {
                rjTextBox1.PlaceholderText = "CPF";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private async void pictureBox5_Click(object sender, EventArgs e)
        {
            
            

        }

        static async Task<Funcionario> GetFuncionario(string cpf) {
            var apiClient = RestService.For<IRepositorioFuncionarios>("http://localhost:3333");

            Funcionario response = await apiClient.ReturnFuncionario(cpf);

            return response;
        }

        static async Task<Funcionario> GetFunctionaries(string cpf)
        {
            var apiClient = RestService.For<IRepositorioFuncionarios>("http://localhost:3333");
            Funcionario response = await apiClient.ReturnFuncionario(cpf);

            return response;
        }
    }
}
