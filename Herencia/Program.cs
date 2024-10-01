using Herencia.Modelos;

namespace Herencia
{
    public class Program
    {
        static void Main()
        {
            Moto moto = new Moto("BMW", "SuperFast",1500);
            Vehiculo vehiculo = (Vehiculo)moto;
            Console.WriteLine(vehiculo.Marca);

        }
    }
}