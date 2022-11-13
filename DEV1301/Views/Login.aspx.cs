using System;
using DEV1301.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DEV1301.DataBase;
using System.Drawing;

namespace DEV1301
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");

        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            UsuarioDAL usuDal = new UsuarioDAL();
            tabUsuario objUsuario = new tabUsuario();
            objUsuario = usuDal.ConsultarUsuario(txtUsuario.Text, txtSenha.Text);
            try
            {
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    lbResultado.Text = "Insira seu E-mail para efetuar o Login!";
                    lbResultado.Visible = true;
                    txtUsuario.BorderColor = Color.Red;

                }
                else if (string.IsNullOrEmpty(txtSenha.Text))
                {
                    lbResultado.Text = "Insira sua senha para efetuar o Login!";
                    lbResultado.Visible = true;
                    txtSenha.BorderColor = Color.Red;
                }
                else if (objUsuario == null)
                {
                    lbResultado.Visible = true;
                    lbResultado.Text = "Usuário/Senha inválidos";
                }
                else
                {
                    Response.Redirect("Home.apsx");
                }
                

            }
            catch
            {
            }
        }
    }
}