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
    }
}