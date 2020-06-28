using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoMVCD37.DAL
{
    public class DALMVC
    {
        private MySqlConnection conexao;
        private string string_conexao = "Persist security info = false;" +
                                        "server=localhost;" +
                                        "database=ProjetoMVCD37;" +
                                        "user=root;pwd=;";
        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            } 
            catch (MySqlException exception)
            {
                throw new Exception("Erro ao conectar ao banco de dados. \nErro: " + exception.Message);
            }
        }

        public void executarComandoDML(string query)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException exception)
            {
                throw new Exception("Não foi possível executar comando DML. \nErro: " + exception.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable executarComandoDQL(string query)
        {
            try
            {
                conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(query, conexao);
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException exception)
            {
                throw new Exception("Não foi possível executar a consulta. \nErro: " + exception.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}