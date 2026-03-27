
using Ejerciciopoo_3_S_.Modelo;
using System;

namespace Ejerciciopoo_3_S
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            Entrada entrada = new Entrada("Ensalada César", 8.5, 5);
            PlatoPrincipal platoPrincipal = new PlatoPrincipal("Carne Asada", 18.0, 15);
            Postre postre = new Postre("Helado de Vainilla", 6.0, 3);

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("===== MENÚ RESTAURANTE =====");
                Console.WriteLine("1. Preparar Entrada");
                Console.WriteLine("2. Preparar Plato Principal");
                Console.WriteLine("3. Preparar Postre");
                Console.WriteLine("4. Preparar Todo");
                Console.WriteLine("5. Salir");

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        entrada.Preparar();
                        break;

                    case "2":
                        platoPrincipal.Preparar();
                        break;

                    case "3":
                        postre.Preparar();
                        break;

                    case "4":
                        entrada.Preparar();
                        platoPrincipal.Preparar();
                        postre.Preparar();
                        break;

                    case "5":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

                Console.WriteLine("\nPresione ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}