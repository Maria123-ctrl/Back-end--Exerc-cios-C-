using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao
{
    public class Cachorro : Animal 
    {
        public override void FazerSom()
        {
            System.Console.WriteLine($"Au Au");
        }
        public override void Mover()
        {
            System.Console.WriteLine($"Poc Poc");
        }
    }
}