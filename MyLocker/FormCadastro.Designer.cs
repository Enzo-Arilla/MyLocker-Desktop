
namespace MyLocker
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.lblCriarConta = new System.Windows.Forms.Label();
            this.imgPanel = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblFoco = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.txtUltimoNome = new MyLocker.RJTextBox();
            this.txtNome = new MyLocker.RJTextBox();
            this.txtConfirmarSenha = new MyLocker.RJTextBox();
            this.txtSenha = new MyLocker.RJTextBox();
            this.txtCpf = new MyLocker.RJTextBox();
            this.txtEmail = new MyLocker.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCriarConta
            // 
            this.lblCriarConta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCriarConta.AutoSize = true;
            this.lblCriarConta.Font = new System.Drawing.Font("Roboto", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarConta.ForeColor = System.Drawing.Color.White;
            this.lblCriarConta.Location = new System.Drawing.Point(543, 395);
            this.lblCriarConta.Name = "lblCriarConta";
            this.lblCriarConta.Size = new System.Drawing.Size(371, 81);
            this.lblCriarConta.TabIndex = 6;
            this.lblCriarConta.Text = "Criar Conta";
            // 
            // imgPanel
            // 
            this.imgPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgPanel.Image = ((System.Drawing.Image)(resources.GetObject("imgPanel.Image")));
            this.imgPanel.Location = new System.Drawing.Point(0, 339);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(1440, 10);
            this.imgPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgPanel.TabIndex = 5;
            this.imgPanel.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(1440, 339);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLogo.TabIndex = 4;
            this.imgLogo.TabStop = false;
            // 
            // lblFoco
            // 
            this.lblFoco.AutoSize = true;
            this.lblFoco.Location = new System.Drawing.Point(325, 366);
            this.lblFoco.Name = "lblFoco";
            this.lblFoco.Size = new System.Drawing.Size(0, 13);
            this.lblFoco.TabIndex = 31;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(69, 53);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(186, 94);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVoltar.TabIndex = 32;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1218, 53);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(161, 94);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 33;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastrar.BorderRadius = 20;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Roboto", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(1238, 950);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(275, 87);
            this.btnCadastrar.TabIndex = 52;
            this.btnCadastrar.Text = "Registrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtUltimoNome
            // 
            this.txtUltimoNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUltimoNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtUltimoNome.BorderColor = System.Drawing.Color.Transparent;
            this.txtUltimoNome.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtUltimoNome.BorderRadius = 12;
            this.txtUltimoNome.BorderSize = 2;
            this.txtUltimoNome.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUltimoNome.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUltimoNome.Location = new System.Drawing.Point(748, 523);
            this.txtUltimoNome.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtUltimoNome.Multiline = false;
            this.txtUltimoNome.Name = "txtUltimoNome";
            this.txtUltimoNome.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtUltimoNome.PasswordChar = false;
            this.txtUltimoNome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUltimoNome.PlaceholderText = "Último Nome";
            this.txtUltimoNome.Size = new System.Drawing.Size(761, 109);
            this.txtUltimoNome.TabIndex = 30;
            this.txtUltimoNome.UnderlinedStyle = false;
            this.txtUltimoNome.Enter += new System.EventHandler(this.txtUltimoNome_Enter);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.Transparent;
            this.txtNome.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtNome.BorderRadius = 12;
            this.txtNome.BorderSize = 2;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNome.Location = new System.Drawing.Point(-67, 523);
            this.txtNome.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.Size = new System.Drawing.Size(761, 109);
            this.txtNome.TabIndex = 29;
            this.txtNome.UnderlinedStyle = false;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConfirmarSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmarSenha.BorderColor = System.Drawing.Color.Transparent;
            this.txtConfirmarSenha.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtConfirmarSenha.BorderRadius = 12;
            this.txtConfirmarSenha.BorderSize = 2;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(748, 809);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtConfirmarSenha.Multiline = false;
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtConfirmarSenha.PasswordChar = false;
            this.txtConfirmarSenha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConfirmarSenha.PlaceholderText = "Confirmar Senha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(761, 109);
            this.txtConfirmarSenha.TabIndex = 28;
            this.txtConfirmarSenha.UnderlinedStyle = false;
            this.txtConfirmarSenha.Enter += new System.EventHandler(this.txtConfirmarSenha_Enter);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.BorderColor = System.Drawing.Color.Transparent;
            this.txtSenha.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtSenha.BorderRadius = 12;
            this.txtSenha.BorderSize = 2;
            this.txtSenha.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtSenha.Location = new System.Drawing.Point(-67, 809);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtSenha.PasswordChar = false;
            this.txtSenha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSenha.PlaceholderText = "Senha";
            this.txtSenha.Size = new System.Drawing.Size(761, 109);
            this.txtSenha.TabIndex = 27;
            this.txtSenha.UnderlinedStyle = false;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCpf.BackColor = System.Drawing.SystemColors.Window;
            this.txtCpf.BorderColor = System.Drawing.Color.Transparent;
            this.txtCpf.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtCpf.BorderRadius = 12;
            this.txtCpf.BorderSize = 2;
            this.txtCpf.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCpf.Location = new System.Drawing.Point(748, 666);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtCpf.Multiline = false;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtCpf.PasswordChar = false;
            this.txtCpf.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCpf.PlaceholderText = "CPF";
            this.txtCpf.Size = new System.Drawing.Size(761, 109);
            this.txtCpf.TabIndex = 26;
            this.txtCpf.UnderlinedStyle = false;
            this.txtCpf.Enter += new System.EventHandler(this.txtCpf_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderRadius = 12;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtEmail.Location = new System.Drawing.Point(-67, 666);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "E-mail";
            this.txtEmail.Size = new System.Drawing.Size(761, 109);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.UnderlinedStyle = false;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblFoco);
            this.Controls.Add(this.txtUltimoNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCriarConta);
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLocker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCriarConta;
        private System.Windows.Forms.PictureBox imgPanel;
        private System.Windows.Forms.PictureBox imgLogo;
        private RJTextBox txtEmail;
        private RJTextBox txtCpf;
        private RJTextBox txtSenha;
        private RJTextBox txtConfirmarSenha;
        private RJTextBox txtNome;
        private RJTextBox txtUltimoNome;
        private System.Windows.Forms.Label lblFoco;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.PictureBox btnSair;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar;
    }
}