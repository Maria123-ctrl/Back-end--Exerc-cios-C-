using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Carro : Veiculo
    {
        public void AbrirPortaMala()
        {
            System.Console.WriteLine($"Porta-malas aberto");
        }
    }
}