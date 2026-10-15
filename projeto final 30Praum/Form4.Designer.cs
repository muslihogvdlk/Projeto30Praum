namespace projeto_final_30Praum
{
    partial class frm_abertura
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
            this.btn_fechar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_entrar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_cadastro = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.BorderRadius = 20;
            this.btn_fechar.BorderThickness = 5;
            this.btn_fechar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_fechar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_fechar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_fechar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_fechar.FillColor = System.Drawing.Color.Black;
            this.btn_fechar.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btn_fechar.ForeColor = System.Drawing.Color.Red;
            this.btn_fechar.Location = new System.Drawing.Point(1140, 2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(60, 45);
            this.btn_fechar.TabIndex = 21;
            this.btn_fechar.Text = "X";
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BorderColor = System.Drawing.Color.White;
            this.btn_entrar.BorderThickness = 5;
            this.btn_entrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_entrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_entrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_entrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_entrar.FillColor = System.Drawing.Color.Black;
            this.btn_entrar.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btn_entrar.ForeColor = System.Drawing.Color.White;
            this.btn_entrar.Location = new System.Drawing.Point(200, 359);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(180, 45);
            this.btn_entrar.TabIndex = 22;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::projeto_final_30Praum.Properties.Resources._30praum;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(448, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(287, 285);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 24;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.BorderColor = System.Drawing.Color.White;
            this.btn_cadastro.BorderThickness = 5;
            this.btn_cadastro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cadastro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cadastro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cadastro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cadastro.FillColor = System.Drawing.Color.Black;
            this.btn_cadastro.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btn_cadastro.ForeColor = System.Drawing.Color.White;
            this.btn_cadastro.Location = new System.Drawing.Point(787, 359);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(180, 45);
            this.btn_cadastro.TabIndex = 26;
            this.btn_cadastro.Text = "Cadastrar";
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // frm_abertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1198, 776);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.btn_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_abertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_fechar;
        private Guna.UI2.WinForms.Guna2Button btn_entrar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_cadastro;
    }
}