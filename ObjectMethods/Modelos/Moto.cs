using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods.Modelos
{

    public class Moto
    {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroRuedas { get; set; }
        public Motorista Piloto { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }

        public void Acelerar()
        {
            //Código aquí
        }
        public void Arrancar()
        {
            //Código aquí
        }

        public Moto()
        {
            VelocidadMaxima = 200;
            NumeroRuedas = 2;

        }

        public Moto(Motorista p)
        {
            Piloto = p;
        }

        public Moto(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public Moto(int velocidadMaxima, int numeroRuedas)
        {
            VelocidadMaxima = velocidadMaxima;
            NumeroRuedas = numeroRuedas;
        }



    }
}
