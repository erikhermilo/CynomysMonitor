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
    public partial class ConsultaAlteras : Form
    {
        DataContext dcTemp = new DatacontextDataContext();

        public ConsultaAlteras()
        {
            InitializeComponent();
        }

        private void ConsultaAlteras_Load(object sender, EventArgs e)
        {
            cargarAlertas();
            this.comboBox1.SelectedIndex = 0;

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((dataGridView1.SelectedRows.Count >= 0))
            {

                Alerta de = (Alerta)this.dataGridView1.SelectedRows[0].DataBoundItem;

                lblLatitud.Text = de.lat;
                lblTipo.Text = de.lon;
                lblStatus.Text = de.status.ToString();
                lblFechar.Text = de.registro.ToString();
                lblLongitud.Text = de.lon;

                lblDenuncias.Text = de.Denuncias.Count.ToString();
                lblusuario.Text = de.Usuario.nombre;

                refescar();
            }
        }

        private void cbFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFiltrar.Checked == true)
            {
                this.dtFin.Enabled = true;
                this.dtInicio.Enabled = true;

                this.comboBox1.Enabled = true;
                this.btnConsulta.Enabled = true;

            }
            else
            {

                this.dtFin.Enabled = false;
                this.dtInicio.Enabled = false;

                this.comboBox1.Enabled = false;
                this.btnConsulta.Enabled = false;
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {

            cargarAlertas();
        }

        public void limpiaryRefescar()
        {
            lblLatitud.Text = "[...]";
            lblTipo.Text = "[...]";
            lblStatus.Text = "[...]";
            lblFechar.Text = "[...]";
            lblLongitud.Text = "[...]";
            lblDenuncias.Text = "[...]";
            lblusuario.Text = "[...]";

            lblLatitud.Refresh();
            lblTipo.Refresh();
            lblStatus.Refresh();
            lblFechar.Refresh();
            lblLongitud.Refresh();
            lblDenuncias.Refresh();
            lblusuario.Refresh();
        }

        public void refescar()
        {
            lblLatitud.Refresh();
            lblTipo.Refresh();
            lblStatus.Refresh();
            lblFechar.Refresh();
            lblLongitud.Refresh();
            lblDenuncias.Refresh();
            lblusuario.Refresh();
        }

        public void cargarAlertas()
        {
            List<Alerta> den = dcTemp.GetTable<Cynomex.Cynomys.CynomysMonitor.BaseDatos.Alerta>().ToList();
            if (cbFiltrar.Checked == true)
            {
                DateTime inicio = this.dtInicio.Value;
                DateTime fin = this.dtFin.Value;
                if (comboBox1.SelectedIndex == 0)
                {
                    List<Alerta> l = den.Where(C => C.registro >= inicio && C.registro <= fin).ToList();
                    this.txtNumUsu.Text = l.Count.ToString();
                    this.txtNumUsu.Refresh();
                    this.dataGridView1.DataSource = l;
                }
                else
                {
                    bool Status;

                    if (comboBox1.SelectedIndex == 1)
                    {
                        Status = true;
                    }
                    else
                    {
                        Status = false;
                    }


                    List<Alerta> l = den.Where(C => C.status == Status && (C.registro >= inicio && C.registro <= fin)).ToList();
                    this.txtNumUsu.Text = l.Count.ToString();
                    this.txtNumUsu.Refresh();
                    this.dataGridView1.DataSource = l;
                }

            }
            else
            {
                this.dataGridView1.DataSource = den;
                this.txtNumUsu.Text = den.Count.ToString();
                this.txtNumUsu.Refresh();
            }
            this.dataGridView1.Refresh();
            limpiaryRefescar();
        }
    }
}
