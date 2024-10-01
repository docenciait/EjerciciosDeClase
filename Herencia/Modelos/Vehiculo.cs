using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Modelos
{
    public class Vehiculo2 { }
    public class Vehiculo
    {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroRuedas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo() { }
        public Vehiculo(decimal velocidadMaxima, int NumeroRuedas)
        {
            VelocidadMaxima = velocidadMaxima;
            NumeroRuedas = NumeroRuedas;
        }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public void Acelerar()
        {
            //Código aquí
        }

        public void Arrancar()
        {
            //Código aquí
        }
    }

    class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }

        public Moto(decimal velocidadMaxima, int NumeroRuedas, int cilindrada) : base(velocidadMaxima, NumeroRuedas)
        {
            Cilindrada = cilindrada;
        }

        public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
        {
            Cilindrada = cilindrada;
        }

        public void HacerCaballito()
        {
            //codigo
        }
    }

    class Coche : Vehiculo
    {
        public string Traccion { get; set; }

        public Coche(string marca, string modelo, string Traccion) : base(marca, modelo)
        {

        }

        public bool CerrarPuertas()
        {
            return false;
        }

    }
}
