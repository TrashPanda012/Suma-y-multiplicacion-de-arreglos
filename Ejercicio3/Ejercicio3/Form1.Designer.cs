namespace Ejercicio3
{
    partial class Form1
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
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.lstReporte = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(259, 155);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 22);
            this.txtVendedor.TabIndex = 0;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(446, 155);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 22);
            this.txtProducto.TabIndex = 1;
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(622, 154);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(100, 22);
            this.txtVenta.TabIndex = 2;
            // 
            // lstReporte
            // 
            this.lstReporte.FormattingEnabled = true;
            this.lstReporte.ItemHeight = 16;
            this.lstReporte.Location = new System.Drawing.Point(347, 223);
            this.lstReporte.Name = "lstReporte";
            this.lstReporte.Size = new System.Drawing.Size(297, 164);
            this.lstReporte.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vendedor  (1-4)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(292, 183);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 34);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Venta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(498, 183);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(181, 34);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar Reporte";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Producto  (1-5)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Monto de venta";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(947, 464);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstReporte);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtVendedor);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.ListBox lstReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

