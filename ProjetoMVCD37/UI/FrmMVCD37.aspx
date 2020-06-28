﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMVCD37.aspx.cs" Inherits="ProjetoMVCD37.UI.FrmMVCD37" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="../Content/bootstrap.css" rel="stylesheet" />
<link href="../Content/stylesFrm.css" rel="stylesheet" />
    <title>Projeto MVC</title>
</head>
<body>
    <section class="container mt-5">
        <div class="row content">
            <div class="col-md-6 content-1">
                <img src="../Images/undraw_working_remotely_jh40.svg" class="img " />
            </div>
            <div class="col-md-6 content-2">  
                <form id="form1" class="form-container" runat="server">
                    <div class="form-group">
                        <asp:Label ID="lblCpfD37" runat="server" Text="CPF"></asp:Label>
                        <asp:TextBox ID="txtCpfD37" type="number" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="ValidacaoCPF" 
                            ControlToValidate="txtCpfD37"
                            ErrorMessage="Este campo é obrigatório. Informe seu CPF"
                            ForeColor="Red"
                            runat="server"/>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblNomeD37" runat="server" Text="Nome completo"></asp:Label>
                        <asp:TextBox ID="txtNomeD37" type="text" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="ValidacaoNome" 
                            ControlToValidate="txtNomeD37"
                            ErrorMessage="Este campo é obrigatório. Informe seu nome completo"
                            ForeColor="Red"
                            runat="server"/>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblNomeMaeD37" runat="server" Text="Nome da mãe"></asp:Label>
                        <asp:TextBox ID="txtNomeMaeD37" type="text" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="ValidacaoNomeMae" 
                            ControlToValidate="txtNomeMaeD37"
                            ErrorMessage="Este campo é obrigatório. Informe o nome da sua mãe"
                            ForeColor="Red"
                            runat="server"/>
                    </div>
                    <div class="form-group mt-5">
                        <asp:Button ID="btnEnviar" CssClass="btn btn-block text-white" runat="server" Text="ENVIAR" />
                    </div>
                    <div class="form-group mt-5 text-center">
                        <asp:Label ID="lblNomeEmpresa" runat="server" Text="label"></asp:Label>                    
                    </div>
                </form>
            </div>
        </div>
    </section>
</body>
</html>
