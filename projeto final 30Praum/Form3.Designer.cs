namespace projeto_final_30Praum
{
    partial class frm_seguranca
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
            this.lbl_nova_senha = new System.Windows.Forms.Label();
            this.txt_nova_senha = new Guna.UI2.WinForms.Guna2TextBox();
            this.chk_mostra = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_confirmar_senha = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_salvar = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_segurança = new System.Windows.Forms.Label();
            this.lbl_caracterers = new System.Windows.Forms.Label();
            this.btn_fechar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.chk_mostra1 = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nova_senha
            // 
            this.lbl_nova_senha.AutoSize = true;
            this.lbl_nova_senha.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nova_senha.ForeColor = System.Drawing.Color.White;
            this.lbl_nova_senha.Location = new System.Drawing.Point(351, 360);
            this.lbl_nova_senha.Name = "lbl_nova_senha";
            this.lbl_nova_senha.Size = new System.Drawing.Size(104, 19);
            this.lbl_nova_senha.TabIndex = 43;
            this.lbl_nova_senha.Text = "Nova Senha";
            // 
            // txt_nova_senha
            // 
            this.txt_nova_senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nova_senha.DefaultText = "";
            this.txt_nova_senha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nova_senha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nova_senha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nova_senha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nova_senha.Enabled = false;
            this.txt_nova_senha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nova_senha.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nova_senha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nova_senha.Location = new System.Drawing.Point(355, 383);
            this.txt_nova_senha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_nova_senha.MaxLength = 8;
            this.txt_nova_senha.Name = "txt_nova_senha";
            this.txt_nova_senha.PasswordChar = '*';
            this.txt_nova_senha.PlaceholderText = "";
            this.txt_nova_senha.SelectedText = "";
            this.txt_nova_senha.Size = new System.Drawing.Size(158, 36);
            this.txt_nova_senha.TabIndex = 42;
            this.txt_nova_senha.TextChanged += new System.EventHandler(this.txt_nova_senha_TextChanged);
            this.txt_nova_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nova_senha_KeyPress);
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
            this.chk_mostra.Location = new System.Drawing.Point(534, 383);
            this.chk_mostra.Name = "chk_mostra";
            this.chk_mostra.Size = new System.Drawing.Size(94, 23);
            this.chk_mostra.TabIndex = 41;
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
            this.label7.Location = new System.Drawing.Point(351, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(351, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Confirmar Senha";
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
            this.txt_nome.Location = new System.Drawing.Point(355, 299);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_nome.MaxLength = 30;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PlaceholderText = "";
            this.txt_nome.SelectedText = "";
            this.txt_nome.Size = new System.Drawing.Size(345, 36);
            this.txt_nome.TabIndex = 33;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // txt_confirmar_senha
            // 
            this.txt_confirmar_senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_confirmar_senha.DefaultText = "";
            this.txt_confirmar_senha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_confirmar_senha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_confirmar_senha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confirmar_senha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confirmar_senha.Enabled = false;
            this.txt_confirmar_senha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confirmar_senha.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmar_senha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confirmar_senha.Location = new System.Drawing.Point(355, 481);
            this.txt_confirmar_senha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_confirmar_senha.MaxLength = 8;
            this.txt_confirmar_senha.Name = "txt_confirmar_senha";
            this.txt_confirmar_senha.PasswordChar = '*';
            this.txt_confirmar_senha.PlaceholderText = "";
            this.txt_confirmar_senha.SelectedText = "";
            this.txt_confirmar_senha.Size = new System.Drawing.Size(158, 36);
            this.txt_confirmar_senha.TabIndex = 35;
            this.txt_confirmar_senha.TextChanged += new System.EventHandler(this.txt_confirmar_senha_TextChanged);
            this.txt_confirmar_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_confirmar_senha_KeyPress);
            // 
            // btn_salvar
            // 
            this.btn_salvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_salvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_salvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_salvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_salvar.FillColor = System.Drawing.Color.Blue;
            this.btn_salvar.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(669, 482);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(180, 45);
            this.btn_salvar.TabIndex = 34;
            this.btn_salvar.Text = "salvar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // lbl_segurança
            // 
            this.lbl_segurança.AutoSize = true;
            this.lbl_segurança.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_segurança.ForeColor = System.Drawing.Color.White;
            this.lbl_segurança.Location = new System.Drawing.Point(349, 108);
            this.lbl_segurança.Name = "lbl_segurança";
            this.lbl_segurança.Size = new System.Drawing.Size(430, 36);
            this.lbl_segurança.TabIndex = 44;
            this.lbl_segurança.Text = "Segurança e Identificação";
            // 
            // lbl_caracterers
            // 
            this.lbl_caracterers.AutoSize = true;
            this.lbl_caracterers.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caracterers.ForeColor = System.Drawing.Color.White;
            this.lbl_caracterers.Location = new System.Drawing.Point(12, 716);
            this.lbl_caracterers.Name = "lbl_caracterers";
            this.lbl_caracterers.Size = new System.Drawing.Size(210, 14);
            this.lbl_caracterers.TabIndex = 38;
            this.lbl_caracterers.Text = "A Senha Deve conter 8 Caracteres";
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
            this.btn_fechar.Location = new System.Drawing.Point(1138, 1);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(60, 45);
            this.btn_fechar.TabIndex = 45;
            this.btn_fechar.Text = "X";
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click_1);
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.Image = global::projeto_final_30Praum.Properties.Resources._30praum;
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(-1, 1);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(193, 170);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox5.TabIndex = 58;
            this.guna2PictureBox5.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::projeto_final_30Praum.Properties.Resources._30praum;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1005, 518);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(193, 170);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 59;
            this.guna2PictureBox1.TabStop = false;
            // 
            // chk_mostra1
            // 
            this.chk_mostra1.AutoSize = true;
            this.chk_mostra1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_mostra1.CheckedState.BorderRadius = 0;
            this.chk_mostra1.CheckedState.BorderThickness = 0;
            this.chk_mostra1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_mostra1.Enabled = false;
            this.chk_mostra1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_mostra1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk_mostra1.Location = new System.Drawing.Point(534, 481);
            this.chk_mostra1.Name = "chk_mostra1";
            this.chk_mostra1.Size = new System.Drawing.Size(94, 23);
            this.chk_mostra1.TabIndex = 60;
            this.chk_mostra1.Text = "Mostrar";
            this.chk_mostra1.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.chk_mostra1.UncheckedState.BorderRadius = 0;
            this.chk_mostra1.UncheckedState.BorderThickness = 0;
            this.chk_mostra1.UncheckedState.FillColor = System.Drawing.Color.White;
            this.chk_mostra1.CheckedChanged += new System.EventHandler(this.chk_mostra1_CheckedChanged);
            // 
            // frm_seguranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1198, 776);
            this.Controls.Add(this.chk_mostra1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2PictureBox5);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.lbl_segurança);
            this.Controls.Add(this.lbl_nova_senha);
            this.Controls.Add(this.txt_nova_senha);
            this.Controls.Add(this.chk_mostra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_caracterers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_confirmar_senha);
            this.Controls.Add(this.btn_salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_seguranca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frm_musica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nova_senha;
        private Guna.UI2.WinForms.Guna2TextBox txt_nova_senha;
        private Guna.UI2.WinForms.Guna2CheckBox chk_mostra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_nome;
        private Guna.UI2.WinForms.Guna2TextBox txt_confirmar_senha;
        private Guna.UI2.WinForms.Guna2Button btn_salvar;
        private System.Windows.Forms.Label lbl_segurança;
        private System.Windows.Forms.Label lbl_caracterers;
        private Guna.UI2.WinForms.Guna2Button btn_fechar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CheckBox chk_mostra1;
    }
}