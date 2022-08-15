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
    public partial class Carregamento : Form
    {
        public Carregamento()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public void WaitForm(Form parent)
        {
            InitializeComponent();
            if(parent!=null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Location.X + parent.Width / 2 - this.Width / 2, parent.Location.Y + parent.Height / 2 - this.Height / 2);
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterParent;
            }
        }

        public void CloseWaitForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void Carregamento_Load(object sender, EventArgs e)
        {

            AnimacaoLoad.Location = new Point(this.Width / 2 - AnimacaoLoad.Width / 2, this.Height / 2 - AnimacaoLoad.Width / 2);
        }
    }
}
