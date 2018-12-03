using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynomex.Cynomys.CynomysMonitor.BaseDatos
{
    public partial class Denuncia
    {

        public string nombreUsuario()
        {
            return this.Usuario.email;
        }
    }
}
