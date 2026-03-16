using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo_2_C_.Modelo
{
    public class Camion : Veiculo
    {
        public int precio;
        public int capacidadCarga;
        public Boolean tieneRemolque;
        public Camion(int id, string marca, string modelo, int año, Enum.TipoCombustible tipoCombustible, Enum.EstadoVehiculo estado, int precio, int capacidadCarga, bool tieneRemolque) 
            : base(id, marca, modelo, año, tipoCombustible, estado)
        {
            this.precio = precio;
            this.capacidadCarga = capacidadCarga;
            this.tieneRemolque = tieneRemolque;
        }
    }
}