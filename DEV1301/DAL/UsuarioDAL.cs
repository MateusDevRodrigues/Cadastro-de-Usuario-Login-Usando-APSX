using DEV1301.DataBase;
using System.Linq;

namespace DEV1301.DAL
{
    public class UsuarioDAL
    {
        public  void CadastarUsuario(tabUsuario objUsu)
        {
           using (DataCadastroEntities3 ctx = new DataCadastroEntities3())
            {
                ctx.tabUsuario.Add(objUsu);
                ctx.SaveChanges();
                
            }          
        }  
        
        public tabUsuario ConsultarUsuario(string usuario,string senha)
        {
            using (DataCadastroEntities3 ctx = new DataCadastroEntities3())
            {
               return ctx.tabUsuario.Where(c => c.email == usuario && c.senha == senha).FirstOrDefault();
            }
        }
    }
}