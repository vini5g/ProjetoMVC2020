using ProjetoMVCD37.BLL;
using ProjetoMVCD37.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoMVCD37.UI
{
    public partial class FrmMVCD37 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNomeEmpresa.Text = ConfigurationManager.AppSettings.Get("NomeEmpresa");
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                lblValidacao.Visible = false;

                TblClienteD37DTO clienteDTO = new TblClienteD37DTO();
                clienteDTO.Cpf_cliente = txtCpfD37.Text;
                clienteDTO.Nome_cliente = txtNomeD37.Text;
                clienteDTO.Nome_mae = txtNomeMaeD37.Text;

                TblClienteD37BLL clienteBLL = new TblClienteD37BLL();
                if (clienteBLL.consultarBeneficio(clienteDTO.Cpf_cliente, clienteDTO.Nome_cliente, clienteDTO.Nome_mae))
                {
                    lblValidacao.Visible = true;
                    lblValidacao.Text = "Beneficiário Localizado no Banco de dados. Processo em Análise";
                    lblValidacao.ForeColor = System.Drawing.Color.DarkOliveGreen;
                }
                else
                {
                    lblValidacao.Visible = true;
                    lblValidacao.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
                    lblValidacao.ForeColor = System.Drawing.Color.Red;
                }

            }
            catch (Exception exception)
            {
                lblValidacao.Visible = true;
                lblValidacao.Text = exception.Message;
                lblValidacao.ForeColor = System.Drawing.Color.Red; 
            }
        }
    }
}