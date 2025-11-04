using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    public class Pessoa
    {
        public string Nome = "";

        public int Idade = 0;

        public void Falar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }
        //aqui, vem não treina envelhece mais de um ano por vez
        public int Envelhecer(int _anos)
        {
            if (_anos <= 0)
            {
                Console.WriteLine($"Idade tem que ser positiva!");
                return Idade;
            }

            Idade += _anos;

            return Idade;
        }
    }
}