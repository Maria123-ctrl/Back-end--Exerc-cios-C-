using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine($"Gatinho Miau miau");
        }
        public override void Mover()
        {
            System.Console.WriteLine($"Movendo as patinhas");
        }
    }
}