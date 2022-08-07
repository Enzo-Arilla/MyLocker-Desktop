
namespace MyLocker
{
    partial class Form1
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
            this.btnAlugar = new Guna.UI2.WinForms.Guna2Button();
            this.lblAlugarArmario = new System.Windows.Forms.Label();
            this.lblResultadoCor = new System.Windows.Forms.Label();
            this.btnDisponibilidade = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblSalaDireita = new System.Windows.Forms.Label();
            this.lblSalaEsquerda = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblAndar = new System.Windows.Forms.Label();
            this.txtRaAluno = new MyLocker.RJTextBox();
            this.txtNumeroArmario = new MyLocker.RJTextBox();
            this.cbPossuiApm = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.lblPossuiApm = new System.Windows.Forms.Label();
            this.lblDadosArmario = new System.Windows.Forms.Label();
            this.lblResultadoAndar = new System.Windows.Forms.Label();
            this.lblResultadoSalaEsquerda = new System.Windows.Forms.Label();
            this.lblResultadoSalaDireita = new System.Windows.Forms.Label();
            this.lblResultadoSituacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlugar
            // 
            this.btnAlugar.BorderRadius = 20;
            this.btnAlugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlugar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlugar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlugar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlugar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlugar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnAlugar.Font = new System.Drawing.Font("Roboto", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlugar.ForeColor = System.Drawing.Color.Black;
            this.btnAlugar.Location = new System.Drawing.Point(637, 717);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(275, 87);
            this.btnAlugar.TabIndex = 67;
            this.btnAlugar.Text = "Alugar";
            // 
            // lblAlugarArmario
            // 
            this.lblAlugarArmario.AllowDrop = true;
            this.lblAlugarArmario.AutoEllipsis = true;
            this.lblAlugarArmario.AutoSize = true;
            this.lblAlugarArmario.BackColor = System.Drawing.Color.Transparent;
            this.lblAlugarArmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlugarArmario.ForeColor = System.Drawing.Color.Black;
            this.lblAlugarArmario.Location = new System.Drawing.Point(180, 243);
            this.lblAlugarArmario.Name = "lblAlugarArmario";
            this.lblAlugarArmario.Size = new System.Drawing.Size(380, 61);
            this.lblAlugarArmario.TabIndex = 53;
            this.lblAlugarArmario.Text = "Alugar Armário";
            // 
            // lblResultadoCor
            // 
            this.lblResultadoCor.AutoSize = true;
            this.lblResultadoCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblResultadoCor.Location = new System.Drawing.Point(1292, 363);
            this.lblResultadoCor.Name = "lblResultadoCor";
            this.lblResultadoCor.Size = new System.Drawing.Size(223, 54);
            this.lblResultadoCor.TabIndex = 65;
            this.lblResultadoCor.Text = "Vermelho";
            this.lblResultadoCor.Visible = false;
            // 
            // btnDisponibilidade
            // 
            this.btnDisponibilidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnDisponibilidade.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDisponibilidade.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDisponibilidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDisponibilidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDisponibilidade.FillColor = System.Drawing.Color.Lime;
            this.btnDisponibilidade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDisponibilidade.ForeColor = System.Drawing.Color.Transparent;
            this.btnDisponibilidade.Location = new System.Drawing.Point(830, 363);
            this.btnDisponibilidade.Name = "btnDisponibilidade";
            this.btnDisponibilidade.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDisponibilidade.Size = new System.Drawing.Size(65, 65);
            this.btnDisponibilidade.TabIndex = 64;
            this.btnDisponibilidade.Visible = false;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.ForeColor = System.Drawing.Color.Black;
            this.lblSituacao.Location = new System.Drawing.Point(1187, 573);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(218, 54);
            this.lblSituacao.TabIndex = 63;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblSalaDireita
            // 
            this.lblSalaDireita.AutoSize = true;
            this.lblSalaDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaDireita.ForeColor = System.Drawing.Color.Black;
            this.lblSalaDireita.Location = new System.Drawing.Point(1187, 499);
            this.lblSalaDireita.Name = "lblSalaDireita";
            this.lblSalaDireita.Size = new System.Drawing.Size(276, 54);
            this.lblSalaDireita.TabIndex = 62;
            this.lblSalaDireita.Text = "Sala Direita:";
            // 
            // lblSalaEsquerda
            // 
            this.lblSalaEsquerda.AutoSize = true;
            this.lblSalaEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaEsquerda.ForeColor = System.Drawing.Color.Black;
            this.lblSalaEsquerda.Location = new System.Drawing.Point(1187, 429);
            this.lblSalaEsquerda.Name = "lblSalaEsquerda";
            this.lblSalaEsquerda.Size = new System.Drawing.Size(342, 54);
            this.lblSalaEsquerda.TabIndex = 61;
            this.lblSalaEsquerda.Text = "Sala Esquerda:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.ForeColor = System.Drawing.Color.Black;
            this.lblCor.Location = new System.Drawing.Point(1187, 357);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(112, 54);
            this.lblCor.TabIndex = 60;
            this.lblCor.Text = "Cor:";
            // 
            // lblAndar
            // 
            this.lblAndar.AutoSize = true;
            this.lblAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndar.ForeColor = System.Drawing.Color.Black;
            this.lblAndar.Location = new System.Drawing.Point(1187, 287);
            this.lblAndar.Name = "lblAndar";
            this.lblAndar.Size = new System.Drawing.Size(161, 54);
            this.lblAndar.TabIndex = 59;
            this.lblAndar.Text = "Andar:";
            // 
            // txtRaAluno
            // 
            this.txtRaAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtRaAluno.BorderColor = System.Drawing.Color.Transparent;
            this.txtRaAluno.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtRaAluno.BorderRadius = 50;
            this.txtRaAluno.BorderSize = 2;
            this.txtRaAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaAluno.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtRaAluno.Location = new System.Drawing.Point(164, 479);
            this.txtRaAluno.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtRaAluno.Multiline = false;
            this.txtRaAluno.Name = "txtRaAluno";
            this.txtRaAluno.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtRaAluno.PasswordChar = false;
            this.txtRaAluno.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.txtRaAluno.PlaceholderText = "RA do Aluno";
            this.txtRaAluno.Size = new System.Drawing.Size(761, 109);
            this.txtRaAluno.TabIndex = 55;
            this.txtRaAluno.UnderlinedStyle = false;
            // 
            // txtNumeroArmario
            // 
            this.txtNumeroArmario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtNumeroArmario.BorderColor = System.Drawing.Color.Transparent;
            this.txtNumeroArmario.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtNumeroArmario.BorderRadius = 50;
            this.txtNumeroArmario.BorderSize = 2;
            this.txtNumeroArmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroArmario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNumeroArmario.Location = new System.Drawing.Point(164, 342);
            this.txtNumeroArmario.Margin = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.txtNumeroArmario.Multiline = false;
            this.txtNumeroArmario.Name = "txtNumeroArmario";
            this.txtNumeroArmario.Padding = new System.Windows.Forms.Padding(24, 25, 24, 25);
            this.txtNumeroArmario.PasswordChar = false;
            this.txtNumeroArmario.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.txtNumeroArmario.PlaceholderText = "Número do Armário";
            this.txtNumeroArmario.Size = new System.Drawing.Size(761, 109);
            this.txtNumeroArmario.TabIndex = 54;
            this.txtNumeroArmario.UnderlinedStyle = false;
            // 
            // cbPossuiApm
            // 
            this.cbPossuiApm.BackColor = System.Drawing.Color.Transparent;
            this.cbPossuiApm.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPossuiApm.CheckedState.BorderRadius = 2;
            this.cbPossuiApm.CheckedState.BorderThickness = 0;
            this.cbPossuiApm.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPossuiApm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPossuiApm.ForeColor = System.Drawing.Color.White;
            this.cbPossuiApm.Location = new System.Drawing.Point(530, 653);
            this.cbPossuiApm.Name = "cbPossuiApm";
            this.cbPossuiApm.Size = new System.Drawing.Size(20, 20);
            this.cbPossuiApm.TabIndex = 57;
            this.cbPossuiApm.Text = "guna2CustomCheckBox1";
            this.cbPossuiApm.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbPossuiApm.UncheckedState.BorderRadius = 2;
            this.cbPossuiApm.UncheckedState.BorderThickness = 0;
            this.cbPossuiApm.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbPossuiApm.UseTransparentBackground = true;
            // 
            // lblPossuiApm
            // 
            this.lblPossuiApm.AutoSize = true;
            this.lblPossuiApm.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPossuiApm.Location = new System.Drawing.Point(180, 632);
            this.lblPossuiApm.Name = "lblPossuiApm";
            this.lblPossuiApm.Size = new System.Drawing.Size(344, 61);
            this.lblPossuiApm.TabIndex = 56;
            this.lblPossuiApm.Text = "Possui APM?";
            // 
            // lblDadosArmario
            // 
            this.lblDadosArmario.AutoSize = true;
            this.lblDadosArmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosArmario.Location = new System.Drawing.Point(1185, 187);
            this.lblDadosArmario.Name = "lblDadosArmario";
            this.lblDadosArmario.Size = new System.Drawing.Size(451, 61);
            this.lblDadosArmario.TabIndex = 58;
            this.lblDadosArmario.Text = "Dados do Armário";
            // 
            // lblResultadoAndar
            // 
            this.lblResultadoAndar.AutoSize = true;
            this.lblResultadoAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoAndar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblResultadoAndar.Location = new System.Drawing.Point(1349, 292);
            this.lblResultadoAndar.Name = "lblResultadoAndar";
            this.lblResultadoAndar.Size = new System.Drawing.Size(223, 54);
            this.lblResultadoAndar.TabIndex = 68;
            this.lblResultadoAndar.Text = "Vermelho";
            this.lblResultadoAndar.Visible = false;
            // 
            // lblResultadoSalaEsquerda
            // 
            this.lblResultadoSalaEsquerda.AutoSize = true;
            this.lblResultadoSalaEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSalaEsquerda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblResultadoSalaEsquerda.Location = new System.Drawing.Point(1521, 429);
            this.lblResultadoSalaEsquerda.Name = "lblResultadoSalaEsquerda";
            this.lblResultadoSalaEsquerda.Size = new System.Drawing.Size(223, 54);
            this.lblResultadoSalaEsquerda.TabIndex = 69;
            this.lblResultadoSalaEsquerda.Text = "Vermelho";
            this.lblResultadoSalaEsquerda.Visible = false;
            // 
            // lblResultadoSalaDireita
            // 
            this.lblResultadoSalaDireita.AutoSize = true;
            this.lblResultadoSalaDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSalaDireita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblResultadoSalaDireita.Location = new System.Drawing.Point(1469, 499);
            this.lblResultadoSalaDireita.Name = "lblResultadoSalaDireita";
            this.lblResultadoSalaDireita.Size = new System.Drawing.Size(223, 54);
            this.lblResultadoSalaDireita.TabIndex = 70;
            this.lblResultadoSalaDireita.Text = "Vermelho";
            this.lblResultadoSalaDireita.Visible = false;
            // 
            // lblResultadoSituacao
            // 
            this.lblResultadoSituacao.AutoSize = true;
            this.lblResultadoSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lblResultadoSituacao.Location = new System.Drawing.Point(1411, 573);
            this.lblResultadoSituacao.Name = "lblResultadoSituacao";
            this.lblResultadoSituacao.Size = new System.Drawing.Size(223, 54);
            this.lblResultadoSituacao.TabIndex = 71;
            this.lblResultadoSituacao.Text = "Vermelho";
            this.lblResultadoSituacao.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 851);
            this.Controls.Add(this.lblResultadoSituacao);
            this.Controls.Add(this.lblResultadoSalaDireita);
            this.Controls.Add(this.lblResultadoSalaEsquerda);
            this.Controls.Add(this.lblResultadoAndar);
            this.Controls.Add(this.btnAlugar);
            this.Controls.Add(this.lblAlugarArmario);
            this.Controls.Add(this.lblResultadoCor);
            this.Controls.Add(this.btnDisponibilidade);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblSalaDireita);
            this.Controls.Add(this.lblSalaEsquerda);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblAndar);
            this.Controls.Add(this.txtRaAluno);
            this.Controls.Add(this.txtNumeroArmario);
            this.Controls.Add(this.cbPossuiApm);
            this.Controls.Add(this.lblPossuiApm);
            this.Controls.Add(this.lblDadosArmario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAlugar;
        private System.Windows.Forms.Label lblAlugarArmario;
        private System.Windows.Forms.Label lblResultadoCor;
        private Guna.UI2.WinForms.Guna2CircleButton btnDisponibilidade;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblSalaDireita;
        private System.Windows.Forms.Label lblSalaEsquerda;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblAndar;
        private RJTextBox txtRaAluno;
        private RJTextBox txtNumeroArmario;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cbPossuiApm;
        private System.Windows.Forms.Label lblPossuiApm;
        private System.Windows.Forms.Label lblDadosArmario;
        private System.Windows.Forms.Label lblResultadoAndar;
        private System.Windows.Forms.Label lblResultadoSalaEsquerda;
        private System.Windows.Forms.Label lblResultadoSalaDireita;
        private System.Windows.Forms.Label lblResultadoSituacao;
    }
}