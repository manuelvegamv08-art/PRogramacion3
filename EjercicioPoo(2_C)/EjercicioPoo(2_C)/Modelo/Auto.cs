using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo_2_C_.Modelo
{
    public class Auto: Veiculo
    { 
        public int precio;
        public int puertas;
        public Boolean aireAcondicionado;
        public Boolean transmisionAutomatica;

        public Auto(int id, string marca, string modelo, int año, Enum.TipoCombustible tipoCombustible, Enum.EstadoVehiculo estado, int precio, int puertas, bool aireAcondicionado, bool transmisionAutomatica) : base(id, marca, modelo, año, tipoCombustible, estado)
        {
            this.precio = precio;
            this.puertas = puertas;
            this.aireAcondicionado = aireAcondicionado;
            this.transmisionAutomatica = transmisionAutomatica;
        }



    }
}
