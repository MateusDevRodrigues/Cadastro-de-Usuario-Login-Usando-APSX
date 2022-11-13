<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DEV1301.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
    <link rel="stylesheet" href="../Css/Login.css" />
</head>
<body>
    <form id="form1" runat="server">
            <div class="conatinerlogin">
                <h1>Login</h1>
                <label>Email</label><br />
                <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox><br />
                <label>Senha</label><br />
                <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox><br />
                <asp:Label ID="lbResultado" runat="server" Visible="false"></asp:Label><br />
                <asp:Button CssClass="btnLogin" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click1" /><br />
                <asp:Button CssClass="btnCadastrar" ID="btnCadastrar" runat="server" Text="Cadastar-se" OnClick="btnCadastrar_Click" />

                </>
            </div>
    </form>
</body>
</html>

