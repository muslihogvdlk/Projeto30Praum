using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//usando o mysql

namespace projeto_final_30Praum
{
    public class Banco//tornando a classe publica para acesso de todos os forms
    {
        //criando a string de conexão com a localização do banco de dados

        string bd = "SERVER=localhost;USER=root;DATABASE=bd_usuarios";

        //criando conexão com o banco de dados

        public MySqlConnection conexao;

        //criando metodo conectar

        public void Conectar()
        {
            //usando a estrutura de tratamento de erros 

            try
            {
                //verificando se o banco de dados foi localizado e esta aberto

                conexao = new MySqlConnection(bd);
                conexao.Open();
               


            }
            catch//casso contrario (se o banco de dados não for localizado)
            {
                MessageBox.Show("Erro ao tentar fazer conexão com o banco de dados", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



        }
        //CRIANDO O METODO DESCONECTAR
        public void Desconectar()
        {
            //usando a estrutura de tratamento de erros

            try
            {
                //localizando o banco para fecha-lo
                conexao = new MySqlConnection(bd);
                conexao.Close();
            }
            catch//caso contrario (se o banco não for localizado
            {
                MessageBox.Show("Erro ao tentar desconectar o banco de dados!!!", "AVISOO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
