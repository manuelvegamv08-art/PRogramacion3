using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio 1: Diario Personal con Bitácora (Clase File y DateTime)
//Objetivo: Crear un programa que permita al usuario escribir una entrada en
//su "diario" y guardarla automáticamente con la fecha y hora actual.

//Instrucciones:

//Solicita al usuario que ingrese su nombre al iniciar.
//Pide al usuario que escriba un pensamiento o actividad del día por teclado.
//Guarda el texto en un archivo llamado diario.txt.
//Regla de oro: No debes sobrescribir lo anterior. Usa File.AppendAllText.
//El formato de cada línea en el archivo debe ser: [FECHA Y HORA] - USUARIO: MENSAJE.
//Reto extra: Al iniciar el programa, muestra las últimas 3 líneas guardadas 
//en el diario antes de pedir una nueva entrada.

//Ejercicio 1: Diario Personal con Bitácora (Clase File y DateTime)
//Objetivo: Crear un programa que permita al usuario escribir una 
//entrada en su "diario" y guardarla automáticamente con la fecha y hora actual.

//Instrucciones:

//Solicita al usuario que ingrese su nombre al iniciar.
//Pide al usuario que escriba un pensamiento o actividad del día por teclado.
//Guarda el texto en un archivo llamado diario.txt.
//Regla de oro: No debes sobrescribir lo anterior. Usa File.AppendAllText.
//El formato de cada línea en el archivo debe ser: [FECHA Y HORA] - USUARIO: MENSAJE.
//Reto extra: Al iniciar el programa, muestra las últimas 3 líneas guardadas en el
//diario antes de pedir una nueva entrada.

namespace Ejercicios_txt_1.Ejercicios
{
    public class Ejercicio_1 {
        
        static void Main(string[] args)
        {
            String RutaArchivo = "diario.txt";
            Console.WriteLine("Bienvenido a tu diario personal, por favor ingresa tu nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ", por favor escribe un pensamiento o actividad del día:");
            string mensaje = Console.ReadLine();

            
            string fechaHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            File.AppendAllText(RutaArchivo, $"[{fechaHora}] - {nombre}: {mensaje}{Environment.NewLine}");

            Console.WriteLine("Tu entrada ha sido guardada en el diario.");

        }

    }
}
