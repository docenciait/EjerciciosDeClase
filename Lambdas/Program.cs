using System.Threading.Tasks.Sources;

namespace Lambdas
{

    /*
     
        Expresiones lambda:

        (parametros) => expresión;
     
     */
    public class Program
    {
        static void Main(string[] args)
        {
            Action a = () => Console.WriteLine("hello");
            a();
        }
    }

    

}
