using ProjetoMVCD37.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ProjetoMVCD37.BLL
{
    public class TblClienteD37BLL
    {
        private DALMVC dalMVC = new DALMVC();

        public Boolean consultarBeneficio(string cpf, string nomeCompleto, string nomeMae)
        {
            string query = string.Format($@"select * from tbl_clienteD37 where nome_cliente = '{nomeCompleto}' and nome_mae = '{nomeMae}' and cpf_cliente = '{cpf}';");
            DataTable dt = dalMVC.executarComandoDQL(query);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}