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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResultadoAndar.Visible = true;
            lblResultadoCor.Visible = true;
            lblResultadoSalaEsquerda.Visible = true;
            lblResultadoSalaDireita.Visible = true;
            lblResultadoSituacao.Visible = true;
        }
    }
}
