using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
using Refit;

namespace MyLocker
{
    public partial class FormRecuperarSenhaPerfil : Form
    {
        string email, codigo, novaSenha;

        public FormRecuperarSenhaPerfil()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblFoco.Focus();
            txtCodigo.PasswordChar = true;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {

        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {

        }

        private void txtNovaSenha_Enter(object sender, EventArgs e)
        {

        }
















    }
}
