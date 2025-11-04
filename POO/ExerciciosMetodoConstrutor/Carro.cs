using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class Carro
    {
        public string marca = "";

        public string modelo = "";

        public int ano;

        //métodos


        public Carro(string md, string mc, int a)
        {
            modelo = md;
            marca = mc;
            ano = a;
        }

        public void ExibirDados(string md, string mc, int a)
        {
            System.Console.WriteLine($"Carro: {mc}, {md}, ano: {a}");
        }

    }
}
