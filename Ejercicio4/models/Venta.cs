using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4.models
{
    internal class Venta
    {
        public int VentasBrutas { get; set; }
        public double Salario { get; set; }
        public int SalarioBase = 200;

        public Venta() { }
        public Venta(int ventasBrutas)
        {
            VentasBrutas = ventasBrutas;
            CalcularSalario();
        }

        public void CalcularSalario()
        {
            Salario = SalarioBase + (VentasBrutas * 0.09);
        }

        public int ObtenerSalario()
        {
            return (int)Salario;
        }

        public int[] rangoSalario = new int[9];

        public void ClasificarRangoSalario(Venta vendedor)
        {
            int salarioVendedor = vendedor.ObtenerSalario();
            int salarioBase = vendedor.SalarioBase;

            if (salarioVendedor >= salarioBase)
            {
                for (int i = 0; i < 9; i++)
                {
                    int limiteInferior = i * 100 + 200;
                    int limiteSuperior = (i == 8) ? int.MaxValue : limiteInferior + 99;

                    if (salarioVendedor >= limiteInferior && salarioVendedor <= limiteSuperior)
                    {
                        rangoSalario[i]++;
                        break;
                    }
                }
            }
        }
    }
}
