<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DEV1301.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <style>
            *{
                margin: 0;
                padding: 0;
            }
            .fundo{
                background-image: linear-gradient(45deg, white, blue);
                height: 100vh;
                color: rgb(201 248 244 / 0,57);
                font-family: Arial, Helvetica, sans-serif;
                
                
            }
            .logintela{
                position: absolute;
                background-color: rgba(0, 0, 0, 0.7);
                top: 50%;
                left: 50%;
                transform: translate(-50%, -50%);
                border-radius: 20px;
                padding: 40px;
            }
           
        </style>
        <div class="fundo">
               <div class="logintela">         
                   <h1>Login</h1>
                          <label>Usuário</label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <label>Senha</label><br />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Visible="false"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="btnLogin_Click" /><br />
            <asp:Button ID="Button2" runat="server" Text="Cadastar-se" OnClick="btnCadastrar_Click" />
             </>
                   </div>    
        </div>                            
    </form>
</body>
</html>

           