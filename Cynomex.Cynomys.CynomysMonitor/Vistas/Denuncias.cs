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
    public partial class Denuncias : Form
    {
        DataContext dcTemp = new DatacontextDataContext();
        public Denuncias()
        {
            InitializeComponent();
        }

        private void Denuncias_Load(object sender, EventArgs e)
        {
            cargarDenuncias();
        }

        public void cargarDenuncias()
        {
            List<Denuncia> den = dcTemp.GetTable<Cynomex.Cynomys.CynomysMonitor.BaseDatos.Denuncia>().Where(C=> C.Alerta.status == true).ToList();

            List<Modelos.DenunciaEX> list = new List<Modelos.DenunciaEX>();
            for (int i = 0; i < den.Count; i++)
            {
                Modelos.DenunciaEX deX = new Modelos.DenunciaEX();
                int alerta = den[i].idAlerta;
                deX.TxtAlerta = alerta.ToString();
                if (null == list.Find(c => c.TxtAlerta == deX.TxtAlerta))
                {
                    int cantidad = den.Where(c => c.idAlerta == alerta).Count();
                deX.IntDenuncias = cantidad;
                
                    list.Add(deX);
                }
            }

            this.dataGridView1.DataSource = list;
            this.dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarDenuncias();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.SelectedRows.Count >=1))
            {


                RevisionDenuncias rev = new RevisionDenuncias();

                Modelos.DenunciaEX de = (Modelos.DenunciaEX)this.dataGridView1.SelectedRows[0].DataBoundItem;

                bool resultado = rev.mostrarvista(de);

                if (resultado)
                {
                    int iden = int.Parse(de.TxtAlerta);
                    Alerta listal = dcTemp.GetTable<Alerta>().Where(c => c.idAlerta == iden).FirstOrDefault();
                    Usuariofalta falta = dcTemp.GetTable<Usuariofalta>().Where(c => c.idUsuario == listal.idUsuario).FirstOrDefault();
                    if (falta == null)
                    {
                        Usuariofalta u = new Usuariofalta();
                        u.idUsuario = (int)listal.idUsuario;
                        u.faltas = 1;
                        dcTemp.GetTable<Usuariofalta>().InsertOnSubmit(u);
                    }else
                    {
                        int actual = (int) falta.faltas;
                        falta.faltas = actual + 1;
                    }

                    listal.status = false;
                    dcTemp.SubmitChanges();

                    cargarDenuncias();
                }
            }
        }
    }
}
