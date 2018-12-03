namespace Cynomex.Cynomys.CynomysMonitor.Vistas
{
    partial class ConsultaAlteras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbFiltrar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblDenuncias = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLatitud = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumUsu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAlertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbFiltrar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtInicio);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.dtFin);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnConsulta);
            this.panel2.Location = new System.Drawing.Point(13, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 109);
            this.panel2.TabIndex = 16;
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.AutoSize = true;
            this.cbFiltrar.Location = new System.Drawing.Point(21, 12);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(51, 17);
            this.cbFiltrar.TabIndex = 10;
            this.cbFiltrar.Text = "Filtrar";
            this.cbFiltrar.UseVisualStyleBackColor = true;
            this.cbFiltrar.CheckedChanged += new System.EventHandler(this.cbFiltrar_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Registro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Status";
            // 
            // dtInicio
            // 
            this.dtInicio.Enabled = false;
            this.dtInicio.Location = new System.Drawing.Point(21, 51);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(216, 20);
            this.dtInicio.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Activos",
            "Inactivos"});
            this.comboBox1.Location = new System.Drawing.Point(64, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // dtFin
            // 
            this.dtFin.Enabled = false;
            this.dtFin.Location = new System.Drawing.Point(261, 51);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(216, 20);
            this.dtFin.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "-";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Enabled = false;
            this.btnConsulta.Location = new System.Drawing.Point(483, 48);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblusuario);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblFechar);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblLongitud);
            this.panel1.Controls.Add(this.lblDenuncias);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblLatitud);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(698, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 271);
            this.panel1.TabIndex = 15;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(148, 172);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(22, 13);
            this.lblusuario.TabIndex = 0;
            this.lblusuario.Text = "[...]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Usuario:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(127, 125);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(22, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "[...]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tipo Alerta:";
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Location = new System.Drawing.Point(127, 102);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(22, 13);
            this.lblFechar.TabIndex = 0;
            this.lblFechar.Text = "[...]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Fecha registro:";
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Location = new System.Drawing.Point(74, 57);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(22, 13);
            this.lblLongitud.TabIndex = 0;
            this.lblLongitud.Text = "[...]";
            // 
            // lblDenuncias
            // 
            this.lblDenuncias.AutoSize = true;
            this.lblDenuncias.Location = new System.Drawing.Point(148, 217);
            this.lblDenuncias.Name = "lblDenuncias";
            this.lblDenuncias.Size = new System.Drawing.Size(22, 13);
            this.lblDenuncias.TabIndex = 0;
            this.lblDenuncias.Text = "[...]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Longitud:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(74, 80);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(22, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "[...]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Denuncias:";
            // 
            // lblLatitud
            // 
            this.lblLatitud.AutoSize = true;
            this.lblLatitud.Location = new System.Drawing.Point(74, 34);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(22, 13);
            this.lblLatitud.TabIndex = 0;
            this.lblLatitud.Text = "[...]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Latitud:";
            // 
            // txtNumUsu
            // 
            this.txtNumUsu.AutoSize = true;
            this.txtNumUsu.Location = new System.Drawing.Point(67, 167);
            this.txtNumUsu.Name = "txtNumUsu";
            this.txtNumUsu.Size = new System.Drawing.Size(22, 13);
            this.txtNumUsu.TabIndex = 13;
            this.txtNumUsu.Text = "[...]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Alertas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Consulta de Alertas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlertaDataGridViewTextBoxColumn,
            this.registroDataGridViewTextBoxColumn,
            this.latDataGridViewTextBoxColumn,
            this.lonDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alertaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 183);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(665, 271);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // idAlertaDataGridViewTextBoxColumn
            // 
            this.idAlertaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idAlertaDataGridViewTextBoxColumn.DataPropertyName = "idAlerta";
            this.idAlertaDataGridViewTextBoxColumn.HeaderText = "idAlerta";
            this.idAlertaDataGridViewTextBoxColumn.Name = "idAlertaDataGridViewTextBoxColumn";
            this.idAlertaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAlertaDataGridViewTextBoxColumn.Width = 67;
            // 
            // registroDataGridViewTextBoxColumn
            // 
            this.registroDataGridViewTextBoxColumn.DataPropertyName = "registro";
            this.registroDataGridViewTextBoxColumn.HeaderText = "registro";
            this.registroDataGridViewTextBoxColumn.Name = "registroDataGridViewTextBoxColumn";
            this.registroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // latDataGridViewTextBoxColumn
            // 
            this.latDataGridViewTextBoxColumn.DataPropertyName = "lat";
            this.latDataGridViewTextBoxColumn.HeaderText = "lat";
            this.latDataGridViewTextBoxColumn.Name = "latDataGridViewTextBoxColumn";
            this.latDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lonDataGridViewTextBoxColumn
            // 
            this.lonDataGridViewTextBoxColumn.DataPropertyName = "lon";
            this.lonDataGridViewTextBoxColumn.HeaderText = "lon";
            this.lonDataGridViewTextBoxColumn.Name = "lonDataGridViewTextBoxColumn";
            this.lonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 60;
            // 
            // alertaBindingSource
            // 
            this.alertaBindingSource.DataSource = typeof(Cynomex.Cynomys.CynomysMonitor.BaseDatos.Alerta);
            // 
            // ConsultaAlteras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNumUsu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaAlteras";
            this.ShowIcon = false;
            this.Text = "ConsultaAlteras";
            this.Load += new System.EventHandler(this.ConsultaAlteras_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbFiltrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.Label lblDenuncias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLatitud;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtNumUsu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource alertaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}