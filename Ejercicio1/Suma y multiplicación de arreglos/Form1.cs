using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Suma_y_multiplicación_de_arreglos
{
    public partial class Form1 : Form
    {
        int[] sumas = new int[13];
        int giros = 36000;
        Random rand = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGirar_Click(object sender, EventArgs e)
        {
            giro();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void giro()
        {
            
            for (int i = 0; i < giros; i++)
            {
                int dado1 = rand.Next(1, 7);
                int dado2 = rand.Next(1, 7);
                int sum = dado1 + dado2;

                sumas[sum]++;
            }

            dgvDatos.Rows.Clear();
            dgvDatos.Columns.Clear();
            dgvDatos.Columns.Add("Suma", "Suma");
            dgvDatos.Columns.Add("Frecuencia", "Frecuencia");

            for (int sum = 2; sum <= 12; sum++)
            {
                double probability = (double)sumas[sum] / giros;
                dgvDatos.Rows.Add(sum, sumas[sum]);
            }
        }
    }
}
