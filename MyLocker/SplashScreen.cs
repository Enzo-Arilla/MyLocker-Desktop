using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna;

namespace MyLocker
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 12;
            if (panel3.Width >= 1300)
            {
                timer1.Stop();
                FormLogin FormLogin = new FormLogin();
                FormLogin.Show();
                this.Hide();
            }
        }
    }
}
