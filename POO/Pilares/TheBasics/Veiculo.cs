using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Veiculo
    {
        public string Marca;

        public string Modelo;

        public void Ligar()
        {
            System.Console.WriteLine($"Ligando o veículo");
        }

        public void Desligar()
        {
            System.Console.WriteLine($"Veículo desligando");
        }
    }
}