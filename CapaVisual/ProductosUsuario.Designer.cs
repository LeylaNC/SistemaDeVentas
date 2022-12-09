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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.BtnComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Location = new System.Drawing.Point(932, 20);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(127, 23);
            this.BtnCerrarSesion.TabIndex = 1;
            this.BtnCerrarSesion.Text = "Cerrar Sesion";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // BtnComprar
            // 
            this.BtnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprar.Location = new System.Drawing.Point(817, 130);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(242, 103);
            this.BtnComprar.TabIndex = 2;
            this.BtnComprar.Text = "Comprar\r\nseleccionados";
            this.BtnComprar.UseVisualStyleBackColor = true;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // ProductosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnComprar);
            this.Controls.Add(this.BtnCerrarSesion);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductosUsuario";
            this.Text = "ProductoUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Button BtnComprar;
    }
}