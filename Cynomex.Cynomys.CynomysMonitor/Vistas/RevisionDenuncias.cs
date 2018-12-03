using Cynomex.Cynomys.CynomysMonitor.BaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cynomex.Cynomys.CynomysMonitor.Vistas
{
    public partial class RevisionDenuncias : Form
    {
        String stralerta;
        String strCantidad;
        String Usuario;
        String Tipo;
        String txtfaltas;

        bool result = false;
        DataContext dcTemp = new DatacontextDataContext();

        public RevisionDenuncias()
        {
            InitializeComponent();
        }

        public bool mostrarvista(Modelos.DenunciaEX denunciaEX)
        {
            stralerta = denunciaEX.TxtAlerta;
            strCantidad = denunciaEX.IntDenuncias.ToString();
            
            Inicializar();
            this.ShowDialog();
            return result;
        }

        public void Inicializar()
        {
            this.txtAlerta.Text = stralerta;
            this.txtDenuncias.Text = strCantidad;

            CargarMensajes();
        }

        public void CargarMensajes()
        {
            int valor = int.Parse(stralerta);
            List<Denuncia> listmensajes = dcTemp.GetTable<Denuncia>().Where(c => c.idAlerta == valor).ToList();
            Usuariofalta faltas = dcTemp.GetTable<Usuariofalta>().Where(c => c.idUsuario == listmensajes[0].Alerta.idUsuario).FirstOrDefault();
            if (faltas != null)
            {
                lblFaltas.Text = faltas.faltas.ToString();
            }
            else
            {
                lblFaltas.Text = "ninguna";
            }
            txtUsuario.Text = listmensajes[0].Alerta.Usuario.email;
            txtTipo.Text = listmensajes[0].Alerta.TIpoAlerta.tipo;
            this.dataGridView1.DataSource = listmensajes;
            this.dataGridView1.Refresh();
            dcTemp.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
