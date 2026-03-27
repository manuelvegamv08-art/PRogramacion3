using System;
using System.IO;
using System.Linq;

namespace Ejercicios_txt_1.Ejercicios
{
    
    class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public string ToCsv()
        {
            return $"{Nombre};{Telefono};{Correo}";
        }
    }

    class Program3
    {
        static void Main()
        {
            string archivoContactos = "contactos.csv";

           
            Contacto contacto = new Contacto();

            Console.WriteLine("=== GESTOR DE CONTACTOS ===\n");

            
            Console.Write("Ingrese el nombre: ");
            contacto.Nombre = Console.ReadLine();

            Console.Write("Ingrese el teléfono: ");
            contacto.Telefono = Console.ReadLine();

            Console.Write("Ingrese el correo electrónico: ");
            string correoIngresado = Console.ReadLine();

            
            contacto.Correo = correoIngresado.Trim().ToLower();

            
            try
            {
                File.AppendAllText(archivoContactos, contacto.ToCsv() + Environment.NewLine);
                Console.WriteLine("\n✓ Contacto guardado exitosamente!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n✗ Error al guardar el contacto: {ex.Message}");
                return;
            }

           
            Console.Write("\n¿Desea listar todos los contactos? (s/n): ");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "s" || respuesta.ToLower() == "si")
            {
                ListarContactos(archivoContactos);
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void ListarContactos(string archivoContactos)
        {
            if (!File.Exists(archivoContactos))
            {
                Console.WriteLine("\nNo hay contactos guardados aún.");
                return;
            }

            var lineas = File.ReadAllLines(archivoContactos);

            if (lineas.Length == 0)
            {
                Console.WriteLine("\nNo hay contactos guardados aún.");
                return;
            }

            Console.WriteLine("\n=== LISTA DE CONTACTOS ===\n");

       
            Console.WriteLine($"{"NOMBRE",-30} {"TELÉFONO",-15} {"CORREO",-30}");
            Console.WriteLine(new string('-', 80));

           
            foreach (var linea in lineas)
            {
                if (!string.IsNullOrWhiteSpace(linea))
                {
                    var datos = linea.Split(';');

                    if (datos.Length == 3)
                    {
                        Console.WriteLine($"{datos[0],-30} {datos[1],-15} {datos[2],-30}");
                    }
                }
            }

            Console.WriteLine($"\nTotal de contactos: {lineas.Length}");
        }
    }

}