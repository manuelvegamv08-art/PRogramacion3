using Ejerciciopoo_3_S_.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crear un sistema para un restaurante que maneja diferentes tipos de platos:
//Entradas, PlatosPrincipales y Postres. Cada tipo de plato tiene tiempos de preparación y costos diferentes.

namespace Ejerciciopoo_3_S_
{
    class Program
    {
        static void Main(string[] args)
        {
            Entrada entrada = new Entrada("Ensalada César", 8.5, 5);
            PlatoPrincipal platoPrincipal = new PlatoPrincipal("Carne Asada", 18.0, 15);
            Postre postre = new Postre("Helado de Vainilla", 6.0, 3);

            entrada.Preparar();
            platoPrincipal.Preparar();
            postre.Preparar();

            Console.ReadLine();
        }
    }
}
