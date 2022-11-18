
namespace AutomotrizFront
{
    partial class frmAltaFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboArticulos = new System.Windows.Forms.ComboBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.idProdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // cboItem
            // 
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Items.AddRange(new object[] {
            "Vehiculos",
            "Autopartes"});
            this.cboItem.Location = new System.Drawing.Point(146, 161);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(212, 28);
            this.cboItem.TabIndex = 29;
            this.cboItem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cboItem.SelectedValueChanged += new System.EventHandler(this.cboItem_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(547, 625);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = " Total $";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(649, 633);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(124, 27);
            this.txtTotal.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(504, 582);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sub Total $";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.Color.White;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.ForeColor = System.Drawing.Color.White;
            this.txtSubtotal.Location = new System.Drawing.Point(649, 587);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubtotal.MaxLength = 10;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(124, 27);
            this.txtSubtotal.TabIndex = 25;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(788, 214);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.MaxLength = 10;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(138, 27);
            this.txtCantidad.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(776, 272);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 39);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboArticulos
            // 
            this.cboArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArticulos.FormattingEnabled = true;
            this.cboArticulos.Location = new System.Drawing.Point(256, 210);
            this.cboArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboArticulos.Name = "cboArticulos";
            this.cboArticulos.Size = new System.Drawing.Size(269, 28);
            this.cboArticulos.TabIndex = 20;
            this.cboArticulos.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToResizeColumns = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdCol,
            this.colArt,
            this.precioCol,
            this.colCantidad,
            this.actionCol});
            this.dgvDetalles.Location = new System.Drawing.Point(23, 340);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(752, 237);
            this.dgvDetalles.TabIndex = 24;
            // 
            // idProdCol
            // 
            this.idProdCol.HeaderText = "ID";
            this.idProdCol.MinimumWidth = 6;
            this.idProdCol.Name = "idProdCol";
            this.idProdCol.ReadOnly = true;
            this.idProdCol.Visible = false;
            this.idProdCol.Width = 125;
            // 
            // colArt
            // 
            this.colArt.HeaderText = "Articulo";
            this.colArt.MinimumWidth = 6;
            this.colArt.Name = "colArt";
            this.colArt.ReadOnly = true;
            this.colArt.Width = 220;
            // 
            // precioCol
            // 
            dataGridViewCellStyle3.Format = "C3";
            dataGridViewCellStyle3.NullValue = null;
            this.precioCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.precioCol.HeaderText = "Precio";
            this.precioCol.MinimumWidth = 6;
            this.precioCol.Name = "precioCol";
            this.precioCol.ReadOnly = true;
            this.precioCol.Width = 125;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 125;
            // 
            // actionCol
            // 
            this.actionCol.HeaderText = "Acciones";
            this.actionCol.MinimumWidth = 6;
            this.actionCol.Name = "actionCol";
            this.actionCol.ReadOnly = true;
            this.actionCol.Text = "Quitar";
            this.actionCol.UseColumnTextForButtonValue = true;
            this.actionCol.Width = 125;
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(69, 161);
            this.lblCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(69, 20);
            this.lblCompra.TabIndex = 23;
            this.lblCompra.Text = "Compra :";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(80, 112);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 19;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(146, 62);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFecha.MaxLength = 10;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(212, 27);
            this.txtFecha.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fecha:";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFactura.Location = new System.Drawing.Point(17, 9);
            this.lblFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(121, 25);
            this.lblFactura.TabIndex = 16;
            this.lblFactura.Text = "Factura Nº:";
            this.lblFactura.Click += new System.EventHandler(this.lblFactura_Click);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(23, 212);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(226, 20);
            this.lblSeleccion.TabIndex = 31;
            this.lblSeleccion.Text = "Seleccione el Articulo a Comprar";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(709, 219);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 20);
            this.lblCantidad.TabIndex = 35;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(206, 715);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 39);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(480, 715);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 39);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Credito",
            "Cuotas",
            "Plan de Ahorro"});
            this.cboFormaPago.Location = new System.Drawing.Point(511, 161);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(212, 28);
            this.cboFormaPago.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Forma de Pago :";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(146, 113);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCliente.MaxLength = 10;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(212, 27);
            this.txtCliente.TabIndex = 40;
            // 
            // frmAltaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 768);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.cboFormaPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.cboItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboArticulos);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFactura);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAltaFactura";
            this.Text = "frmAltaFactura";
            this.Load += new System.EventHandler(this.frmAltaFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboArticulos;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn actionCol;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
    }
}