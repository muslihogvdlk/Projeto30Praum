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
    public partial class frm_reproducao: Form
    {
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        public frm_reproducao()
        {
            InitializeComponent();
        }

        List<string> maquina_tempo = new List<string>();//criando uma lista de string(textos) com o nome mqt para guardar o caminho da musica 
        int indiceAtual_mqt = 0;//variavel int q guarda qual posição esta tocando na lista de musicas 

        List<string> salve_todos = new List<string>();
        int indiceAtual_333 = 0;

        List<string> sony = new List<string>();
        int indiceAtual_sony = 0;

        private string nome_Simples(string caminho)
        {
            return Path.GetFileNameWithoutExtension(caminho);//funçao pronta que elimina o caminho do nome das musicas como (audios,debug...).
        }


        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void frm_reproducao_Load(object sender, EventArgs e)
        {
            //criando a lista de reprodução das musicas
            maquina_tempo.Add("audios/Cogulândia(MP3_160K).mp3");
            maquina_tempo.Add("audios/Antes(MP3_160K).mp3");
            maquina_tempo.Add("audios/Gorilla Roxo(MP3_160K).mp3");
            maquina_tempo.Add("audios/Vem Chapar(MP3_160K).mp3");
            maquina_tempo.Add("audios/777-666(MP3_160K).mp3");
            maquina_tempo.Add("audios/É Sal(MP3_160K).mp3");
            maquina_tempo.Add("audios/Matuê Máquina do Tempo.mp3");


            salve_todos.Add("audios/Crack com Mussilon(MP3_160K).mp3");
            salve_todos.Add("audios/Imagina esse Cenário(MP3_160K).mp3");
            salve_todos.Add("audios/Isso é Sério(MP3_160K).mp3");
            salve_todos.Add("audios/1993(MP3_160K).mp3");
            salve_todos.Add("audios/4Tal(MP3_160K).mp3");
            salve_todos.Add("audios/O Som(MP3_160K).mp3");
            salve_todos.Add("audios/04AM(MP3_160K) (1).mp3");
            salve_todos.Add("audios/Castlevania(MP3_160K).mp3");
            salve_todos.Add("audios/V de Vilão(MP3_160K).mp3");
            salve_todos.Add("audios/Maria(MP3_160K).mp3");
            salve_todos.Add("audios/Matuê - 333.mp3");
            salve_todos.Add("audios/ Like This_(MP3_160K).mp3");


            sony.Add("audios/A Última Dança(MP3_160K).mp3");
            sony.Add("audios/Matuê Honey Babe.mp3");
            sony.Add("audios/Matuê - Reza do Milhão(MP3_160K).mp3");


        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void btn_comecar_333_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Matuê - 333.mp3";
            lbl_sua_musica.Text = "Matuê - 333";
        }

        private void btn_iniciar_333_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Crack com Mussilon(MP3_160K).mp3";
            lbl_sua_musica.Text = "Crack com Mussilon";


            //btn_pausar.Visible = true;

        }

       

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btn_iniciar_mdt_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Cogulândia(MP3_160K).mp3";
            lbl_sua_musica.Text = "Cogulândia";

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

        private void guna2CirclePictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void btn_anos_luz_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/anos luz 00.mp3";
            lbl_sua_musica.Text = "Anos luz ";

        }

        private void btn_morte_autotune_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Matuê A Morte do Autotune 💔.mp3";
            lbl_sua_musica.Text = "Matuê A Morte do Autotune ";
        }

        private void btn_qm_manda30_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Quem Manda É a 30.mp3";
            lbl_sua_musica.Text = "Quem Manda É a 30 ";
        }

        private void btn_vampiro_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Vampiro - Matuê.mp3";
            lbl_sua_musica.Text = "Matuê Vampiro ";
        }

        private void btn_peca_em_peca_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Matuê De Peça em Peça feat.Knust Chris Mc.mp3";
            lbl_sua_musica.Text = "Matuê De Peça em Peça feat.Knust Chris Mc";
        }

        private void btn_kennyG_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/Matuê Kenny G.mp3";
            lbl_sua_musica.Text = "Matuê Kenny G";
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sony_Click(object sender, EventArgs e)
        {
            wmp.URL = "audios/A Última Dança(MP3_160K).mp3";
            lbl_sua_musica.Text = "Ultima dança";
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (salve_todos .Count == 0) return;//condição para ir para as proximas musicas

            indiceAtual_333++;

            if (indiceAtual_333 >= salve_todos . Count)
                indiceAtual_333 = 0; // Volta para a primeira música (ou você pode parar aqui)

            wmp.URL = salve_todos[indiceAtual_333];
            lbl_sua_musica.Text = nome_Simples(salve_todos [indiceAtual_333]);
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            if (salve_todos .Count == 0) return;

            indiceAtual_333--;

            if (indiceAtual_333 < 0)
                indiceAtual_333 = salve_todos .Count - 1;

            wmp.URL = salve_todos [indiceAtual_333];
            lbl_sua_musica.Text = nome_Simples(salve_todos[indiceAtual_333]);
        }

        private void guna2CirclePictureBox11_Click(object sender, EventArgs e)
        {
            if (maquina_tempo .Count == 0) return;//condição para ir para as proximas musicas

            indiceAtual_mqt++;

            if (indiceAtual_mqt >= maquina_tempo .Count)
                indiceAtual_mqt = 0; // Volta para a primeira música (ou você pode parar aqui)

            wmp.URL = maquina_tempo [indiceAtual_mqt];
            lbl_sua_musica.Text = nome_Simples(maquina_tempo [indiceAtual_mqt]);
        }

        private void btn_voltarMQDT_Click(object sender, EventArgs e)
        {
            if (maquina_tempo .Count == 0) return;

            indiceAtual_mqt--;

            if (indiceAtual_mqt < 0)
                indiceAtual_mqt = maquina_tempo .Count - 1;

            wmp.URL = maquina_tempo [indiceAtual_mqt];
            lbl_sua_musica.Text = nome_Simples(maquina_tempo[indiceAtual_mqt]);
        }

        private void btn_next_sony_Click(object sender, EventArgs e)
        {
            if (sony .Count == 0) return;//condição para ir para as proximas musicas

            indiceAtual_sony++;

            if (indiceAtual_sony >= sony .Count)
                indiceAtual_sony = 0; // Volta para a primeira música (ou você pode parar aqui)

            wmp.URL = sony [indiceAtual_sony];
            lbl_sua_musica.Text = nome_Simples(sony [indiceAtual_sony]);
        }

        private void btn_voltar_sony_Click(object sender, EventArgs e)
        {
            if (sony .Count == 0) return;

            indiceAtual_sony--;

            if (indiceAtual_sony < 0)
                indiceAtual_sony     = sony .Count - 1;

            wmp.URL = sony [indiceAtual_sony];
            lbl_sua_musica.Text = nome_Simples(sony[indiceAtual_sony]);
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
