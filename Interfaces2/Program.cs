namespace Interfaces2
{
    /**
     * - Son comportamientos que pueden ser implementados por varias clases
     * - Se declaran sólo métodos
     * - Establecen un contrato, hay que implementar los métodos
     */
    public class Program
    {
        static void Main() 
        {
            IMessageService messageServiceWA = new Whatsapp();
            IMessageService messageServiceTel = new Telephone();

            Program program = new Program();
            program.SendMessage(messageServiceWA);
            program.SendMessage(messageServiceTel);

        }

        public void SendMessage(IMessageService messageService)
        {
            messageService.Enviar();
        }
    }

    public interface IMessageService
    {
        //public string Id { get; set; }
        public void Enviar();
        public void Recibir();

        public void Borrar(Chat m);

    }

    public class Whatsapp : IMessageService
    {
        //public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

       
        public void Borrar(Chat m)
        {
            Console.WriteLine("Borrar mensaje WA");
        }

        public void Enviar()
        {
            Console.WriteLine("Enviar WA");
        }

        public void Recibir()
        {
            Console.WriteLine("Recibir mensaje WA");
        }
    }

    public class Telephone : IMessageService
    {
        public void Borrar(Chat m)
        {
            Console.WriteLine("Borra chat de teléfono");
        }

        public void Enviar()
        {
            Console.WriteLine("Envía mensaje teléfono");
        }

        public void Recibir()
        {
            Console.WriteLine("Recibe mensaje teléfono");
        }
    }

    public class Chat
    {
    }
}