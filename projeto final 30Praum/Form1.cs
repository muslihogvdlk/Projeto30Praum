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
    public partial class Frm_cadastro: Form
    {
        public void cadastar()//criando o metodo cadastrar para salvar os dados dos usuarios na tabela cadstro
        {
            //estrutura de tratamento de erros 
            try
            {
                Banco banco = new Banco();//criando (instanciando) o objeto banco para acessar a classe Banco
                banco.Conectar();//usando o objeto banco para buscar o metodo conectar da classe banco

                
                string sql = "INSERT INTO tb_cadastro (id_usuario, nome_perfil, senha, apelido) VALUES (DEFAULT,@nome_perfil,@senha,@apelido)";//declarando que a variavel sql do tipo string para guardar o comando insert para inserir os dados dos usuarios na tabela cadastro

                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);//instanciando objeto CMD para executar o comando INSERT na conexão ativa com o banco de dados

                cmd.Parameters.AddWithValue("@nome_perfil", variaveis.nome);//usando o objeto CMD para transferir da variavel para a coluna da tabela do banco
                cmd.Parameters.AddWithValue("@senha", variaveis.senha);//usando o objeto CMD para transferir da variavel para a coluna da tabela do banco 
                cmd.Parameters.AddWithValue("@apelido", variaveis.apelido);//usando o objeto CMD para transferir da variavel para a coluna da tabela do banco


                cmd.ExecuteNonQuery();//executando todos os comandos do mysql
                
                banco.Desconectar();//usando o objeto banco para buscar o metodo desconectar

                MessageBox.Show("Cadastro Feito com Sucesso!!!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);//mensagem de informação

                frm_login login = new frm_login();
                login.Show();
                Hide();
            }
            catch
            {
                MessageBox .Show ("Erro ao Cadastrar ou Usuario ja existente!!!","AVISO!!!",MessageBoxButtons .OK ,MessageBoxIcon.Error );
            }

        }
        public Frm_cadastro()
        {
            InitializeComponent();
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btn_fecahr_MouseHover(object sender, EventArgs e)
        {
            btn_fechar.BackColor = Color.DarkGray;//mudar a cor do botao qnd o mouse passar por cima
        }

        private void btn_fecahr_MouseLeave(object sender, EventArgs e)
        {
            btn_fechar.BackColor = SystemColors.Control;//voltar pra cor original
        }

        private void btn_fechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar ==13)
            {
                //string senha = txt_senha.Text;
                variaveis.senha  = txt_senha.Text;
                if ( variaveis .senha .Length  != 8)
                {
                    MessageBox.Show("A senha deve conter exatamente 8 carcteres", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;

                }
                else
                {
                     
                }

            }
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            //if ( chk_mostra .Checked )
            //{
            //    txt_senha.UseSystemPasswordChar = false;
            //}
            //else
            //{
            //    txt_senha.UseSystemPasswordChar = true;
            //}
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_mostra_CheckedChanged(object sender, EventArgs e)
        {
            if ( chk_mostra .Checked ==true )
            {
                txt_senha.PasswordChar = '\0';
            }
            else
            {
                txt_senha.PasswordChar = '*';
            }
            txt_senha.Focus();
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite Apenas letras", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            if (e.KeyChar == 13)
            {
                variaveis. nome = txt_nome.Text;

                if (txt_nome.TextLength <= 2)
                {
                    MessageBox.Show("Digite seu Nome Corretamente", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    
                    txt_nome.Enabled = false;
                    txt_apelido.Enabled = true;
                    txt_apelido.Focus();
                    
                }
            }
            
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (txt_nome.TextLength <= 2 && variaveis.senha.Length != 8 && txt_apelido .TextLength  <=2)
            {
                MessageBox.Show("Preencha seus dados corretamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                variaveis.nome = txt_nome.Text;
                variaveis.senha = txt_senha.Text;
                variaveis.apelido = txt_apelido.Text;
               
                cadastar();
                frm_login login = new frm_login();
                login.Show();
                Hide();
            }
        }

        private void txt_apelido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==13)
            {
                variaveis.apelido = txt_apelido.Text;

                if ( txt_apelido .TextLength <=2)
                {
                    MessageBox.Show("Digite seu Apelido Corretamente", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txt_senha.Enabled = true;
                    txt_nome.Enabled = false;
                    txt_senha.Focus();
                    chk_mostra.Enabled = true;
                    txt_apelido.Enabled = false;
                }
            }
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cadastro_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbl_apelido_Click(object sender, EventArgs e)
        {

        }

        private void txt_apelido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ja_tem_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
            Hide();
        }
    }
}
