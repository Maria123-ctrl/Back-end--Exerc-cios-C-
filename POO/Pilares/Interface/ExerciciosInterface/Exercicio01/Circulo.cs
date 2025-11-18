using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Exemplos
{
    public class Circulo : IForma
    {
        public float Raio;
        private float PI = 3.14f;
        public void CalcularArea()
        {
            Console.WriteLine($"O raio do círculo é: {PI * Raio * Raio}");
        }
    }

}