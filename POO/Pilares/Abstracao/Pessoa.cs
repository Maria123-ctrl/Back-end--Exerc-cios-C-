using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao
{
    public class Pessoa : Animal
    {

        public string Nome;

        public int Idade;

        
        public override void FazerSom()
        {
           System.Console.WriteLine($"Oi, meu nome é Maria Eduarda");
        }

        public override void Mover()
        {
            System.Console.WriteLine($"Estou me alongando");
        }
    }
}