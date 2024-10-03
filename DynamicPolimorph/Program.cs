namespace TrabajoConInterfaces
{
    public class Program
    {
        public static void Main()
        {
            /*
             * Una interfaz es un contrato entre dos entidades, 
             * esto quiere decir que una interfaz provee un servicio a una clase consumidora.
             * 
             * La interfaz solo nos muestra la declaración de los métodos que esta posee, no su implementación, 
             * permitiendo así su encapsulamiento.
             * 
             * Las interfaces pueden contener los siguientes miembros:

                     Métodos
                     Propiedades
                     Indexers
                     Eventos
             * 
             */

            /*
             * Cuando implementamos una interfaz debemos de asegurar un par de puntos:

                - Los métodos y tipos que devuelven deben coincidir tanto en la interfaz como en la clase.
                - Deben ser los mismos parámetros
                - Los métodos de la interfaz deben ser públicos
                - La utilización de interfaces mejora el código y el rendimiento de la aplicación.

             */

            /**
             * 
             * Como podemos observar en ambos casos tenemos el área y el perímetro. Si recordamos de la herencia, las clases son también del tipo del que heredan, 
             * lo que quiere decir que ambas clases, tanto Cuadrado, como TrianguloRectangulo, las podemos convertir en IPieza:
             * 
             * 
             */

            IPieza cuadrado = new Cuadrado(5);
            IPieza trianguloRectangulo = new TrianguloRectangulo(5, 3);

            Console.WriteLine($"El área del cuadrado es {cuadrado.Area()}");
            Console.WriteLine($"El perímetro del cuadrado es {cuadrado.Perimetro()}");

            Console.WriteLine($"El área del triángulo es {trianguloRectangulo.Area()}");
            Console.WriteLine($"El perímetro del triángulo es {trianguloRectangulo.Perimetro()}");

            /**
             * //Resultado :
                    El área del cuadrado es 25
                    El perímetro del cuadrado es 20
                    El área del triángulo es 7.5
                    El perímetro del triángulo es 13.8309518948453
             */


        }

public interface IPieza
{
    decimal Area();
    decimal Perimetro();
}

public class Cuadrado : IPieza
{
    public decimal Lado { get; set; }

    public Cuadrado(decimal lado)
    {
        Lado = lado;
    }

    public decimal Area()
    {
        return Lado * Lado;
    }

    public decimal Perimetro()
    {
        return Lado * 4;
    }
}

// Otra clase implementa interfaz

public class TrianguloRectangulo : IPieza
{
    public decimal LadoA { get; set; }
    public decimal LadoB { get; set; }
    public decimal Hipotenusa { get; set; }
    public TrianguloRectangulo(decimal ladoa, decimal ladob)
    {
        LadoA = ladoa;
        LadoB = ladob;
        Hipotenusa = CalculateHipotenusa(ladoa, ladob);
    }

    private decimal CalculateHipotenusa(decimal ladoa, decimal ladob)
    {
        return Convert.ToDecimal(Math.Sqrt((double)(ladoa * ladoa + ladob * ladob)));

    }

    public decimal Area()
    {
        return LadoA * LadoB / 2;
    }

    public decimal Perimetro()
    {
        return LadoA + LadoB + Hipotenusa;
    }
}

     

        
    }
}