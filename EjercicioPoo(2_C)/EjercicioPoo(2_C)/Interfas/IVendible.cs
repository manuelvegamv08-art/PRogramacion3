using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo_2_C_.Interfas
{
    internal interface IVendible
    {
        DateTime CalcularFechaVenta();
        void ComprovanteVenta();
        decimal CalcularPrecioVenta();

    }
}
