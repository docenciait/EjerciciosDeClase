namespace InterfacesPolimorph
{
    public class Program
    {
        static void Main()
        {
            // Uso de polimorfismo de interfaces

            // Creamos un array de IAnimal
            IAnimal[] animales = new IAnimal[]
            {
                new Perro(),
                new Gato(),
                new Vaca()
            };

            // Invocamos el método HacerSonido() para cada animal
            foreach (IAnimal animal in animales)
            {
                animal.HacerSonido();
            }
        }
    }

    // Implementación de la interface
    public interface IAnimal
    {
        void HacerSonido();
    }

    // Implementación en varias clases

    public class Perro : IAnimal
    {
        public void HacerSonido()
        {
            Console.WriteLine("El perro ladra.");
        }
    }

    public class Gato : IAnimal
    {
        public void HacerSonido()
        {
            Console.WriteLine("El gato maúlla.");
        }
    }

    public class Vaca : IAnimal
    {
        public void HacerSonido()
        {
            Console.WriteLine("La vaca muge.");
        }
    }

    /*
     
     Explicación del ejemplo:

        Interfaz: La interfaz IAnimal define el método HacerSonido(), que debe ser implementado por cualquier clase que implemente esta interfaz.
        Clases concretas: Las clases Perro, Gato, y Vaca implementan la interfaz IAnimal y proporcionan su propia lógica para el método HacerSonido().
        Polimorfismo: En tiempo de ejecución, aunque las referencias son de tipo IAnimal, el método HacerSonido() invocado corresponde a la implementación de la clase concreta (Perro, Gato, o Vaca).

    Ventajas del polimorfismo de interfaces:

        Flexibilidad: Puedes intercambiar objetos de diferentes clases que implementan la misma interfaz sin necesidad de cambiar el código que los utiliza.
        Extensibilidad: Puedes agregar nuevas clases que implementen la interfaz sin modificar el código existente.
        Desacoplamiento: Promueve la separación entre la definición de los métodos y su implementación, lo que facilita la creación de sistemas modulares y reutilizables.
     
     */

}
