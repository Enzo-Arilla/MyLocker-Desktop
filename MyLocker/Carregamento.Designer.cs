
namespace MyLocker
{
    partial class Carregamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carregamento));
            this.AnimacaoLoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AnimacaoLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimacaoLoad
            // 
            this.AnimacaoLoad.Image = ((System.Drawing.Image)(resources.GetObject("AnimacaoLoad.Image")));
            this.AnimacaoLoad.Location = new System.Drawing.Point(211, -42);
            this.AnimacaoLoad.Name = "AnimacaoLoad";
            this.AnimacaoLoad.Size = new System.Drawing.Size(360, 480);
            this.AnimacaoLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AnimacaoLoad.TabIndex = 0;
            this.AnimacaoLoad.TabStop = false;
            // 
            // Carregamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnimacaoLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carregamento";
            this.Opacity = 0.8D;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Carregamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnimacaoLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AnimacaoLoad;
    }
}