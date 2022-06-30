﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="DEV1301.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cadastro</h1><br />
            <label>Nome</label><br />
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
            <label>E-mail:</label><br />
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox><br />
            <label>Senha</label><br />
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox><br />
            <label>Repetir Senha</label><br /> 
            <asp:TextBox ID="txtRepetirSenha" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:label ID="lbResultado" runat="server" Visible="false"></asp:label><br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" /><br />
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />


        </div>
    </form>
</body>
</html>
