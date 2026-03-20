using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Repaso19.Modelo
{
     public class Vehiculo
    {
        public int placa { get; set; }
        public String marca { get; set; }  

        public Vehiculo(int placa, string marca)
        {
            this.placa = placa;
            this.marca = marca;
        }


    }


}
