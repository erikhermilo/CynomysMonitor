using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynomex.Cynomys.CynomysMonitor.Modelos
{
    class Usuariofalta
    {
        int idUsuarioFalta;
        int idUsuario;
        int faltas;

        public int IdUsuarioFalta
        {
            get
            {
                return idUsuarioFalta;
            }

            set
            {
                idUsuarioFalta = value;
            }
        }

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public int Faltas
        {
            get
            {
                return faltas;
            }

            set
            {
                faltas = value;
            }
        }
    }
}
