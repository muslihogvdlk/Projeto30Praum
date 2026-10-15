using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace projeto_final_30Praum
{
    public partial class forms_wiu: Form
    {
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        public forms_wiu()
        {
            InitializeComponent();
        }

        List<string> manual = new List<string>();//criando uma lista de string(textos) com o nome mqt para guardar o caminho da musica 
        int indiceAtual_mcae = 0;//variavel int q guarda qual posição esta tocando na lista de musicas 

        List<string> vagabundo = new List<string>();
        int indiceAtual_vdl = 0;

        List<string> club_808 = new List<string>();
        int indiceAtual_808 = 0;

        private string nome_Simples(string caminho)
        {
            return Path.GetFileNameWithoutExtension(caminho);//funçao pronta que elimina o caminho do nome das musicas como (audios,debug...).
        }


        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void forms_wiu_Load(object sender, EventArgs e)
        {

            // colocando as musicas em sua playlist(listas de reprodução)
            manual.Add("audios/PREFÁCIO(MP3_160K).mp3");
            manual.Add("audios/Oração(MP3_160K).mp3");
            manual.Add("audios/Ciumenta(MP3_160K).mp3");
            manual.Add("audios/Frio(MP3_160K).mp3");
            manual.Add("audios/Página 47_ Pague na mesma moeda(MP3_160K).mp3"); 
            manual.Add("audios/Lealdade(MP3_160K).mp3");
            manual.Add("audios/Avião no Céu(MP3_160K).mp3");
            manual.Add("audios/Página 119_ Sai pra noite_ vai_(MP3_160K).mp3");
            manual.Add("audios/Coração de Gelo(MP3_160K).mp3");
            manual.Add("audios/Angelina(MP3_160K).mp3");
            

            


            club_808.Add("audios/MUNDO DO WIU(MP3_160K).mp3");
            club_808.Add("audios/FREESTYLE DE LUXO (feat. Yunk Vino)(MP3_160K).mp3");
            club_808.Add("audios/RUAS DE FORTAL (feat. Brandão85)(MP3_160K).mp3");
            club_808.Add("audios/OXIGÊNIO (feat. Lil Mosey)(MP3_160K).mp3");
            club_808.Add("audios/LUÍSA SONZA(MP3_160K).mp3");
            club_808.Add("audios/CHICK(MP3_160K).mp3");
            club_808.Add("audios/PUTO (feat. Alee)(MP3_160K).mp3");
            club_808.Add("audios/POUQUINHO DA MINHA VIBE (feat. Japa)(MP3_160K).mp3");



            vagabundo.Add("audios/Medo de Quem_(MP3_160K).mp3");
            vagabundo.Add("audios/Casa do Tio Wiu(MP3_160K).mp3");
            vagabundo.Add("audios/Rainha da Finesse(MP3_160K).mp3");
            vagabundo.Add("audios/Vidigal(MP3_160K).mp3");
            vagabundo.Add("audios/Amor de 1h(MP3_160K).mp3");
            vagabundo.Add("audios/Se eu ver sua mãe na rua(MP3_160K).mp3");
            vagabundo.Add("audios/desgraçadagostosamaldita(MP3_160K).mp3");
            vagabundo.Add("audios/Teimosa(MP3_160K).mp3");
            vagabundo.Add("audios/Olha oq ce fez comigo(MP3_160K).mp3");
            vagabundo.Add("audios/Guala(MP3_160K).mp3");
            vagabundo.Add("audios/Maria do Olho Verde(MP3_160K).mp3");
            vagabundo.Add("audios/Eu Não Ouço Mais Trap(MP3_160K).mp3");
            vagabundo.Add("audios/Rolê de Sempre(MP3_160K).mp3");
            

        }

        private void btn_proxima_mdae_Click(object sender, EventArgs e)
        {
            if (manual .Count == 0) return;//condição para ir para as proximas musicas

            indiceAtual_mcae++;

            if (indiceAtual_mcae >= manual .Count)
                indiceAtual_mcae = 0; // Volta para a primeira música (ou você pode parar aqui)

            wmp.URL = manual [indiceAtual_mcae];
            lbl_sua_musica.Text = nome_Simples(manual [indiceAtual_mcae]);
        }

        private void btn_anterior_mdae_Click(object sender, EventArgs e)
        {
            if (manual .Count == 0) return;

            indiceAtual_mcae--;

            if (indiceAtual_mcae < 0)
                indiceAtual_mcae = manual .Count - 1;

            wmp.URL = manual [indiceAtual_mcae];
            lbl_sua_musica.Text = nome_Simples(manual[indiceAtual_mcae]);
        }

        private void btn_iniciar_mqt_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/PREFÁCIO(MP3_160K).mp3";
            lbl_sua_musica.Text = "Prefacio";
        }

        private void btn_next_vagabundo_Click(object sender, EventArgs e)
        {
            if (vagabundo .Count == 0) return;//condição para ir para as proximas musicas

            indiceAtual_vdl++;

            if (indiceAtual_vdl >= vagabundo .Count)
                indiceAtual_vdl = 0; // Volta para a primeira música (ou você pode parar aqui)

            wmp.URL = vagabundo [indiceAtual_vdl];
            lbl_sua_musica.Text = nome_Simples(vagabundo [indiceAtual_vdl]);
        }

        private void btn_voltar_vagabundo_Click(object sender, EventArgs e)
        {
            if (vagabundo .Count == 0) return;

            indiceAtual_vdl--;

            if (indiceAtual_vdl < 0)
                indiceAtual_vdl = vagabundo .Count - 1;

            wmp.URL = vagabundo [indiceAtual_vdl];
            lbl_sua_musica.Text = nome_Simples(vagabundo[indiceAtual_vdl]);
        }

        private void btn_iniciar_vagabundo_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Medo de Quem_(MP3_160K).mp3";
            lbl_sua_musica.Text = "Medo de Quem";
        }

        private void btn_next_808_Click(object sender, EventArgs e)
        {
            if (club_808 .Count == 0) return;//condição para ir para as proximas musicas

            indiceAtual_808++;

            if (indiceAtual_808 >= club_808 .Count)
                indiceAtual_808 = 0; // Volta para a primeira música (ou você pode parar aqui)

            wmp.URL = club_808 [indiceAtual_808];
            lbl_sua_musica.Text = nome_Simples(club_808 [indiceAtual_808]);
        }

        private void btn_voltar_808_Click(object sender, EventArgs e)
        {
            if (club_808 .Count == 0) return;

            indiceAtual_808--;

            if (indiceAtual_808 < 0)
                indiceAtual_808 = club_808 .Count - 1;

            wmp.URL = club_808 [indiceAtual_808];
            lbl_sua_musica.Text = nome_Simples(club_808[indiceAtual_808]);
        }

        private void btn_qm_manda30_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Rainha da Finesse(MP3_160K).mp3";
            lbl_sua_musica.Text = "Rainha da Finesse";
        }

        private void btn_peca_em_peca_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Vampiro - Matuê.mp3";
            lbl_sua_musica.Text = "Vampiro ";
        }

        private void btn_pausar_geral_Click(object sender, EventArgs e)
        {
            if (wmp.playState == WMPPlayState.wmppsPlaying)
            {
                wmp.controls.pause();

            }
            else if (wmp.playState == WMPPlayState.wmppsPaused)
            {
                wmp.controls.play();
            }
        }

        private void btn_iniciar_808_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/MUNDO DO WIU(MP3_160K).mp3";
            lbl_sua_musica.Text = "MUNDO DO WIU";

        }

        private void btn_morte_autotune_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/WIU_ Teto - Problemas de um Milionário(MP3_160K).mp3";
            lbl_sua_musica.Text = "Problemas de um Milionário";


        }

        private void btn_vampiro_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/WIU _ Oruam - Horas Iguais 🕰️💐(MP3_160K).mp3";
            lbl_sua_musica.Text = "Horas Iguais";
        }

        private void btn_anos_luz_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/WIU - Lágrimas de Crocodilo 🐊(MP3_160K).mp3";
            lbl_sua_musica.Text = "Lágrimas de Crocodilo";
        }

        private void btn_kennyG_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/WIU _ Ryan SP - Felina 🐈(MP3_160K).mp3";
            lbl_sua_musica.Text = "Felina";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frm_musicas musicas = new frm_musicas();
            musicas.Show();
            wmp.controls.stop();
            Hide();
        }
    }
}
