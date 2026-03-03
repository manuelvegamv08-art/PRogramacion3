using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ejercicios
{
    class Mascota
    {
        public string nombre;

        public virtual void HacerTruco()
        {
            Console.WriteLine("La mascota hace un truco.");
        }
    }

    class Loro : Mascota
    {
        public override void HacerTruco()
        {
            Console.WriteLine(nombre + " dice: ¡Hola! ¡Hola!");
        }
    }

    class Gato : Mascota
    {
        public override void HacerTruco()
        {
            Console.WriteLine(nombre + " está amasando pan ");
        }
    }

    public class ejercicio5
    {
       public static void Main()
        {
            List<Mascota> mascotas = new List<Mascota>();

            Loro loro = new Loro();
            loro.nombre = "Pepe";

            Gato gato = new Gato();
            gato.nombre = "Michi";

            mascotas.Add(loro);
            mascotas.Add(gato);

            Console.WriteLine("Elige una mascota:");
            Console.WriteLine("1. Loro");
            Console.WriteLine("2. Gato");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                mascotas[0].HacerTruco();
            }
            else if (opcion == 2)
            {
                mascotas[1].HacerTruco();
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }
    }
}
