using MySql.Data.MySqlClient;
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
    public partial class frm_login: Form
    {

        public void login()//criando o metodo login para buscar os dados cadastrados
        {
            Banco banco = new Banco();//criar "instanciar" o objeto banco para acessar a classe Banco
            banco.Conectar();//usando o objeto"banco" para buscar o metodo conectar da classe banco


            string sql = "SELECT * FROM tb_cadastro WHERE nome_perfil=@nome_perfil AND senha=@senha AND apelido=@apelido";//declarando a variavel sql do tipo string para guardar o comando SELECT para consultar os dados da tabela cadastro
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);//(criando) instanciando o objeto cmd para executar o comando select na conexão ativa do banco de dados

            cmd.Parameters.AddWithValue("@nome_perfil", variaveis.nome);//usando o objeto CMD para transferir da variavel para a coluna da tabela do banco
            cmd.Parameters.AddWithValue("@senha", variaveis.senha);//usando o objeto CMD para transferir da variavel para a coluna da tabela do banco
            cmd.Parameters.AddWithValue("@apelido", variaveis.apelido);//usando o objeto CMD para transferir da variavel para a coluna da tabela do banco

            MySqlDataReader reader = cmd.ExecuteReader();//executando a leitura dos dados do usuario na tabela do banco de dados

            if ( reader .Read ())//condição que faz a leitura do resultado da busca pelo nome, senha e apelido. 
            {
                MessageBox.Show("Login Efetuado com Sucesso", "Bem Vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);//mensagem de informação

                frm_musicas musicas = new frm_musicas();
                musicas.Show();
                Hide();

            }
            else//caso contrario do if
            {
                MessageBox.Show("Usuario não Cadastrado","AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error );//mensagem de ERRO
                txt_nome.Clear();
                txt_senha.Clear();
                txt_nome.Focus();
                //txt_senha.Enabled = false ;
                chk_mostra.Enabled = false;
                //btn_entrar.Enabled = false;
                txt_nome.Enabled = true;
                txt_nome.Focus();
                txt_apelido.Clear();


            }
            banco.Desconectar();// utilizando o objeto banco para usar o metodo desconectar da classe Banco 

        }
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar)) 
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if ( e.KeyChar ==13)
            {
                if ( txt_nome.TextLength <= 2)
                {
                    e.Handled = true;
                    MessageBox.Show("Digite seu Nome Corretamente", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    txt_apelido.Enabled = true;
                    txt_apelido.Focus();
                    txt_nome.Enabled = false;
                    variaveis.nome = txt_nome.Text;

                }
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            variaveis.nome = txt_nome.Text;
            variaveis.senha = txt_senha.Text;//guardando os dados
            variaveis.apelido = txt_apelido.Text;

            login();
        }

        private void txt_apelido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar ==13)
            {
                variaveis.apelido = txt_apelido.Text;

                if ( txt_apelido .TextLength <=2)
                {
                    e.Handled = true;
                    MessageBox.Show("Digite seu Nome Corretamente", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    txt_apelido.Enabled = false;
                    txt_senha.Enabled = true;
                    txt_senha.Focus();
                    chk_mostra.Enabled = true;
                }
            }
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar ==13)
            {
                variaveis.senha = txt_senha.Text;
                if ( txt_senha .TextLength !=8)
                {
                    e.Handled = true;
                    MessageBox.Show("Digite 8 Caracteres", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    txt_senha.Enabled = false;
                }
            }
        }

        private void link_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
            Hide();
        }

        private void txt_apelido_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_esqueceu_Click(object sender, EventArgs e)
        {
            frm_seguranca seguranca = new frm_seguranca();
            seguranca.Show();
            Hide ();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chk_mostra_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mostra.Checked == true)
            {
                txt_senha.PasswordChar = '\0';
            }
            else
            {
                txt_senha.PasswordChar = '*';
            }
            txt_senha.Focus();
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
