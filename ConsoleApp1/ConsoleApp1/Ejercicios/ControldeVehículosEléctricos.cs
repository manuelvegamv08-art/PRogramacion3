using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Control de Vehículos Eléctricos: Crea una clase VehiculoElectrico con un nivel de batería.
//Implementa un método Viajar(int km) que reste 1% de batería por cada kilómetro.
//Si la batería llega a 0, el coche debe avisar que necesita carga inmediata.

namespace ConsoleApp1.Ejercicios
{
    class VehiculoElectrico
    {
        public int NivelBateria { get; set; }

        public VehiculoElectrico(int nivelInicial)
        {
            NivelBateria = nivelInicial;
        }

        public void Viajar(int km)
        {
            if (NivelBateria <= 0)
            {
                Console.WriteLine("El vehículo no puede viajar. Necesita carga inmediata.");
                return;
            }

            NivelBateria -= km;

            if (NivelBateria <= 0)
            {
                NivelBateria = 0;
                Console.WriteLine("La batería se agotó. Necesita carga inmediata.");
            }
            else
            {
                Console.WriteLine("Viajaste " + km + " km.");
                Console.WriteLine("Batería restante: " + NivelBateria + "%");
            }
        }
    }

    internal class ControldeVehiculosElectricos
    {
        static void Main(string[] args)
        {
            VehiculoElectrico carro = new VehiculoElectrico(50);

            carro.Viajar(20);
            carro.Viajar(40);
        }
    }
}