using ObjectMethods.Modelos;

namespace ModificadoresDeAcceso
{
 public class Program
    {
        public static void Main()
        {
            // public
            EjemploPublic ejemplo = new EjemploPublic();
            Console.WriteLine(ejemplo.PruebaAcceso); //Funciona correctamente

            EjemploPrivate ejemplo2 = new EjemploPrivate();
            Console.WriteLine(ejemplo.PruebaAcceso); //Da un error

            // Internal
            EjemploInternalLibreria e = new EjemploInternalLibreria();

            // Protected
            EjemploProtected ejemplo3 = new EjemploProtected();
            Console.WriteLine(ejemplo3.PruebaAcceso); // Error. no podemos acceder ya que esta clase no hereda de EjemploProtected

        }
    }
}

// public
public class EjemploPublic
{
    public string PruebaAcceso { get; set; }
}

// private
public class EjemploPrivate
{
    private string PruebaAcceso { get; set; }

    public EjemploPrivate()
    {
        PruebaAcceso = "funciona";
    }
}

// protected
class EjemploProtected
{
    protected string PruebaAcceso { get; set; }
}

class claseHerencia : EjemploProtected //Herencia, osea clase hija.
{
    void Imprimir()
    {
        Console.WriteLine(PruebaAcceso); //Accedemos sin problemas ya que es una propiedad de la clase padre.
    }
}

/**
 * protected internal: Combina tanto protected como internal permitiendo acceder desde el mismo proyecto o assembly o 
 * de los tipos que lo derivan.
 * 
 * private protected: Finalmente combinamos private y protected lo que nos permitirá acceder desde la clase actual o 
 * desde las que derivan de ella. Lo que permite referenciar métodos y propiedades en clases de las cuales heredamos.
 * 
 * 
 * /