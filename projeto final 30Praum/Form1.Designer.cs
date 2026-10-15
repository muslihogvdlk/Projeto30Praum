namespace projeto_final_30Praum
{
    partial class Frm_cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_confirmar = new Guna.UI2.WinForms.Guna2Button();
            this.txt_senha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_cadastro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_ja_tem_cadastro = new System.Windows.Forms.LinkLabel();
            this.chk_mostra = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_fechar = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_apelido = new System.Windows.Forms.Label();
            this.txt_apelido = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_confirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_confirmar.FillColor = System.Drawing.Color.Blue;
            this.btn_confirmar.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(747, 485);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(180, 45);
            this.btn_confirmar.TabIndex = 0;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_senha.DefaultText = "";
            this.txt_senha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_senha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_senha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_senha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_senha.Enabled = false;
            this.txt_senha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_senha.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.txt_senha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_senha.Location = new System.Drawing.Point(433, 485);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_senha.MaxLength = 8;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.PlaceholderText = "";
            this.txt_senha.SelectedText = "";
            this.txt_senha.Size = new System.Drawing.Size(158, 36);
            this.txt_senha.TabIndex = 1;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            this.txt_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_senha_KeyPress);
            // 
            // txt_nome
            // 
            this.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nome.DefaultText = "";
            this.txt_nome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nome.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nome.Location = new System.Drawing.Point(431, 268);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_nome.MaxLength = 30;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PlaceholderText = "";
            this.txt_nome.SelectedText = "";
            this.txt_nome.Size = new System.Drawing.Size(345, 36);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // lbl_cadastro
            // 
            this.lbl_cadastro.AutoSize = true;
            this.lbl_cadastro.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastro.ForeColor = System.Drawing.Color.White;
            this.lbl_cadastro.Location = new System.Drawing.Point(532, 86);
            this.lbl_cadastro.Name = "lbl_cadastro";
            this.lbl_cadastro.Size = new System.Drawing.Size(161, 36);
            this.lbl_cadastro.TabIndex = 3;
            this.lbl_cadastro.Text = "Cadastro";
            this.lbl_cadastro.Click += new System.EventHandler(this.lbl_cadastro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(429, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(453, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "8 caracteres";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(427, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nome Completo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_ja_tem_cadastro
            // 
            this.lbl_ja_tem_cadastro.AutoSize = true;
            this.lbl_ja_tem_cadastro.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ja_tem_cadastro.ForeColor = System.Drawing.Color.White;
            this.lbl_ja_tem_cadastro.Location = new System.Drawing.Point(597, 555);
            this.lbl_ja_tem_cadastro.Name = "lbl_ja_tem_cadastro";
            this.lbl_ja_tem_cadastro.Size = new System.Drawing.Size(148, 19);
            this.lbl_ja_tem_cadastro.TabIndex = 10;
            this.lbl_ja_tem_cadastro.TabStop = true;
            this.lbl_ja_tem_cadastro.Text = "Já tem Cadastro?";
            this.lbl_ja_tem_cadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_ja_tem_cadastro_LinkClicked);
            // 
            // chk_mostra
            // 
            this.chk_mostra.AutoSize = true;
            this.chk_mostra.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_mostra.CheckedState.BorderRadius = 0;
            this.chk_mostra.CheckedState.BorderThickness = 0;
            this.chk_mostra.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_mostra.Enabled = false;
            this.chk_mostra.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_mostra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk_mostra.Location = new System.Drawing.Point(601, 498);
            this.chk_mostra.Name = "chk_mostra";
            this.chk_mostra.Size = new System.Drawing.Size(94, 23);
            this.chk_mostra.TabIndex = 11;
            this.chk_mostra.Text = "Mostrar";
            this.chk_mostra.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.chk_mostra.UncheckedState.BorderRadius = 0;
            this.chk_mostra.UncheckedState.BorderThickness = 0;
            this.chk_mostra.UncheckedState.FillColor = System.Drawing.Color.White;
            this.chk_mostra.CheckedChanged += new System.EventHandler(this.chk_mostra_CheckedChanged);
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = global::projeto_final_30Praum.Properties.Resources._30praum;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(1003, 604);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(193, 170);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 17;
            this.guna2PictureBox4.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::projeto_final_30Praum.Properties.Resources._30praum;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-5, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(193, 170);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BorderRadius = 25;
            this.btn_fechar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_fechar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_fechar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_fechar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_fechar.FillColor = System.Drawing.Color.Black;
            this.btn_fechar.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btn_fechar.ForeColor = System.Drawing.Color.Red;
            this.btn_fechar.Location = new System.Drawing.Point(1136, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(60, 45);
            this.btn_fechar.TabIndex = 19;
            this.btn_fechar.Text = "X";
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click_1);
            this.btn_fechar.MouseLeave += new System.EventHandler(this.btn_fecahr_MouseLeave);
            this.btn_fechar.MouseHover += new System.EventHandler(this.btn_fecahr_MouseHover);
            // 
            // lbl_apelido
            // 
            this.lbl_apelido.AutoSize = true;
            this.lbl_apelido.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apelido.ForeColor = System.Drawing.Color.White;
            this.lbl_apelido.Location = new System.Drawing.Point(429, 351);
            this.lbl_apelido.Name = "lbl_apelido";
            this.lbl_apelido.Size = new System.Drawing.Size(73, 19);
            this.lbl_apelido.TabIndex = 21;
            this.lbl_apelido.Text = "Apelido";
            this.lbl_apelido.Click += new System.EventHandler(this.lbl_apelido_Click);
            // 
            // txt_apelido
            // 
            this.txt_apelido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_apelido.DefaultText = "";
            this.txt_apelido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_apelido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_apelido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_apelido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_apelido.Enabled = false;
            this.txt_apelido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_apelido.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apelido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_apelido.Location = new System.Drawing.Point(433, 374);
            this.txt_apelido.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_apelido.MaxLength = 30;
            this.txt_apelido.Name = "txt_apelido";
            this.txt_apelido.PlaceholderText = "";
            this.txt_apelido.SelectedText = "";
            this.txt_apelido.Size = new System.Drawing.Size(345, 36);
            this.txt_apelido.TabIndex = 20;
            this.txt_apelido.TextChanged += new System.EventHandler(this.txt_apelido_TextChanged);
            this.txt_apelido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apelido_KeyPress);
            // 
            // Frm_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1198, 776);
            this.Controls.Add(this.lbl_apelido);
            this.Controls.Add(this.txt_apelido);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.guna2PictureBox4);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.chk_mostra);
            this.Controls.Add(this.lbl_ja_tem_cadastro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_cadastro);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.btn_confirmar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_confirmar;
        private Guna.UI2.WinForms.Guna2TextBox txt_senha;
        private Guna.UI2.WinForms.Guna2TextBox txt_nome;
        private System.Windows.Forms.Label lbl_cadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lbl_ja_tem_cadastro;
        private Guna.UI2.WinForms.Guna2CheckBox chk_mostra;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2Button btn_fechar;
        private System.Windows.Forms.Label lbl_apelido;
        private Guna.UI2.WinForms.Guna2TextBox txt_apelido;
    }
}

