using System;

namespace CompanyManagement
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Gerente empleado = new Gerente();
            empleado.TrabajaCuentaAjena();
            empleado.GestionaProyectos();
            
        }
    }

    // Comportamiento empleado

    
    public interface IEmpleado
    {
        public void TrabajaCuentaAjena();
    }

    public interface IEmpleadoFijo : IEmpleado 
    {
        public void SinQueMeDespidan();
    }

    // Comportamiento Freelance
    public interface IFreelancer
    {
        public void RealizaFacturas();
    }

    // Comportamiento Manager
    public interface IProjectManager
    {
        public void GestionaProyectos();
    }

    // Clase que representa un gerente de proyecto que es empleado fijo

    public class Gerente : IProjectManager, IEmpleado
    {
        public void GestionaProyectos()
        {
            Console.WriteLine("Gestionamos Proyectos");
        }

        public void TrabajaCuentaAjena()
        {
            Console.WriteLine("Trabajamos por cuenta ajena"); ;
        }
    }


    // Lo mismo pero con herencia de un interfaz además de la múltiple
    public class Gerente2 : IProjectManager, IEmpleadoFijo
    {
        public void GestionaProyectos()
        {
            throw new NotImplementedException();
        }

        public void SinQueMeDespidan()
        {
            throw new NotImplementedException();
        }

        public void TrabajaCuentaAjena()
        {
            throw new NotImplementedException();
        }
    }



}
