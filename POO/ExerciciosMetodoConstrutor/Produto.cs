using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class Produto
    {
        public string Nome;

        public double preco;

        public int estoque;

        public Produto(string n, double p, int e)
        {
            Nome = n;

            preco = p;

            estoque = e;
        }

        public void ExibirDados(string n, double p, int e)
        {
            System.Console.WriteLine($"Nome: {n}, Preço: {p}, Estoque: {e}");
        }
    }
}