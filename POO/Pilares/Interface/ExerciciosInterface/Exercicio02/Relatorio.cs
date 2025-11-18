using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string Nome = "";
        public string TextoRelatorio = "";

        public Relatorio(string responsavel, string txtRealatorio)
        {
            Nome = responsavel;
            TextoRelatorio = txtRealatorio;
        }
        public void Imprimir()
        {
            System.Console.WriteLine($"Imprimimindo Relatorio do {Nome}...");
            System.Console.WriteLine(TextoRelatorio);
            System.Console.WriteLine($"--");
        }
    }
}