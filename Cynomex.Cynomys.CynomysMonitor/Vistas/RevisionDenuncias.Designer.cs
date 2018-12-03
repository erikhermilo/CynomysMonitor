namespace Cynomex.Cynomys.CynomysMonitor.Vistas
{
    partial class RevisionDenuncias
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlerta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDenuncias = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strMensajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denunciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.Label();
            this.denunciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblFaltas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denunciaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denunciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alerta: ";
            // 
            // txtAlerta
            // 
            this.txtAlerta.AutoSize = true;
            this.txtAlerta.Location = new System.Drawing.Point(93, 9);
            this.txtAlerta.Name = "txtAlerta";
            this.txtAlerta.Size = new System.Drawing.Size(22, 13);
            this.txtAlerta.TabIndex = 1;
            this.txtAlerta.Text = "[...]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Denuncias: ";
            // 
            // txtDenuncias
            // 
            this.txtDenuncias.AutoSize = true;
            this.txtDenuncias.Location = new System.Drawing.Point(93, 111);
            this.txtDenuncias.Name = "txtDenuncias";
            this.txtDenuncias.Size = new System.Drawing.Size(22, 13);
            this.txtDenuncias.TabIndex = 1;
            this.txtDenuncias.Text = "[...]";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.strMensajeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.denunciaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(490, 229);
            this.dataGridView1.TabIndex = 2;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn.Width = 68;
            // 
            // strMensajeDataGridViewTextBoxColumn
            // 
            this.strMensajeDataGridViewTextBoxColumn.DataPropertyName = "strMensaje";
            this.strMensajeDataGridViewTextBoxColumn.HeaderText = "Mensaje";
            this.strMensajeDataGridViewTextBoxColumn.Name = "strMensajeDataGridViewTextBoxColumn";
            this.strMensajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denunciaBindingSource1
            // 
            this.denunciaBindingSource1.DataSource = typeof(Cynomex.Cynomys.CynomysMonitor.BaseDatos.Denuncia);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(430, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Desactivar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(430, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Conservar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Usuario: ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Location = new System.Drawing.Point(93, 38);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(22, 13);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "[...]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.AutoSize = true;
            this.txtTipo.Location = new System.Drawing.Point(93, 89);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(22, 13);
            this.txtTipo.TabIndex = 1;
            this.txtTipo.Text = "[...]";
            // 
            // denunciaBindingSource
            // 
            this.denunciaBindingSource.DataSource = typeof(Cynomex.Cynomys.CynomysMonitor.BaseDatos.Denuncia);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Faltas: ";
            // 
            // lblFaltas
            // 
            this.lblFaltas.AutoSize = true;
            this.lblFaltas.Location = new System.Drawing.Point(93, 60);
            this.lblFaltas.Name = "lblFaltas";
            this.lblFaltas.Size = new System.Drawing.Size(22, 13);
            this.lblFaltas.TabIndex = 1;
            this.lblFaltas.Text = "[...]";
            // 
            // RevisionDenuncias
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(517, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDenuncias);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblFaltas);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtAlerta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RevisionDenuncias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RevisionDenuncias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denunciaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denunciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtAlerta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtDenuncias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtTipo;
        private System.Windows.Forms.BindingSource denunciaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strMensajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource denunciaBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFaltas;
    }
}