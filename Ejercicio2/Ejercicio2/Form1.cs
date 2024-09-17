using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        int tanis = 0;
        int no_tanis = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Tani");
            comboBox1.Items.Add("No Tani");
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                Mostrar_Mensaje_Error("No seleccionaste ninguna opción");
                return;
            }

            if (comboBox1.SelectedIndex == 0) 
            {
                if (tanis >= 5)
                {
                    if (Confirmar_Cambio_Asiento("La sección de fumadores está llena. ¿Te gustaría cambiarte a la sección de no fumadores?"))
                    {
                        if (no_tanis < 5)
                        {
                            no_tanis++;
                            MessageBox.Show($"Tu asiento es el #{no_tanis + 5} en la sección de no fumadores", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Mostrar_Mensaje_Error("Todos los asientos están llenos. El próximo vuelo es en 3 horas.");
                        }
                    }
                    else
                    {
                        Mostrar_Mensaje_Error("Todos los asientos están llenos. El próximo vuelo es en 3 horas.");
                    }
                }
                else
                {
                    tanis++;
                    MessageBox.Show($"Tu asiento es el #{tanis} en la sección de fumadores", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (comboBox1.SelectedIndex == 1) // No Tani (No fumadores)
            {
                if (no_tanis >= 5)
                {
                    if (Confirmar_Cambio_Asiento("La sección de no fumadores está llena. ¿Te gustaría cambiarte a la sección de fumadores?"))
                    {
                        if (tanis < 5)
                        {
                            tanis++;
                            MessageBox.Show($"Tu asiento es el #{tanis} en la sección de fumadores", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Mostrar_Mensaje_Error("Todos los asientos están llenos. El próximo vuelo es en 3 horas.");
                        }
                    }
                    else
                    {
                        Mostrar_Mensaje_Error("Todos los asientos están llenos. El próximo vuelo es en 3 horas.");
                    }
                }
                else
                {
                    no_tanis++;
                    MessageBox.Show($"Tu asiento es el #{no_tanis + 5} en la sección de no fumadores", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Mostrar_Mensaje_Error(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool Confirmar_Cambio_Asiento(string mensaje)
        {
            DialogResult resultado = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado == DialogResult.Yes;
        }
    }
}
