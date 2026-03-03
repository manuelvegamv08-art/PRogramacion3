using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Generador de Correos Corporativos: Pide al usuario su nombre y apellido.
//El programa debe generar un correo con el formato nombre.apellido@empresa.com (todo en minúsculas).

namespace ejercicios.Ejercicios
{
    internal class Tema_1_ejercicio_4
    {
        public void Main() 
        {
            Console.WriteLine("=== GENERADOR DE CORREOS CORPORATIVOS ===");
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            string apellido = Console.ReadLine();

            string correo = $"{nombre.ToLower()}.{apellido.ToLower()}@empresa.com";
            Console.WriteLine(correo);
        }
        
    }
}
