
namespace MyLocker
{
    partial class FormRecuperarSenha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecuperarSenha));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.lblTrocarFotoPerfil = new System.Windows.Forms.Label();
            this.txtPesquisarArmario = new MyLocker.RJTextBox();
            this.rjTextBox1 = new MyLocker.RJTextBox();
            this.rjTextBox2 = new MyLocker.RJTextBox();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(805, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 76);
            this.label1.TabIndex = 14;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.rjTextBox2);
            this.guna2GroupBox1.Controls.Add(this.rjTextBox1);
            this.guna2GroupBox1.Controls.Add(this.txtPesquisarArmario);
            this.guna2GroupBox1.Controls.Add(this.btnConfirmar);
            this.guna2GroupBox1.Controls.Add(this.lblTrocarFotoPerfil);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1613, 1021);
            this.guna2GroupBox1.TabIndex = 15;
            this.guna2GroupBox1.Text = "guna2GroupBox1";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmar.BorderRadius = 20;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(574, 545);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(470, 87);
            this.btnConfirmar.TabIndex = 52;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTrocarFotoPerfil
            // 
            this.lblTrocarFotoPerfil.AllowDrop = true;
            this.lblTrocarFotoPerfil.AutoEllipsis = true;
            this.lblTrocarFotoPerfil.AutoSize = true;
            this.lblTrocarFotoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblTrocarFotoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrocarFotoPerfil.ForeColor = System.Drawing.Color.Black;
            this.lblTrocarFotoPerfil.Location = new System.Drawing.Point(589, 25);
            this.lblTrocarFotoPerfil.Name = "lblTrocarFotoPerfil";
            this.lblTrocarFotoPerfil.Size = new System.Drawing.Size(438, 61);
            this.lblTrocarFotoPerfil.TabIndex = 16;
            this.lblTrocarFotoPerfil.Text = "Recuperar Senha";
            // 
            // txtPesquisarArmario
            // 
            this.txtPesquisarArmario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtPesquisarArmario.BorderColor = System.Drawing.Color.Transparent;
            this.txtPesquisarArmario.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtPesquisarArmario.BorderRadius = 50;
            this.txtPesquisarArmario.BorderSize = 2;
            this.txtPesquisarArmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarArmario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPesquisarArmario.Location = new System.Drawing.Point(320, 132);
            this.txtPesquisarArmario.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtPesquisarArmario.Multiline = false;
            this.txtPesquisarArmario.Name = "txtPesquisarArmario";
            this.txtPesquisarArmario.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtPesquisarArmario.PasswordChar = false;
            this.txtPesquisarArmario.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.txtPesquisarArmario.PlaceholderText = "Pesquisar Armário (Número)";
            this.txtPesquisarArmario.Size = new System.Drawing.Size(1000, 106);
            this.txtPesquisarArmario.TabIndex = 58;
            this.txtPesquisarArmario.UnderlinedStyle = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.Transparent;
            this.rjTextBox1.BorderRadius = 50;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rjTextBox1.Location = new System.Drawing.Point(320, 277);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.rjTextBox1.PlaceholderText = "Pesquisar Armário (Número)";
            this.rjTextBox1.Size = new System.Drawing.Size(1000, 106);
            this.rjTextBox1.TabIndex = 59;
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.rjTextBox2.BorderColor = System.Drawing.Color.Transparent;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.Transparent;
            this.rjTextBox2.BorderRadius = 50;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rjTextBox2.Location = new System.Drawing.Point(320, 412);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.rjTextBox2.PlaceholderText = "Pesquisar Armário (Número)";
            this.rjTextBox2.Size = new System.Drawing.Size(1000, 106);
            this.rjTextBox2.TabIndex = 60;
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // FormRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRecuperarSenha";
            this.Text = "MyLocker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnConfirmar;
        private System.Windows.Forms.Label lblTrocarFotoPerfil;
        private RJTextBox rjTextBox2;
        private RJTextBox rjTextBox1;
        private RJTextBox txtPesquisarArmario;
    }
}