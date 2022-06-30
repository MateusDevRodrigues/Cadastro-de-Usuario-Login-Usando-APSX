using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEV1301.DAL
{
    public class UsuarioDAL
    {
        public void CadastarUsuario(tabUsuario objUsu)
        {
           using (DEV1301Entities ctx = new DEV1301Entities())
            {
                ctx.tabUsuario.Add(objUsu);
                ctx.SaveChanges();
            }          
        }  
        
        public tabUsuario ConsultarUsuario(string usuario,string senha)
        {
            using (DEV1301Entities ctx = new DEV1301Entities())
            {
               return ctx.tabUsuario.Where(c => c.email == usuario && c.senha == senha).FirstOrDefault();
            }
        }
    }
}