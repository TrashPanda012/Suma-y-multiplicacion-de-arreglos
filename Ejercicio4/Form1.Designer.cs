namespace Ejer4
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.tbVentasBrutas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRangos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Salario ($):";
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(29, 144);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(193, 20);
            this.tbSalario.TabIndex = 10;
            // 
            // tbVentasBrutas
            // 
            this.tbVentasBrutas.Location = new System.Drawing.Point(29, 67);
            this.tbVentasBrutas.Name = "tbVentasBrutas";
            this.tbVentasBrutas.Size = new System.Drawing.Size(193, 20);
            this.tbVentasBrutas.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ventas Brutas ($):";
            // 
            // lbRangos
            // 
            this.lbRangos.FormattingEnabled = true;
            this.lbRangos.Location = new System.Drawing.Point(282, 30);
            this.lbRangos.Name = "lbRangos";
            this.lbRangos.Size = new System.Drawing.Size(255, 277);
            this.lbRangos.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "refrescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.tbVentasBrutas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRangos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.TextBox tbVentasBrutas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbRangos;
        private System.Windows.Forms.Button button1;
    }
}

