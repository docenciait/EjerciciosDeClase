namespace Herencia2
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Moto m1 = new Moto("Ducati", "A1", 2000);
            Vehiculo2 vehiculo = (Vehiculo2)m1;
        }
    }

    class Vehiculo
    {
        public int NumeroRuedas { get; set; }
    }

    class Mixto : Vehiculo
    {
        //Código
    }

    class Triciclo : Mixto
    {
        public void AsignarRuedas()
        {
            NumeroRuedas = 3;
        }
    }

    // Declaración de constructores

    class Vehiculo2
    {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroRuedas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo2(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
    }

    class Moto : Vehiculo2
    {
        public int Cilindrada { get; set; }

        public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
        {
            Cilindrada = cilindrada;
        }
    }
}
