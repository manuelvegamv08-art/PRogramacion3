using System;
using System.IO;

class Program3
{
    static void Main()
    {
        Console.WriteLine("=== CREADOR DE ESTRUCTURA DE PROYECTOS ===\n");

        
        Console.Write("Ingrese el nombre del proyecto: ");
        string nombreProyecto = Console.ReadLine();

        
        if (string.IsNullOrWhiteSpace(nombreProyecto))
        {
            Console.WriteLine("El nombre del proyecto no puede estar vacío.");
            return;
        }

        
        string carpetaPrincipal = nombreProyecto;
        Directory.CreateDirectory(carpetaPrincipal);

        
        string carpetaDocumentos = Path.Combine(carpetaPrincipal, "documentos");
        string carpetaImagenes = Path.Combine(carpetaPrincipal, "imagenes");
        string carpetaCodigo = Path.Combine(carpetaPrincipal, "codigo");

        Directory.CreateDirectory(carpetaDocumentos);
        Directory.CreateDirectory(carpetaImagenes);
        Directory.CreateDirectory(carpetaCodigo);

        
        Console.Write("\nIngrese una breve descripción del proyecto: ");
        string descripcion = Console.ReadLine();

        string rutaReadme = Path.Combine(carpetaDocumentos, "readme.txt");
        File.WriteAllText(rutaReadme, descripcion);

       
        string rutaAbsoluta = Path.GetFullPath(carpetaPrincipal);

        Console.WriteLine("\n=== ESTRUCTURA CREADA EXITOSAMENTE ===\n");
        Console.WriteLine($"Proyecto: {nombreProyecto}");
        Console.WriteLine($"Ruta absoluta: {rutaAbsoluta}");
        Console.WriteLine("\nCarpetas creadas:");
        Console.WriteLine($"  documentos/");
        Console.WriteLine($"   readme.txt");
        Console.WriteLine($"   imagenes/");
        Console.WriteLine($"   codigo/");

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}