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
    public partial class frm_musicas: Form
    {
        public frm_musicas()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_matue_Click(object sender, EventArgs e)
        {
            frm_reproducao matue = new frm_reproducao();
            matue.Show();
            Hide();
        }

        private void btn_teto_Click(object sender, EventArgs e)
        {
            forms_teto teto = new forms_teto();
            teto.Show();
            Hide();
        }

        private void btn_brandao_Click(object sender, EventArgs e)
        {
            forms_brandao brandao = new forms_brandao();
            brandao.Show();
            Hide();
        }

        private void btn_wiu_Click(object sender, EventArgs e)
        {
            forms_wiu wiu = new forms_wiu();
            wiu.Show();
            Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frm_abertura abertura = new frm_abertura();
            abertura.Show();
            Hide();
        }
    }
}
