using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using EjerciciosPoo_1_b.Modelos;

namespace EjerciciosPoo_1_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MaterialBiblioteca> materiales = new List<MaterialBiblioteca>();

            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Mostrar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");

                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

               
                if (opcion == 1)
                {
                    Console.WriteLine("1. Libro  2. Revista  3. AudioLibro");
                    int tipo = int.Parse(Console.ReadLine());

                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Titulo: ");
                    string titulo = Console.ReadLine();

                    Console.Write("Autor: ");
                    string autor = Console.ReadLine();

                    Console.Write("Año: ");
                    int anio = int.Parse(Console.ReadLine());

                    Console.Write("Categoria: ");
                    string categoria = Console.ReadLine();

                    if (tipo == 1)
                    {
                        Console.Write("ISBN: ");
                        string isbn = Console.ReadLine();

                        Console.Write("Paginas: ");
                        int paginas = int.Parse(Console.ReadLine());

                        materiales.Add(new Libro(isbn, paginas, id, titulo, autor, anio, categoria));
                    }
                    else if (tipo == 2)
                    {
                        Console.Write("Numero Edicion: ");
                        int edicion = int.Parse(Console.ReadLine());

                        Console.Write("Periodicidad: ");
                        string periodicidad = Console.ReadLine();

                        materiales.Add(new Revista(edicion, periodicidad, id, titulo, autor, anio, categoria));
                    }
                    else if (tipo == 3)
                    {
                        Console.Write("Duracion: ");
                        double duracion = double.Parse(Console.ReadLine());

                        Console.Write("Narrador: ");
                        string narrador = Console.ReadLine();

                        materiales.Add(new AudioLibro(duracion, narrador, id, titulo, autor, anio, categoria));
                    }

                    Console.WriteLine("Material agregado!");
                }

                // 🔹 MOSTRAR
                else if (opcion == 2)
                {
                    foreach (var m in materiales)
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine("ID: " + m.id);
                        Console.WriteLine("Titulo: " + m.titulo);
                        Console.WriteLine("Autor: " + m.Autor);
                        Console.WriteLine("Año: " + m.Anoplublicacion);
                        Console.WriteLine("Categoria: " + m.Categoria);
                    }
                }

                // 🔹 BUSCAR
                else if (opcion == 3)
                {
                    Console.Write("Ingrese ID a buscar: ");
                    int buscar = int.Parse(Console.ReadLine());

                    bool encontrado = false;

                    foreach (var m in materiales)
                    {
                        if (m.id == buscar)
                        {
                            Console.WriteLine("Encontrado:");
                            Console.WriteLine(m.titulo);
                            encontrado = true;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("No encontrado");
                    }
                }

                // 🔹 ELIMINAR
                else if (opcion == 4)
                {
                    Console.Write("Ingrese ID a eliminar: ");
                    int eliminar = int.Parse(Console.ReadLine());

                    for (int i = 0; i < materiales.Count; i++)
                    {
                        if (materiales[i].id == eliminar)
                        {
                            materiales.RemoveAt(i);
                            Console.WriteLine("Eliminado!");
                            break;
                        }
                    }
                }

                // 🔹 SALIR
                else if (opcion == 5)
                {
                    Console.WriteLine("Saliendo del programa...");
                }
                else
                {
                    Console.WriteLine("Opcion invalida");
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
