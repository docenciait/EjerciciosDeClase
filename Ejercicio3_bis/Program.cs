using System.ComponentModel.Design;

namespace Ejercicio3_bis
{
    /// <summary>
    /// Ejercicios:
    /// 1. Imprime todos los números pares desde dos dados de 0 a n
    /// 2. Imprime si un número es perfecto. Número perfecto cuando todos los divisores del mismo suman el número dado.
    /// Ejemplo: 6 dado que los divisores son 1 + 2 + 3 = 6
    /// 3. Escribir una palabra por teclado hasta dar con una clave (DWES) y sale.
    /// 4. Crear un menú con todas las opciones anteriores más la opción de salir
    /// </summary>
    public class Ejercicios
    {
        static void Main()
        {
            //Ejercicios ejercicios = new Ejercicios();
            //ejercicios.ImprimePares();
            //ejercicios.PrintPerfectNumber();
            //ejercicios.PreguntaHastaIntroducirClave();
            Ejercicios ejercicios = new Ejercicios();
            int option = 0;
            do
            {
                Console.WriteLine("#### Programa con varias opciones ####");
                Console.WriteLine("1) Imprime Pares");
                Console.WriteLine("2) Verifica si número es Perfecto");
                Console.WriteLine("3) Pregunta hasta adivinar la clave");
                Console.WriteLine("0) Salir");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1: ejercicios.ImprimePares(); break;
                    case 2: ejercicios.PrintPerfectNumber(); ; break;
                    case 3: ejercicios.PreguntaHastaIntroducirClave(); break;


                }
            } while (option != 0);
        }

        private static void Menu()
        {
            
        }

        #region Métodos
        public void ImprimePares()
        {
            Console.WriteLine("Introduce el primer número >= 0 ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número >= 0");
            int num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine("Par: {0}", i);
                }
            }
        }

        public void PrintPerfectNumber()
        {
            Console.WriteLine("Cálculo de números perfectos entre dos dados ");
            Console.WriteLine("Escribe el número a calcular: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int sumaDivisores = 0;

            for (int i = 1; i < num1; ++i)
            {

                if (num1 % i == 0)
                {
                    sumaDivisores = sumaDivisores + i;
                }
            }

            Console.WriteLine("Sumadividores: {0}", sumaDivisores);

            if (sumaDivisores == num1)
            {
                Console.WriteLine("Perfecto");
            }
            else
            {
                Console.WriteLine("No es perfecto");
            }
        }

        public void PreguntaHastaIntroducirClave()
        {
            string clave;
            do {
                Console.WriteLine("Introduce palabras hasta la clave DWES:");
                clave = Console.ReadLine();
            } while (clave.ToLower() != "DWES".ToLower()); // Usar ToLower ó ToUpper para que dé igual may ó min
            Console.WriteLine("Fantástico, has acertado!");
        }
        #endregion

    }
}   
