namespace ObjectMethods.Modelos
{
    public class Empleado
    {
        public int Id;
        public string Name;
        public string LastName;
        public double Salary;

        public Empleado(int Id, string Name, string LastName, double Salaray)
        {
            this.Id = Id;
            this.Name = Name;
            this.LastName = LastName;
            Salary = Salaray;
        }
        public void Play()
        {
            Console.WriteLine("Toca la guitarra");
        }

    }

}
