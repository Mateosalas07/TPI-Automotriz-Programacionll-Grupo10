
namespace AutomotrizFront
{
    partial class FrmConsulta4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TipoVehiculoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMinCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMaxCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoVehiculoCol,
            this.ModeloCol,
            this.PrecioMinCol,
            this.PrecioMaxCol});
            this.dataGridView1.Location = new System.Drawing.Point(34, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(632, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // TipoVehiculoCol
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TipoVehiculoCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.TipoVehiculoCol.HeaderText = "Tipo Vehiculo";
            this.TipoVehiculoCol.MinimumWidth = 6;
            this.TipoVehiculoCol.Name = "TipoVehiculoCol";
            this.TipoVehiculoCol.ReadOnly = true;
            this.TipoVehiculoCol.Width = 125;
            // 
            // ModeloCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ModeloCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.ModeloCol.HeaderText = "Modelo";
            this.ModeloCol.MinimumWidth = 6;
            this.ModeloCol.Name = "ModeloCol";
            this.ModeloCol.ReadOnly = true;
            this.ModeloCol.Width = 125;
            // 
            // PrecioMinCol
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.PrecioMinCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrecioMinCol.HeaderText = "PrecioMin";
            this.PrecioMinCol.MinimumWidth = 6;
            this.PrecioMinCol.Name = "PrecioMinCol";
            this.PrecioMinCol.ReadOnly = true;
            this.PrecioMinCol.Width = 125;
            // 
            // PrecioMaxCol
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.PrecioMaxCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.PrecioMaxCol.HeaderText = "PrecioMax";
            this.PrecioMaxCol.MinimumWidth = 6;
            this.PrecioMaxCol.Name = "PrecioMaxCol";
            this.PrecioMaxCol.ReadOnly = true;
            this.PrecioMaxCol.Width = 125;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(92, 56);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(537, 28);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Vehículo, con su precio Min. y Max. de venta en este año.";
            // 
            // FrmConsulta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 496);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmConsulta4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta 4";
            this.Load += new System.EventHandler(this.FrmConsulta4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMinCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMaxCol;
    }
}