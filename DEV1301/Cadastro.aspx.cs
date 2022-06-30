using DEV1301.DAL;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEV1301
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //MUDAR O BLOCO!!!
            txtemail.BorderColor = Color.Black;
            txtNome.BorderColor = Color.Black;
            txtSenha.BorderColor = Color.Black;
            txtRepetirSenha.BorderColor = Color.Black;
            lbResultado.Visible = false;

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                lbResultado.Text = "Informe seu Nome";
                lbResultado.Visible = true;
                txtNome.BorderColor = Color.Red;
         
            }
            else if (string.IsNullOrEmpty(txtemail.Text))
            {
                lbResultado.Text = "Informe seu E-mail";
                lbResultado.Visible = true;
                txtemail.BorderColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                lbResultado.Text = "Informe sua senha";
                lbResultado.Visible = true;
                txtSenha.BorderColor = Color.Red;
            }
            else if (txtSenha.Text != txtRepetirSenha.Text)
            {
                lbResultado.Text = "As senhas não conferem";
                lbResultado.Visible = true;
                txtSenha.BorderColor = Color.Red;
                txtRepetirSenha.BorderColor = Color.Red;
            }
            else
            {
                tabUsuario objUsuario = new tabUsuario();
                objUsuario.dataCadastro = DateTime.Now;
                objUsuario.email = txtemail.Text;
                objUsuario.nome = txtNome.Text;
                objUsuario.senha = txtSenha.Text;

                UsuarioDAL usuDal = new UsuarioDAL();
                usuDal.CadastarUsuario(objUsuario);
                lbResultado.Text = "Email" + txtemail.Text + ",Cadastrado com Sucesso!";
                lbResultado.Visible = true;
                txtemail.Text = "";
                txtNome.Text = "";
                // senha por ser Passaword ja limpa sozinhatxtSenha.Text = "";

            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}