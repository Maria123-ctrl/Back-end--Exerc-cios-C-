using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Garrafa
    {
        //propriedades

        public int quantidade;

        public string marca;

        public string modelo;

        public string cor;

        //métodos
        public void Esvaziar()
        {
            Console.WriteLine($"Esvazeando a garrafa");
        }
        public void Encher()
        {
            Console.WriteLine($"Enchendo a garrafa");
        }
        public void Lavar()
        {
            Console.WriteLine($"Lavando a garrafa");
        }
        public void Secar()
        {
            Console.WriteLine($"Secando a garrafa");
        }
    }
}