using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public enum TipoUsuario
    {
        NORMAL = 1,
        ADMIN = 2
    }
    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }

        public TipoUsuario TipoUsuario { get; set; }

        public Usuario(string user, string pass, bool admin)
        {
            User = user;
            Pass = pass;
            TipoUsuario = admin ? TipoUsuario.ADMIN : TipoUsuario.NORMAL; // QKE ASE ESTO, si creamos un usario tipo admin, nosotros lo vemos como admin o normal, pero por detrás guarda un 1 o un 2
        }
    }

}
