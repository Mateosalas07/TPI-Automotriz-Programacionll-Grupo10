
namespace AutomotrizFront
{
    partial class frmConsulta5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta5));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TipoVehiculoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMinCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(81, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(642, 56);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Cantidad y Precio Total de vehiculos por Tipo de Vehiculo,\r\n  cuyo precio de vent" +
    "a por Vehículo  sea menor o igual a $2.000.000. \r\n";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoVehiculoCol,
            this.ModeloCol,
            this.PrecioMinCol});
            this.dataGridView1.Location = new System.Drawing.Point(66, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(679, 293);
            this.dataGridView1.TabIndex = 2;
            // 
            // TipoVehiculoCol
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TipoVehiculoCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.TipoVehiculoCol.HeaderText = "Cantidad de Vehículos";
            this.TipoVehiculoCol.MinimumWidth = 6;
            this.TipoVehiculoCol.Name = "TipoVehiculoCol";
            this.TipoVehiculoCol.ReadOnly = true;
            this.TipoVehiculoCol.Width = 180;
            // 
            // ModeloCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ModeloCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.ModeloCol.HeaderText = "Tipo Vehículo";
            this.ModeloCol.MinimumWidth = 6;
            this.ModeloCol.Name = "ModeloCol";
            this.ModeloCol.ReadOnly = true;
            this.ModeloCol.Width = 180;
            // 
            // PrecioMinCol
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.PrecioMinCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrecioMinCol.HeaderText = "Precio Total de Venta";
            this.PrecioMinCol.MinimumWidth = 6;
            this.PrecioMinCol.Name = "PrecioMinCol";
            this.PrecioMinCol.ReadOnly = true;
            this.PrecioMinCol.Width = 180;
            // 
            // frmConsulta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsulta5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta 5";
            this.Load += new System.EventHandler(this.frmConsulta5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMinCol;
    }
}