using System;
using System.IO; 

namespace Reto_1
{
    internal class Program
    {
        public class Amigo
        {
            public string Nombre { get; set; }
            public DateTime Fechanacimiento { get; set; }

            public int DiasRestantes()
            {
                DateTime hoy = DateTime.Today;
                
                DateTime proximoCumple = new DateTime(hoy.Year, Fechanacimiento.Month, Fechanacimiento.Day);

                if (proximoCumple < hoy)
                {
                    proximoCumple = proximoCumple.AddYears(1);
                }

                return (proximoCumple - hoy).Days;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("--- Registro de Cumpleaños ---");

                
                Console.Write("Ingresa el nombre de tu amigo: ");
                string nombreIngresado = Console.ReadLine();

                Console.Write("Ingresa su fecha de nacimiento (DD/MM/AAAA): ");
               
                DateTime fechaIngresada = DateTime.Parse(Console.ReadLine());

                
                Amigo nuevoAmigo = new Amigo
                {
                    Nombre = nombreIngresado,
                    Fechanacimiento = fechaIngresada
                };

                int dias = nuevoAmigo.DiasRestantes();
                string ruta = "cumpleaños.txt";

                
                string lineaParaGuardar = $"Nombre: {nuevoAmigo.Nombre} | " +
                                          $"Nació el: {nuevoAmigo.Fechanacimiento.ToShortDateString()} | " +
                                          $"Faltan: {dias} días para su cumple." +
                                          Environment.NewLine;

                
                File.AppendAllText(ruta, lineaParaGuardar);

                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine("¡Datos guardados los datos " + ruta + "!");
                Console.WriteLine($"Resultado: Faltan {dias} días para el cumple de {nuevoAmigo.Nombre}");
                Console.WriteLine("-------------------------------------------");

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: El formato de fecha no es válido. Usa DD/MM/AAAA.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}