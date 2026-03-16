using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPoo_1_b.Interfas
{
    internal interface IPrestable
    {
        DateTime FechaDeVolucion { get; set; }
        void GeneralComprobantePrestamo();

        Decimal CalcularMulta();
    }
}
