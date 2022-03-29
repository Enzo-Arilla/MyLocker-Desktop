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

namespace MyLocker
{
    public partial class Form2 : Form
    {
        MySqlConnection connection;
        string cpf, senha, nameDB, emailDB, cpfDB, senhaDB;

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                cpf = rjTextBox1.Text;
                senha = rjTextBox2.Text;

                MySqlCommand handleLogin = new MySqlCommand("select Name, Email, CPF, Password from functionary where CPF = '" + rjTextBox1.Text + "'", connection);
                MySqlDataReader readLogin = handleLogin.ExecuteReader();

                if (readLogin.Read())
                {

                    nameDB = readLogin["Name"].ToString();
                    emailDB = readLogin["Email"].ToString();
                    cpfDB = readLogin["CPF"].ToString();
                    senhaDB = readLogin["Password"].ToString();

                    Usuario usuario = new Usuario(nameDB, emailDB, cpfDB);

                    if (cpf==cpfDB && senha==senhaDB)
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

            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                connection.Close();
            }
          
        }
    }
}
