using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynomex.Cynomys.CynomysMonitor.BaseDatos
{
    public partial class Alerta
    {
        public String nombreUsuario()
        {
            return this.Usuario.nombre;
        }

        public String nombreTipo()
        {
            return this.TIpoAlerta.tipo;
        }
    }
}
