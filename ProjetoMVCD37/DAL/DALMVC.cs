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
                                        "database=ProjetoMVCD37" +
                                        "user=root;pwd=;";
        public void conectar()
        {
            try
            {
                this.conexao = new MySqlConnection(this.string_conexao);
                this.conexao.Open();
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
                this.conectar();
                MySqlCommand comando = new MySqlCommand(query, this.conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException exception)
            {
                throw new Exception("Não foi possível executar comando DML. \nErro: " + exception.Message);
            }
            finally
            {
                this.conexao.Close();
            }
        }

        public DataTable executarComandoDQL(string query)
        {
            try
            {
                this.conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(query, this.conexao);
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException exception)
            {
                throw new Exception("Não foi possível executar a consulta. \nErro: " + exception.Message);
            }
            finally
            {
                this.conexao.Close();
            }
        }
    }
}