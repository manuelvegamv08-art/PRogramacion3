using Repaso19.Modelo;

public class Carro : Vehiculo
{
    public bool Disponible { get; set; } = true;
    public int Puertas { get; set; }
    public int Puestos { get; set; }
    private string Nombre { get; set; }

    public Carro(string nombre, int puestos, int puertas, int placa, string marca)
        : base(placa, marca)
    {
        Nombre = nombre;
        Puestos = puestos;
        Puertas = puertas;
    }

    
}
