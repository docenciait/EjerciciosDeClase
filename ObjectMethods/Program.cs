using ObjectMethods.Modelos;

namespace ObjectMethods
{
    public class Program
    {
        
        static void Main()
        {
            Moto moto = new Moto();
            moto.VelocidadMaxima = 200;
            Console.WriteLine(moto.Marca);

        }
    }
    
}
