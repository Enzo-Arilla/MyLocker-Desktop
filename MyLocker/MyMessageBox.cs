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
    public partial class MyMessageBox : Form
    {
        static MyMessageBox newMessageBox;
        static string Buttin_ID;

        public MyMessageBox()
        {
            InitializeComponent();
        }

        public static string ShowBox(string txtMessage)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.label2.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Buttin_ID;
        }

        public static string ShowBox(string txtMessage, string txtTitle)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.label1.Text = txtTitle;
            newMessageBox.label2.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Buttin_ID;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
