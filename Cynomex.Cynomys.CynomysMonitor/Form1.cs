using Cynomex.Cynomys.CynomysMonitor.BaseDatos;
using Cynomex.Cynomys.CynomysMonitor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cynomex.Cynomys.CynomysMonitor
{
    public partial class Form1 : Form
    {
        bool staBasedatos;
        bool stawebser;
        bool stacyno;

        DataContext dcTemp = new DatacontextDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTimer();
            InitTimer2();
            notifyIcon1.Visible = false;
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;

                notifyIcon1.Icon = Resources.CynomysICO;
                notifyIcon1.BalloonTipText = "Cynomys Corre en segundo plano";
                notifyIcon1.ShowBalloonTip(1000);
            }
           
        }



        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;

        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Asincronas
        async Task<bool> ejeutarDBAsync()
        {
            bool result = await Task.Run(() =>
            {
                Form1 f = new Form1();
                return f.ConexionDB();
            });

            this.staBasedatos = result;
            return result;
        }

        async Task<bool> ejeutarWSAsync()
        {
            bool result = await Task.Run(() =>
            {
                Form1 f = new Form1();
                return f.ConexionWS();
            });

            this.stawebser = result;

            return result;
        }

        async Task<bool> ModificarStatusAsync()
        {
            bool result = await Task.Run(() =>
            {
                Form1 f = new Form1();
                return f.ModifidadorMarcas() && f.ModificadorUsuarios();
            });

            this.stacyno = result;

            return result;
        }

        #endregion

        #region Timers
        private Timer timer1;

        public void InitTimer()
        {
            
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ejeutarDBAsync();
            ejeutarWSAsync();

            if (stawebser)
            {
                this.WSlabel.Text = (string.Format("ACTIVA"));
                this.WSlabel.ForeColor = Color.Green;
                this.WSlabel.Refresh();
            }else
            {

                this.WSlabel.Text = (string.Format("Web service no disponible en http://192.168.137.1:26314/WebService1.asmx"));
                this.WSlabel.ForeColor = Color.Red;

                this.WSlabel.Refresh();
            }
            if (staBasedatos)
            {
                this.BDlabel.Text = "ACTIVA";
                this.BDlabel.ForeColor = Color.Green;
                this.BDlabel.Refresh();
                notifyIcon1.Icon = Resources.CynomysICOOnline;
            }
            else
            {
                this.BDlabel.Text = "INACTIVA";
                this.BDlabel.ForeColor = Color.Red;
                this.BDlabel.Refresh();
            }
            if (stacyno)
            {
                this.SClabel.Text = (string.Format("ACTIVA"));
                this.SClabel.ForeColor = Color.Green;
                this.SClabel.Refresh();
            }
            else
            {

                this.SClabel.Text = (string.Format("INACTIVA"));
                this.SClabel.ForeColor = Color.Red;

                this.SClabel.Refresh();
            }
            if (stawebser & staBasedatos & stacyno)
            {

                this.pictureBox1.Image = Resources.pixil_gif_drawing;
                this.pictureBox1.Refresh();

            }
            else
            {

                this.pictureBox1.Image = Resources.Dormido;
                this.pictureBox1.Refresh();

            }
        }


        public void InitTimer2()
        {

            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer2_Tick);
            timer1.Interval = 10000; // in miliseconds
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ModificarStatusAsync();
        }

        #endregion

        public bool ConexionDB()
        {
            using (var l_oConnection = new SqlConnection(Properties.Settings.Default.CynomysConnectionString))
            {
                try
                {
                    l_oConnection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        public bool ConexionWS()
        {
            var url = "http://192.168.137.1:26314/WebService1.asmx";

            try
            {
                var myRequest = (HttpWebRequest)WebRequest.Create(url);

                var response = (HttpWebResponse)myRequest.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    //  it's at least in some way responsive
                    //  but may be internally broken
                    //  as you could find out if you called one of the methods for real
                    return true;
                }
                else
                {
                    //  well, at least it returned...
                    return true;
                }
            }
            catch (Exception ex)
            {
                //  not available at all, for some reason
                return false;
            }
        }

        public bool ModifidadorMarcas()
        {
            try { 
            DateTime ahora = System.DateTime.Now;
            DateTime Pasado = ahora.AddMinutes(-30);
            List<Alerta> listAle = dcTemp.GetTable<Alerta>().Where(c => c.registro < (Pasado) && c.status == true).ToList();

            for (int i = 0; i < listAle.Count; i++)
            {
                listAle[i].status = false;
            }

            dcTemp.SubmitChanges();
            dcTemp.Dispose();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool ModificadorUsuarios()
        {
            try
            {
                DataContext dcUS = new DatacontextDataContext();
                List<Usuariofalta> listAle = dcUS.GetTable<Usuariofalta>().Where(c => c.faltas >= 3 && c.Usuario.status == true).ToList();

                for (int i = 0; i < listAle.Count; i++)
                {

                    listAle[i].Usuario.status = false;
                }

                dcUS.SubmitChanges();
                dcUS.Dispose();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        private void denunciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Denuncias d = new Vistas.Denuncias();
            this.TopMost = false;
            d.ShowDialog();
            this.TopMost = true;
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.ConsultaUsuarios d = new Vistas.ConsultaUsuarios();
            this.TopMost = false;
            d.ShowDialog();
            this.TopMost = true;
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Vistas.ConsultaAlteras d = new Vistas.ConsultaAlteras();
            this.TopMost = false;
            d.ShowDialog();
            this.TopMost = true;
        }
    }
}
