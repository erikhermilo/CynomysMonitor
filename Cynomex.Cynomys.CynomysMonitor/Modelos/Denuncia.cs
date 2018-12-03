using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynomex.Cynomys.CynomysMonitor.Modelos
{
    class Denuncia
    {
        int idAlerta;
        int idUsuario;
        int idDenuncia;
        String strMensaje;
        bool Status;

        public int IdAlerta
        {
            get
            {
                return idAlerta;
            }

            set
            {
                idAlerta = value;
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

        public int IdDenuncia
        {
            get
            {
                return idDenuncia;
            }

            set
            {
                idDenuncia = value;
            }
        }

        public string StrMensaje
        {
            get
            {
                return strMensaje;
            }

            set
            {
                strMensaje = value;
            }
        }

        public bool Status1
        {
            get
            {
                return Status;
            }

            set
            {
                Status = value;
            }
        }
    }
}
