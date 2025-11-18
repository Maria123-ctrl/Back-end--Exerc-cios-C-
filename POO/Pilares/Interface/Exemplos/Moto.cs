using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Moto : IMotor
    {
        public void Acelerar()
        {
            Console.WriteLine($"Moto Acelendo");
        }
    }
}