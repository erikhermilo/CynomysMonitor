using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynomex.Cynomys.CynomysMonitor.Modelos
{
    public class DenunciaEX
    {
        String txtAlerta;
        int intDenuncias;

        public string TxtAlerta
        {
            get
            {
                return txtAlerta;
            }

            set
            {
                txtAlerta = value;
            }
        }

        public int IntDenuncias
        {
            get
            {
                return intDenuncias;
            }

            set
            {
                intDenuncias = value;
            }
        }
    }
}
