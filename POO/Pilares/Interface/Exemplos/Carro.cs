using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Carro : IMotor
    {
        public void Acelerar()
        {
            Console.WriteLine($"Carro Acelerando");
        }
    }
}