namespace CapaVisual
{
    partial class ProductosUsuario
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
            this.DataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.BtnComprar = new System.Windows.Forms.Button();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewProductos
            // 
            this.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombreProducto,
            this.Descripcion,
            this.Precio,
            this.Cantidad});
            this.DataGridViewProductos.Location = new System.Drawing.Point(12, 26);
            this.DataGridViewProductos.Name = "DataGridViewProductos";
            this.DataGridViewProductos.Size = new System.Drawing.Size(582, 361);
            this.DataGridViewProductos.TabIndex = 0;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Location = new System.Drawing.Point(699, 16);
            this.BtnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(95, 19);
            this.BtnCerrarSesion.TabIndex = 1;
            this.BtnCerrarSesion.Text = "Cerrar Sesion";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // BtnComprar
            // 
            this.BtnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprar.Location = new System.Drawing.Point(613, 106);
            this.BtnComprar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(182, 84);
            this.BtnComprar.TabIndex = 2;
            this.BtnComprar.Text = "Comprar\r\nseleccionados";
            this.BtnComprar.UseVisualStyleBackColor = true;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Id";
            this.IdProducto.Name = "IdProducto";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // ProductosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnComprar);
            this.Controls.Add(this.BtnCerrarSesion);
            this.Controls.Add(this.DataGridViewProductos);
            this.Name = "ProductosUsuario";
            this.Text = "ProductoUsuario";
            this.Load += new System.EventHandler(this.ProductosUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewProductos;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Button BtnComprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}