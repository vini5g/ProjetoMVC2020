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
        public string Nome_cliente 
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome_cliente = value;
                }
                else
                {
                    throw new Exception("Por favor informe o seu nome.");
                }  
            }
            get { return nome_cliente; } 
        }
        public string Sobrenome_cliente { get => sobrenome_cliente; set => sobrenome_cliente = value; }
        public string Email_cliente { get => email_cliente; set => email_cliente = value; }
        public string Senha_cliente { get => senha_cliente; set => senha_cliente = value; }
        public string Cpf_cliente 
        { 
            set 
            {
                if (value == string.Empty)
                {
                    throw new Exception("Por favor informe o seu cpf.");
                }
                else if (isCampoNumerico(value) == false)
                {
                    throw new Exception("O campo cpf só aceita números.");
                }
                else
                {
                    this.cpf_cliente = value;
                }
            }
            get { return cpf_cliente; }
        }
        public string Nome_mae 
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome_mae = value;
                }
                else
                {
                    throw new Exception("Por favor informe o nome da sua mãe.");
                }
            }
            get { return nome_mae; }
        }    

        public bool isCampoNumerico(string value)
        {
            char[] caracteres = value.ToCharArray();

            foreach (var caracter in caracteres)
            {
                if (!char.IsDigit(caracter))
                    return false;
            }

            return true;
        }
    }
}