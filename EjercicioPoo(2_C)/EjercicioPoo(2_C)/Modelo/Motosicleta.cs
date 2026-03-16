using EjercicioPoo_2_C_.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo_2_C_.Modelo
{
   public class Motosicleta: Veiculo
    {
        public int precio;
        public Boolean tieneSidecar;
        
        

        public Motosicleta(int id, string marca, string modelo, int año, Enum.TipoCombustible tipoCombustible, Enum.EstadoVehiculo estado, int precio, bool tieneSidecar) : base(id, marca, modelo, año, tipoCombustible, estado)
        {
            this.precio = precio;
            this.tieneSidecar = tieneSidecar;
        }



    }
}
