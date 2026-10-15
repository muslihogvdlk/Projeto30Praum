using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Drawing.Text;
using System.IO;


namespace projeto_final_30Praum
{
   
    public partial class forms_teto: Form
    {
        
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        public forms_teto()
        {
            InitializeComponent();
        }
        

        List<string> musicas = new List<string>();
        int indiceAtual = 0;

        List<string> maior_tempo = new List<string>();
        int indiceAtual_mqt = 0;

        List<string> tempo_zip = new List<string>();
        int indiceAtual_Tzip = 0;

        public void tocar_musica()
        {
           
        }

        private string nome_Simples(string caminho)
        {
            return Path.GetFileNameWithoutExtension(caminho);//funçao pronta que elimina o caminho do nome das musicas como (audios,debug...).
        }



        private void forms_teto_Load(object sender, EventArgs e)
        {
            {

                tempo_zip.Add("audios/brinco de diamante(MP3_160K).mp3");
                tempo_zip.Add("audios/eu vou ser rico(MP3_160K).mp3");
                tempo_zip.Add("audios/espelho(MP3_160K).mp3");
                tempo_zip.Add("audios/bolas de haxi(MP3_160K).mp3");
                tempo_zip.Add("audios/doce mágico(MP3_160K).mp3");
                tempo_zip.Add("audios/atoa(MP3_160K).mp3");
                tempo_zip.Add("audios/te amo minha mãe(MP3_160K).mp3");
                



                musicas.Add("audios/Paypal(MP3_160K).mp3");
                musicas.Add("audios/Dia Azul(MP3_160K).mp3");
                musicas.Add("audios/Manha(MP3_160K).mp3");
                musicas.Add("audios/Fashion(MP3_160K).mp3");
                



                maior_tempo.Add("audios/NÃO PARE(MP3_160K).mp3");
                maior_tempo.Add("audios/BEM NOVIN(MP3_160K).mp3");
                maior_tempo.Add("audios/PRETTY LET GIRL(MP3_160K).mp3");
                maior_tempo.Add("audios/LEITE DERRAMADO(MP3_160K).mp3");
                maior_tempo.Add("audios/YES OR NO(MP3_160K).mp3");
                maior_tempo.Add("audios/TEMPORAL(MP3_160K).mp3");
                maior_tempo.Add("audios/OQQELESVAOFALAR_(MP3_160K).mp3");
                maior_tempo.Add("audios/PREVENDO A JOGADA(MP3_160K).mp3");
                maior_tempo.Add("audios/GRÉCIA(MP3_160K).mp3");
                maior_tempo.Add("audios/MULHER SECRETA(MP3_160K).mp3");
                maior_tempo.Add("audios/MAIOR QUE O TEMPO(MP3_160K).mp3");






                
            }
        }
        

        private void btn_peca_em_peca_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Vampiro - Matuê.mp3";
            lbl_sua_musica.Text = "Vampiro";
        }

        private void btn_vampiro_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Flow Espacial - Teto.mp3";
            lbl_sua_musica.Text = "Flow Espacial";
        }

        private void btn_anos_luz_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/zumzumzum - teto.mp3";
            lbl_sua_musica.Text = "zumzumzum";

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_iniciar_333_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/NÃO PARE(MP3_160K).mp3";
            lbl_sua_musica.Text = "NÃO PARE";
        }

        private void btn_morte_autotune_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/TETO - Mustang Preto(MP3_160K).mp3";
            lbl_sua_musica.Text = "Mustang Preto";
        }

        private void btn_qm_manda30_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Teto - M4 feat. Matuê(MP3_160K).mp3";
            lbl_sua_musica.Text = "Teto - M4 feat. Matuê";
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btn_kennyG_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/GROUPIES - Doode _ Teto _ Matuê 🦇(MP3_160K).mp3";
            lbl_sua_musica.Text = "GROUPIES";
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

        private void btn_proxima_Click(object sender, EventArgs e)
        {
            


            
        }

        private void btn_proxima_mqot_Click(object sender, EventArgs e)
        {
            if (maior_tempo .Count == 0) return;//condição para ir para as proximas musicas e verificar se tem alguma coisa na variavel, se não tiver nada ele faz o return e não toca nada

            indiceAtual_mqt++;

            if (indiceAtual_mqt >= maior_tempo .Count)
                indiceAtual_mqt = 0; // Volta para a primeira música (ou você pode parar aqui)

            wmp.URL = maior_tempo [indiceAtual_mqt];
            lbl_sua_musica.Text = nome_Simples(maior_tempo [indiceAtual_mqt]);
        }

        private void guna2CirclePictureBox8_Click(object sender, EventArgs e)
        {
            //if (musicas.Count == 0) return;

            //indiceAtual--;

            //if (indiceAtual < 0)
            //    indiceAtual = musicas.Count - 1;

            //wmp.URL = musicas[indiceAtual];
        }

        private void btn_anterior_mqot_Click(object sender, EventArgs e)
        {
            if (maior_tempo .Count == 0) return;

            indiceAtual_mqt--;

            if (indiceAtual_mqt < 0)
                indiceAtual_mqt = maior_tempo .Count - 1;

            wmp.URL = maior_tempo [indiceAtual_mqt];
            lbl_sua_musica.Text = nome_Simples(maior_tempo[indiceAtual_mqt]);
        }

        private void btn_iniciar_Tzip_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/brinco de diamante(MP3_160K).mp3";
            lbl_sua_musica.Text = "Brinco de diamante";

        }

        private void btn_iniciar_previas_Click(object sender, EventArgs e)
        {
            wmp .URL ="audios/Paypal(MP3_160K).mp3";
            lbl_sua_musica.Text = "Paypal";
        }

        private void btn_next_t_zip_Click(object sender, EventArgs e)
        {
            if (tempo_zip .Count == 0) return;//condição para ir para as proximas musicas

            indiceAtual_Tzip++;

            if (indiceAtual_Tzip >= tempo_zip .Count)
                indiceAtual_Tzip = 0; // Volta para a primeira música (ou você pode parar aqui)

            wmp.URL = tempo_zip [indiceAtual_Tzip];
            lbl_sua_musica.Text = nome_Simples(tempo_zip [indiceAtual_Tzip]);
        }

        private void btn_voltar_t_zip_Click(object sender, EventArgs e)
        {
            if (tempo_zip .Count == 0) return;

            indiceAtual_Tzip--;

            if (indiceAtual_Tzip < 0)
                indiceAtual_Tzip = tempo_zip .Count - 1;

            wmp.URL = tempo_zip [indiceAtual_Tzip];
            lbl_sua_musica.Text = nome_Simples(tempo_zip[indiceAtual_Tzip]);
        }

        private void btn_next_previas_Click(object sender, EventArgs e)
        {
            if (musicas .Count == 0) return;//condição para ir para as proximas musicas

            indiceAtual++;

            if (indiceAtual >= musicas .Count)
                indiceAtual = 0; // Volta para a primeira música (ou você pode parar aqui)

            wmp.URL = musicas [indiceAtual];
            lbl_sua_musica.Text = nome_Simples(musicas [indiceAtual]);
        }

        private void btn_voltar_previas_Click(object sender, EventArgs e)
        {
            if (musicas .Count == 0) return;

            indiceAtual--;

            if (indiceAtual < 0)
                indiceAtual = musicas .Count - 1;

            wmp.URL = musicas [indiceAtual];
            lbl_sua_musica.Text = nome_Simples(musicas[indiceAtual]);
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
