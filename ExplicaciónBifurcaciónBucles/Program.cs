using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace BifurcacionesYBucles
{
    public class Program
    {
    
        public static void Main()
        {
            /*
             * IF-THEN-ELSE
             */

            //Console.WriteLine("Escribe el tipo de ciclo: DAW2 ó DAM2");
            //string ciclo = Console.ReadLine();

            //if (ciclo.ToUpper() == "DAW2")
            //{
            //    Console.WriteLine("Estamos en DAW2");
            //}

            //else if (ciclo.ToUpper() == "DAM2")
            //{
            //    Console.WriteLine("Estamos en DAM2");
            //}

            //else
            //{
            //    Console.WriteLine("Incorrecto");
            //}

            /*
             * TERNARIO
             */

            //Console.WriteLine("Dime tu edad: ");
            //int edad = int.Parse(Console.ReadLine());

            //bool mayorDeEdad = (edad >= 18 ? true : false);

            //if (mayorDeEdad)
            //{
            //    Console.WriteLine("Mayor de edad");
            //}

            //else
            //{
            //    Console.WriteLine("Menor de edad");
            //}


            //Console.WriteLine($"{(edad >= 18 ? "mayor de edad" : "menor de edad")}");

            /*
             * SWITCH
             */

            //Console.WriteLine("Escribe nombre de fruta: ");
            //string fruta = Console.ReadLine();
            //switch (fruta) 
            //{
            //    case "manzana":  //case string s when Regex.IsMatch(fruta, @"(?i)manzana"): 
            //        Console.WriteLine("Qué rica la manzana"); 
            //        break;

            //    case "melon": 
            //        Console.WriteLine("Qué rico el melón");
            //        break;

            //    case "uva":
            //        Console.WriteLine("Qué rica la uva");
            //        break;
            //    default:
            //        Console.WriteLine("No te gusta la fruta");
            //        break ;
            //}

            /*
             * BUCLE WHILE
             */
            //int contador = 10;
            //while (contador >= 0)
            //{   
            //    Console.WriteLine(contador);
            //    contador--;
            //}

            /*
             * BUCLE DO-WHILE
             */

            //int contador = 10;
            //do
            //{
            //    Console.WriteLine(contador);
            //    contador--;

            //} while (contador >= 0);

            /*
             * BUCLE FOR
             */

            //for (int i = 0 ; i <= 10;  i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //    for (int i = 0; i <= 10; i += 2)   
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 3; i++)
            //{
            //    for (int j = 0; j <= 3; j++)
            //    {
            //        Console.Write($"[{i},{j}] ");
            //    }
            //    Console.WriteLine();
            //}

            /*
             * BUCLE FOREACH
             */

            //string fruta = "manzana";

            //foreach(char c in fruta)
            //{
            //    Console.WriteLine(c);
            //}


            /*
             * Métodos
             */
            //Program p1 = new Program();
            //double resultado = p1.SumarDosNum(3.3, 13.1);
            //Console.WriteLine(resultado);

            //double Producto(double a, double b)
            //{
            //    return a * b;
            //}

            //Console.WriteLine(Producto(4, 3));

            /*
              Tipo ENUM
             */

            Console.WriteLine(Day.miércoles);
            
        }

        enum Day { lunes, martes, miércoles, viernes, sábado, domingo};
        public double SumarDosNum(double a, double b)
        {
            return a + b;
        }
    }
}