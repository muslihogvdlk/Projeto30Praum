namespace projeto_final_30Praum
{
    partial class frm_login
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
            this.chk_mostra = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_esqueceu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.txt_nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_senha = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_entrar = new Guna.UI2.WinForms.Guna2Button();
            this.txt_apelido = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_apelido = new System.Windows.Forms.Label();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.chk_mostra.Location = new System.Drawing.Point(523, 458);
            this.chk_mostra.Name = "chk_mostra";
            this.chk_mostra.Size = new System.Drawing.Size(94, 23);
            this.chk_mostra.TabIndex = 30;
            this.chk_mostra.Text = "Mostrar";
            this.chk_mostra.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.chk_mostra.UncheckedState.BorderRadius = 0;
            this.chk_mostra.UncheckedState.BorderThickness = 0;
            this.chk_mostra.UncheckedState.FillColor = System.Drawing.Color.White;
            this.chk_mostra.CheckedChanged += new System.EventHandler(this.chk_mostra_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(351, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Nome Completo";
            // 
            // lbl_esqueceu
            // 
            this.lbl_esqueceu.AutoSize = true;
            this.lbl_esqueceu.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_esqueceu.ForeColor = System.Drawing.Color.White;
            this.lbl_esqueceu.Location = new System.Drawing.Point(360, 485);
            this.lbl_esqueceu.Name = "lbl_esqueceu";
            this.lbl_esqueceu.Size = new System.Drawing.Size(127, 14);
            this.lbl_esqueceu.TabIndex = 27;
            this.lbl_esqueceu.Text = "Esqueceu sua Senha";
            this.lbl_esqueceu.Click += new System.EventHandler(this.lbl_esqueceu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(351, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Senha";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(562, 9);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(105, 36);
            this.lbl_login.TabIndex = 25;
            this.lbl_login.Text = "Login";
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
            this.txt_nome.Location = new System.Drawing.Point(355, 229);
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
            this.txt_senha.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_senha.Location = new System.Drawing.Point(355, 445);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_senha.MaxLength = 8;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.PlaceholderText = "";
            this.txt_senha.SelectedText = "";
            this.txt_senha.Size = new System.Drawing.Size(158, 36);
            this.txt_senha.TabIndex = 24;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            this.txt_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_senha_KeyPress);
            // 
            // btn_entrar
            // 
            this.btn_entrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_entrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_entrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_entrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_entrar.FillColor = System.Drawing.Color.Blue;
            this.btn_entrar.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.btn_entrar.ForeColor = System.Drawing.Color.White;
            this.btn_entrar.Location = new System.Drawing.Point(669, 445);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(180, 45);
            this.btn_entrar.TabIndex = 23;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
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
            this.txt_apelido.Location = new System.Drawing.Point(355, 333);
            this.txt_apelido.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_apelido.MaxLength = 30;
            this.txt_apelido.Name = "txt_apelido";
            this.txt_apelido.PlaceholderText = "";
            this.txt_apelido.SelectedText = "";
            this.txt_apelido.Size = new System.Drawing.Size(345, 36);
            this.txt_apelido.TabIndex = 31;
            this.txt_apelido.TextChanged += new System.EventHandler(this.txt_apelido_TextChanged);
            this.txt_apelido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apelido_KeyPress);
            // 
            // lbl_apelido
            // 
            this.lbl_apelido.AutoSize = true;
            this.lbl_apelido.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apelido.ForeColor = System.Drawing.Color.White;
            this.lbl_apelido.Location = new System.Drawing.Point(351, 311);
            this.lbl_apelido.Name = "lbl_apelido";
            this.lbl_apelido.Size = new System.Drawing.Size(73, 19);
            this.lbl_apelido.TabIndex = 32;
            this.lbl_apelido.Text = "Apelido";
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.Image = global::projeto_final_30Praum.Properties.Resources._30praum;
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(-2, 0);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(193, 170);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox5.TabIndex = 57;
            this.guna2PictureBox5.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::projeto_final_30Praum.Properties.Resources._30praum;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1003, 606);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(193, 170);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 58;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 25;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Red;
            this.guna2Button1.Location = new System.Drawing.Point(1136, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(60, 45);
            this.guna2Button1.TabIndex = 59;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1198, 776);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2PictureBox5);
            this.Controls.Add(this.lbl_apelido);
            this.Controls.Add(this.txt_apelido);
            this.Controls.Add(this.chk_mostra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_esqueceu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.btn_entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CheckBox chk_mostra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_esqueceu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_login;
        private Guna.UI2.WinForms.Guna2TextBox txt_nome;
        private Guna.UI2.WinForms.Guna2TextBox txt_senha;
        private Guna.UI2.WinForms.Guna2Button btn_entrar;
        private Guna.UI2.WinForms.Guna2TextBox txt_apelido;
        private System.Windows.Forms.Label lbl_apelido;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}