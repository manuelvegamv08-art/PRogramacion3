using reproductor.Interfases;
using reproductor.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reproductor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al reproductor de música y podcasts!");

            List<Reproductor>PlayList = new List<Reproductor>();

            Boolean continuar = true;

            while (continuar) 
            {
                Console.WriteLine("=====Menu de opciones=====");
                Console.WriteLine("1.agregar un cancion");
                Console.WriteLine("2.agregar un podcast");
                Console.WriteLine("3.reproducir la playlist");
                Console.WriteLine("4.salir");
                String opcion = Console.ReadLine();

                switch (opcion) 
                {
                    case "1":
                        Console.WriteLine("Ingrese el titulo de la cancion:");
                        String titulo = Console.ReadLine();

                        Console.WriteLine("Ingrese el artista de la cancion:");
                        String artista = Console.ReadLine();

                        Console.WriteLine("Ingrese el album de la cancion:");
                        String album = Console.ReadLine();

                        PlayList.Add(new Cancion { Titulo = titulo, Artista = artista, Album = album });
                   
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el titulo del podcast:");
                        String tituloPodcast = Console.ReadLine();

                        Console.WriteLine("Ingrese el creador del podcast:");
                        String creador = Console.ReadLine();

                        Console.WriteLine("Ingrese el episodio del podcast:");
                        String episodio = Console.ReadLine();

                        PlayList.Add(new Podcas { Titulo = tituloPodcast, Creador = creador, Episodio = episodio });
                        break;
                    case "3":
                        Console.WriteLine("Reproduciendo la playlist...");
                        foreach (var item in PlayList)
                        {
                            item.play();
                        }
                        break;

                        case "4":
                        Console.WriteLine("Saliendo del reproductor. ¡Hasta luego!");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                        break;


                }
            }



        }
    }
}
