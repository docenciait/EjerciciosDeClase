namespace Encapsulación
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            //Console.WriteLine(empleado.Id);
            //empleado.Id = "efg";

            // Forma 3


            empleado.salary2 = -23323;
        }
    }

    public class Empleado
    {
        // Forma 1

        // public string Id { private get; set; } = "abc";
        //public string Id { get; private set; } = "abc";

        // Forma 2

        private string _name = "abc";

        public Empleado() { }
        public Empleado(string name)
        {
            _name = name;
            
        }

        // Forma 3

        private decimal _salary = 3000;


        public decimal salary
        {
            get { return _salary; }
            set { _salary = value; }

        }

        public decimal salary2
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                {
                    _salary = value;
                }
                else
                {
                    throw new ArgumentException("Salary cannot be negative.");
                }
            }
        }
    }
}
