<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjExWCF.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-expand-lg navbar-light bg-light" role="navigation">
            <a class="navbar-brand" href="Default.aspx">CADASTRO DE EMPRESAS </a>
            <br />
                </nav>
            <br />
            <div class="form-group col-md-12">
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
            <br />
            <br />
            Nome<br />
            <asp:TextBox class="form-control col-md-8" ID="txtNome" runat="server" Width="205px"></asp:TextBox>
            <br />
            <br />
            Qtd Funcionários<br />
            <asp:TextBox class="form-control col-md-8" ID="txtQtdFunc" runat="server"></asp:TextBox>
            <br />
            <br />
            Endereço<br />
            <asp:TextBox class="form-control col-md-8" ID="txtEndereco" runat="server" Width="293px"></asp:TextBox>
            <br />
            <br />
            <asp:Button class="btn btn-primary" ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="SALVAR" />
            <br />
            <br />
            <br />
            <asp:GridView CssClass="table table-hover table-striped" GridLines="None" ID="gdvListagem" runat="server" OnSelectedIndexChanged="gdvListagem_SelectedIndexChanged">
            </asp:GridView>
        </div>
            </div>
    </form>
</body>
</html>
