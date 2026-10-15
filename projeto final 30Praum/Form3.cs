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
    public partial class frm_seguranca: Form
    {
        public void consultar_nome()//criando metodo 
        {
            Banco banco = new Banco();//instanciando o objeto banco para acessar a classe Banco
            banco.Conectar();//usando o objeto banco para buscar o metodo conectar da classe banco


            string sql = "SELECT * FROM tb_cadastro WHERE nome_perfil=@nome_perfil";//declarando a variavel sql para guardar o comando SELECT para consultar o nome_perfil da tabela cadastro

            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);//instanciando o objeto cmd para executar o comando SELECT na conexão ativa com o Banco de Dados

            cmd.Parameters.AddWithValue("@nome_perfil", variaveis.nome);//usando o objeto cmd para transferir  da variavel para a coluna do banco de dados

            MySqlDataReader reader = cmd.ExecuteReader();//executando a leitura do nome_perfil na tabela do banco de dados "procurando o nome da pessoa"

            if ( reader .Read ())//condição que faz a leitura do resultado da busca pelo nome
            {
                variaveis.id = reader.GetInt32(0); //Buscando o id do Usuario Encontrado

                txt_nome.Enabled = false;// Desativando o nome porque ja Encontrei o Usuario perdido 

                MessageBox.Show("Olá, " + variaveis.nome + " Digite a Sua Nova Senha!!!", "Nova Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);// Menssagem de Informação

                txt_nome .Enabled = true;// ativando nova senha

                chk_mostra .Enabled = true;//ativando o chek box 
                txt_nova_senha.Enabled = true;
                
                txt_nova_senha .Focus();// Posição do cursor na linha do nova senha 
            }
            else// Caso contrario ,se não encontrar o Usuario (Não foi Cadastrado)
            {
                MessageBox.Show("Usuario Não Cadastrado!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);//Messagem de erro
                txt_nome .Clear();//Limpar o nome 
                txt_nome.Focus();//posição do cursor 

            }
            banco.Desconectar();// Utilizando o objeto o banco para usar o metodo desconectar da Classe Banco


        }

        public void nova_senha()
        {
            try
            {
                Banco banco = new Banco();// instanciando o objeto banco para Acessar a classe Banco 
                banco.Conectar();// Usando o objeto bonaco para Buscar o metodo coectar da classe banco 

                string sql = "UPDATE tb_cadastro SET senha=@senha WHERE id_usuario=@id_usuario";//Declarando 1 variavel para guardar o comando UPDATE 

                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);// Instanciando o objeto cmd para executar o comando UPDATE  na conecxão ativa com o Banco de Dados 

                cmd.Parameters.AddWithValue("@senha", variaveis.senha);
                cmd.Parameters.AddWithValue("@id_usuario", variaveis.id);

                cmd.ExecuteNonQuery();// Executar todos os comandos do mysql

                banco.Desconectar();//Ultilizando o objeto banco para usar o metodo desconectar 


                MessageBox.Show("Senha alterada com sucesso!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);//Menssagem de informação 

                frm_login frm_Login = new frm_login();
                frm_Login.Show();
                Hide();
            }
            catch
            {
                MessageBox.Show("Erro ao alterar a Nova Senha ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);//    Menssagem de Erro


            }
        }

        public frm_seguranca()
        {
            InitializeComponent();
        }
        
        
        


        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char .IsLetter (e.KeyChar )&& !char .IsSeparator (e.KeyChar )&& !char.IsControl (e.KeyChar ))
            {
                e.Handled = true;
                MessageBox.Show("Digite seu Nome Corretamente", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if ( e.KeyChar ==13)
            {

                if ( txt_nome .TextLength <=2)
                {
                    MessageBox.Show("Digite seu Nome Corretamente", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    variaveis.nome = txt_nome.Text;
                    //txt_nome.Enabled = false;
                    //txt_nova_senha.Enabled = true;
                    //txt_nova_senha.Focus();
                    consultar_nome();
                }
            }
        }

        private void frm_musica_Load(object sender, EventArgs e)
        {

        }

        private void txt_nova_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar ==13)
            {
                if (txt_nova_senha .TextLength !=8 )
                {
                    MessageBox.Show("Digite Exatamente 8 Caracteres", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    variaveis.senha = txt_nova_senha.Text;
                    txt_nova_senha.Enabled = false;
                    txt_confirmar_senha.Enabled = true;
                    txt_confirmar_senha.Focus();
                    chk_mostra1.Enabled = true;

                }

            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_confirmar_senha.Text != txt_nova_senha.Text)
            {
                MessageBox.Show("As senhas devem ser iguais", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                variaveis.senha = txt_confirmar_senha.Text;

                nova_senha();
            }
        }

        private void btn_fechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chk_mostra_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mostra.Checked == true)
            {
                txt_nova_senha.PasswordChar = '\0';
            }
            else
            {
                txt_nova_senha.PasswordChar = '*';
            }
            txt_nova_senha.Focus();
        }

        private void chk_mostra1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mostra1.Checked == true)
            {
                txt_confirmar_senha.PasswordChar = '\0';
            }
            else
            {
                txt_confirmar_senha.PasswordChar = '*';
            }
        }

        private void txt_nova_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_confirmar_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_confirmar_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txt_confirmar_senha.TextLength != 8)
                {
                    MessageBox.Show("Digite Exatamente 8 Caracteres", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                }
                if (txt_confirmar_senha.Text != txt_nova_senha.Text)
                {
                    MessageBox.Show("As senhas devem ser iguais", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    variaveis.senha = txt_confirmar_senha.Text;
                    
                    
                    

                }

            }
        }
    }
}
