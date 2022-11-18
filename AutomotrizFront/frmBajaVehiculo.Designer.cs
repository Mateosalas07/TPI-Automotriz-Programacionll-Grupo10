
namespace AutomotrizFront
{
    partial class frmBajaVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBajaVehiculo));
            this.label1 = new System.Windows.Forms.Label();
            this.dgsTabla = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgsTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(320, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dar Baja de Vehículo";
            // 
            // dgsTabla
            // 
            this.dgsTabla.AllowUserToAddRows = false;
            this.dgsTabla.AllowUserToDeleteRows = false;
            this.dgsTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colModelo,
            this.dataGridViewTextBoxColumn1,
            this.colPrecio,
            this.colColor,
            this.colActivo});
            this.dgsTabla.Location = new System.Drawing.Point(12, 93);
            this.dgsTabla.Name = "dgsTabla";
            this.dgsTabla.ReadOnly = true;
            this.dgsTabla.RowHeadersWidth = 51;
            this.dgsTabla.RowTemplate.Height = 29;
            this.dgsTabla.Size = new System.Drawing.Size(776, 188);
            this.dgsTabla.TabIndex = 1;
            this.dgsTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsTabla_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "Numero de Vehiculo";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 125;
            // 
            // colModelo
            // 
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.MinimumWidth = 6;
            this.colModelo.Name = "colModelo";
            this.colModelo.ReadOnly = true;
            this.colModelo.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo de Vehiculo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 125;
            // 
            // colColor
            // 
            this.colColor.HeaderText = "Color";
            this.colColor.MinimumWidth = 6;
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            this.colColor.Width = 125;
            // 
            // colActivo
            // 
            this.colActivo.HeaderText = "Activo";
            this.colActivo.MinimumWidth = 6;
            this.colActivo.Name = "colActivo";
            this.colActivo.ReadOnly = true;
            this.colActivo.Width = 125;
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.Location = new System.Drawing.Point(356, 309);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(94, 29);
            this.btnDarBaja.TabIndex = 2;
            this.btnDarBaja.Text = "Dar Baja";
            this.btnDarBaja.UseVisualStyleBackColor = true;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(213, 311);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(125, 27);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(44, 312);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(147, 20);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Número de Vehículo:";
            // 
            // frmBajaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.dgsTabla);
            this.Controls.Add(this.label1);
            this.Name = "frmBajaVehiculo";
            this.Text = "frmBajaVehiculo";
            this.Load += new System.EventHandler(this.frmBajaVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgsTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgsTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivo;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}