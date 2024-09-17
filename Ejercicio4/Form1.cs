using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejer4.models;

namespace Ejer4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Venta venta = new Venta();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ventas = int.Parse(tbVentasBrutas.Text);
                Venta venta = new Venta(ventas);
                int salarioBase = venta.SalarioBase;

                tbVentasBrutas.Clear();

                venta.ClasificarRangoSalario(venta);
                MessageBox.Show("Vendedor agregado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbSalario.Clear();


                tbSalario.Text = "$ " + venta.ObtenerSalario().ToString();

                lbRangos.Items.Clear();
                for (int rango = 0; rango < venta.rangoSalario.Length; rango++)
                {

                    lbRangos.Items.Add($"Rango {rango + 1}, Salario > {salarioBase}: {venta.rangoSalario[rango]}");
                    salarioBase += 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cuidado: {ex.Message}", "Cuidado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
