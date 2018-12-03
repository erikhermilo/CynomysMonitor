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
    public partial class ConsultaUsuarios : Form
    {
        DataContext dcTemp = new DatacontextDataContext();
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
            this.comboBox1.SelectedIndex = 0;
        }

        public void cargarUsuarios()
        {
            List<Usuario> den = dcTemp.GetTable<Cynomex.Cynomys.CynomysMonitor.BaseDatos.Usuario>().ToList();
            if(cbFiltrar.Checked == true)
            {
                DateTime inicio = this.dtInicio.Value;
                DateTime fin = this.dtFin.Value;
                if (comboBox1.SelectedIndex == 0)
                {
                    List<Usuario> l = den.Where(C => C.fecha_nacimiento >= inicio && C.fecha_nacimiento <= fin).ToList();
                    this.txtNumUsu.Text = l.Count.ToString();
                    this.txtNumUsu.Refresh();
                    this.dataGridView1.DataSource = l;
                }else
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


                    List<Usuario> l = den.Where(C => C.status == Status && (C.fecha_nacimiento >= inicio && C.fecha_nacimiento <= fin)).ToList();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbFiltrar.Checked == true)
            {
                this.dtFin.Enabled = true;
                this.dtInicio.Enabled = true;

                this.comboBox1.Enabled = true;
                this.btnConsulta.Enabled = true;

            }else
            {

                this.dtFin.Enabled = false;
                this.dtInicio.Enabled = false;

                this.comboBox1.Enabled = false;
                this.btnConsulta.Enabled = false;
            }

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        

        public void limpiaryRefescar()
        {
            lblNombre.Text = "[...]";
            lblSexo.Text = "[...]";
            lblStatus.Text = "[...]";
            lblFechan.Text = "[...]";
            lblFaltas.Text = "[...]";
            lblEmail.Text = "[...]";
            lblDenuncias.Text = "[...]";
            lblAlert.Text = "[...]";

            lblNombre.Refresh();
            lblSexo.Refresh();
            lblStatus.Refresh();
            lblFechan.Refresh();
            lblFaltas.Refresh();
            lblEmail.Refresh();
            lblDenuncias.Refresh();
            lblAlert.Refresh();
        }

        public void refescar()
        {
            lblNombre.Refresh();
            lblSexo.Refresh();
            lblStatus.Refresh();
            lblFechan.Refresh();
            lblFaltas.Refresh();
            lblEmail.Refresh();
            lblDenuncias.Refresh();
            lblAlert.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((dataGridView1.SelectedRows.Count >= 0))
            {

                Usuario de = (Usuario)this.dataGridView1.SelectedRows[0].DataBoundItem;

                lblNombre.Text = de.nombre;
                lblSexo.Text = de.Sexo.Nombre;
                lblStatus.Text = de.status.ToString();
                lblFechan.Text = de.fecha_nacimiento.ToString();
                if (de.Usuariofaltas.Count >= 1)
                {
                    lblFaltas.Text = de.Usuariofaltas[0].faltas.ToString();
                }
                else
                {
                    lblFaltas.Text = "0";
                }
                lblEmail.Text = de.email;

                lblDenuncias.Text = de.Denuncias.Count.ToString();
                lblAlert.Text = de.Alertas.Count.ToString();

                refescar();
            }
        }
    }
}
