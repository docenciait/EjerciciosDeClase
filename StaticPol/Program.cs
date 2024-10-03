namespace StaticPol
{
    public class Program
    {
        public static void Main()
        {
            // Polimorfismo dinámico con virtual y override

            Moto moto = new Moto("BMW","A1",1400);
            Vehiculo vehiculo = (Vehiculo)moto;
            moto.Acelerar();
            vehiculo.Acelerar();

        }
    }

    // Estático con new
    class Vehiculo
    {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroRuedas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public virtual void Acelerar()
        {
            Console.WriteLine("Acelerar vehículo");
            //Pisar el acelerador
        }

    }

    class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
        {
            Cilindrada = cilindrada;
        }

        public override void Acelerar()
        {
            //Girar el puño
            Console.WriteLine("Acelerar Moto");
        }
    }
}