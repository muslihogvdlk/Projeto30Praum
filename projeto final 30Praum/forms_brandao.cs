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
    public partial class forms_brandao: Form
    {
        WindowsMediaPlayer wmp=new WindowsMediaPlayer();


        public forms_brandao()
        {
            InitializeComponent();
        }

        List<string> ceo = new List<string>();
        int indiceAtual_ceo = 0;

        List<string> isso_trap = new List<string>();
        int indiceAtual_trap = 0;

        List<string> zoo = new List<string>();
        int indiceAtual_zoo = 0;

        private string nome_Simples (string caminho)
        {
            return Path.GetFileNameWithoutExtension(caminho);//funçao pronta que elimina o caminho do nome das musicas como (audios,debug...).
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void forms_brandao_Load(object sender, EventArgs e)
        {
            ceo.Add("audios/Brandão - DE VOLTA(MP3_160K).mp3");
            ceo.Add("audios/Brandão - ESPAÇONAVE ft. WIU _ Matuê(MP3_160K).mp3");
            ceo.Add("audios/Brandão - DESTAQUE(MP3_160K).mp3");
            ceo.Add("audios/Brandão - LAMBORGHINI(MP3_160K).mp3");
            ceo.Add("audios/Brandão - ASTRAL(MP3_160K).mp3");
            ceo.Add("audios/Brandão - COLETE(MP3_160K).mp3");
            ceo.Add("audios/Brandão - LÁBIA(MP3_160K).mp3");
            ceo.Add("audios/Brandão - EURO LIBRA ft. Teto(MP3_160K).mp3");
            ceo.Add("audios/Brandão - CEO(MP3_160K).mp3");
            ceo.Add("audios/Brandão - ZIPLOCK(MP3_160K).mp3");
            ceo.Add("audios/Brandão - MODELO CUBANA(MP3_160K).mp3");
            ceo.Add("audios/Brandão - EM DIREÇÃO DO SOL ft. Alee(MP3_160K).mp3");
            ceo.Add("audios/MELHOR FASE(MP3_160K).mp3");
            


            isso_trap.Add("audios/BRANDÃO85 - BOLANDO UM PLANO(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - 100_ MOLHO FT. JOVEM DEX_ LEVIANO E ALEE(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - TRAPLIFE(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - JUICY(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - JOGO ELA NO JATINHO(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - ACIMA DAS NUVENS FT. DESIREE(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - SONHOS(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - MIGOS FT. JÉ(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - BÁSICO FT. JIMYY(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - BASEADO IGNORANTE FT. BNYX(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - TUDO BEM FT. BNYX(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - NOITE PERFEITA(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - OH MY BABY FT. CHE ECRU(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - MINHA MENTE(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - PRIMAVERA(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - RAGE(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - MAZE BANK(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - DE ONDE EU VENHO(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - DROPA UM DOCE(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - BABY GIRL(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - BENZ(MP3_160K).mp3");
            isso_trap.Add("audios/BRANDÃO85 - UMA LUZ(MP3_160K).mp3");
            


            zoo.Add("audios/1. Intro - Brandão85(MP3_160K).mp3");
            zoo.Add("audios/2. Elefante - Brandão85(MP3_160K).mp3");
            zoo.Add("audios/3. Caracol - Brandão85(MP3_160K).mp3");
            zoo.Add("audios/4. Jaguar (uuu) Beck de mel - Brandão85(MP3_160K).mp3");
            zoo.Add("audios/5. Peixe - Brandão85 feat. Alee(MP3_160K).mp3");
            zoo.Add("audios/7. Coruja - Brandão85 feat. Jovem Dex(MP3_160K).mp3");
            zoo.Add("audios/Brandão85 - Orangotango 🦧(MP3_160K).mp3");
           

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

        private void btn_anos_luz_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Brandão85 - Longe(MP3_160K).mp3";
            lbl_sua_musica.Text = "Brandão85 - Longe";
        }

        private void btn_qm_manda30_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Kylie - Leviano_ Brandão e TZ da Coronel(MP3_160K).mp3";
            lbl_sua_musica.Text = "Kylie - Leviano_ Brandão e TZ da Coronel";
        }

        private void btn_kennyG_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Brandão _ Alee - esculacho _( Legends )(MP3_160K).mp3";
            lbl_sua_musica.Text = "Brandão Alee - esculacho";
        }

        private void btn_morte_autotune_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Brandão85 - Pablo(MP3_160K).mp3";
            lbl_sua_musica.Text = "Brandão85 - Pablo";
        }

        private void btn_vampiro_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Nunca Duvide de um Mano(MP3_160K).mp3";
            lbl_sua_musica.Text = "Nunca Duvide de um Mano";
        }

        private void btn_peca_em_peca_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Isso é Sério(MP3_160K).mp3";
            lbl_sua_musica.Text = "Isso é Sério";
        }

        private void btn_proxima_mqot_Click(object sender, EventArgs e)
        {
            if (isso_trap .Count == 0) return;//condição para ir para as proximas musicas

            indiceAtual_trap++;

            if (indiceAtual_trap >= isso_trap .Count)
                indiceAtual_trap = 0; // Volta para a primeira música (ou você pode parar aqui)

            wmp.URL = isso_trap [indiceAtual_trap];
            lbl_sua_musica.Text = nome_Simples(isso_trap [indiceAtual_trap]);// Atualiza o Label da interface com o nome da música atual, de forma limpa (sem caminho e sem ".mp3")

        }

        private void btn_anterior_mqot_Click(object sender, EventArgs e)
        {
            if (isso_trap .Count == 0) return;

            indiceAtual_trap--;

            if (indiceAtual_trap < 0)
                indiceAtual_trap = isso_trap .Count - 1;

            wmp.URL = isso_trap [indiceAtual_trap];
            lbl_sua_musica.Text = nome_Simples(isso_trap [indiceAtual_trap]);// Atualiza o Label da interface com o nome da música atual, de forma limpa (sem caminho e sem ".mp3")
        }

        private void btn_next_t_zip_Click(object sender, EventArgs e)
        {
            if (ceo .Count == 0) return;//condição para ir para as proximas musicas

            indiceAtual_ceo++;

            if (indiceAtual_ceo >= ceo .Count)
                indiceAtual_ceo = 0; // Volta para a primeira música (ou você pode parar aqui)

            wmp.URL = ceo [indiceAtual_ceo];
            lbl_sua_musica.Text = nome_Simples(ceo[indiceAtual_ceo]);
        }

        private void btn_voltar_t_zip_Click(object sender, EventArgs e)
        {
            if (ceo .Count == 0) return;

            indiceAtual_ceo--;

            if (indiceAtual_ceo < 0)
                indiceAtual_ceo = ceo .Count - 1;

            wmp.URL = ceo [indiceAtual_ceo];
            lbl_sua_musica.Text = nome_Simples(ceo[indiceAtual_ceo]);
        }

        private void btn_next_previas_Click(object sender, EventArgs e)
        {
            if (zoo .Count == 0) return;//condição para ir para as proximas musicas

            indiceAtual_zoo++;

            if (indiceAtual_zoo >= zoo .Count)
                indiceAtual_zoo = 0; // Volta para a primeira música (ou você pode parar aqui)

            wmp.URL = zoo[indiceAtual_zoo];
            lbl_sua_musica.Text = nome_Simples  (zoo[indiceAtual_zoo]);
        }

        private void btn_voltar_previas_Click(object sender, EventArgs e)
        {
            if (zoo.Count == 0) return;

            indiceAtual_zoo--;

            if (indiceAtual_zoo < 0)
                indiceAtual_zoo = zoo.Count - 1;

            wmp.URL = zoo[indiceAtual_zoo];
            lbl_sua_musica.Text = nome_Simples(zoo[indiceAtual_zoo]);
        }

        private void btn_iniciar_Tzip_Click(object sender, EventArgs e)
        {
            wmp .URL = "audios/Brandão - DE VOLTA(MP3_160K).mp3";
            lbl_sua_musica.Text = "Brandão - DE VOLTA";
        }

        private void btn_iniciar_previas_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/1. Intro - Brandão85(MP3_160K).mp3";
            lbl_sua_musica.Text = "Intro";
        }

        private void btn_iniciar_mqt_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/BRANDÃO85 - BOLANDO UM PLANO(MP3_160K).mp3";
            lbl_sua_musica.Text = "Bolando um Plano";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frm_musicas musicas = new frm_musicas();
            musicas.Show();
            wmp.controls.stop();
            Hide();
        }

        private void grp_teto_Click(object sender, EventArgs e)
        {

        }
    }
}
