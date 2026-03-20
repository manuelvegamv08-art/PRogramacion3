using Repaso19.Modelo;

internal class Moto : Vehiculo
{
    public string Cilindraje { get; set; }

    public Moto(string cilindraje, int placa, string marca)
        : base(placa, marca)
    {
        Cilindraje = cilindraje;
    }
}
