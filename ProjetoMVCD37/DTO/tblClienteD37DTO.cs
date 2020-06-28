using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoMVCD37.DTO
{
    public class TblClienteD37DTO
    {
        private int id_cliente, tp_usuario;
        private string nome_cliente, sobrenome_cliente, email_cliente, senha_cliente, cpf_cliente, nome_mae;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Tp_usuario { get => tp_usuario; set => tp_usuario = value; }
        public string Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public string Sobrenome_cliente { get => sobrenome_cliente; set => sobrenome_cliente = value; }
        public string Email_cliente { get => email_cliente; set => email_cliente = value; }
        public string Senha_cliente { get => senha_cliente; set => senha_cliente = value; }
        public string Cpf_cliente { get => cpf_cliente; set => cpf_cliente = value; }
        public string Nome_mae { get => nome_mae; set => nome_mae = value; }    
    }
}