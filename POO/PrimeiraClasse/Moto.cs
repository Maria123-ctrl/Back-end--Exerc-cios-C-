using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Moto
    {
        // propriedades
        public int qtdRodas;

        public string modelo;

        public string marca;

        public string cor;

        //métodos
        public void Acelerar()
        {
            Console.WriteLine($"Moto Acelerando RANDANDANDANDAN");
        }
        public void Frear()
        {
            Console.WriteLine($"Moto Freando");
        }
        public void Ligar()
        {
            Console.WriteLine($"Moto Ligando...");
        }
        public void Desligar()
        {
            Console.WriteLine($"Moto desligando");
        }
    }
}