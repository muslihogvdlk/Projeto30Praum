using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_final_30Praum
{
    public partial class frm_abertura: Form
    {
        public frm_abertura()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
            Hide();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Frm_cadastro cadastro = new Frm_cadastro ();
            cadastro .Show();
            Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            Frm_cadastro cadastro   = new Frm_cadastro ();
            cadastro.Show();
            Hide();
        }
    }
}
