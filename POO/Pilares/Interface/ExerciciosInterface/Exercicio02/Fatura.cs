using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Fatura : IImprimivel
    {

        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        public float Juros = 0.10f;

        public Fatura(string dev, string cred, float valFat, int qtdAtraso )
        {
            Devedor = dev;
            Credor = cred;
            DiasDeAtraso = qtdAtraso;
            Valor = valFat;
        }
        public void Imprimir()
        {
            CalcularValorDivida();
            System.Console.WriteLine($"Credor:  {Credor}...");
            System.Console.WriteLine($"Devedor:  {Devedor}...");
            System.Console.WriteLine($"Juros:  R${(Juros * DiasDeAtraso):F2}...");
            System.Console.WriteLine($"Valor:  R${Valor:F2}");
            System.Console.WriteLine($"Total com juros:  R{Valor:F2}...");
            System.Console.WriteLine($"Dias De Atraso:  {DiasDeAtraso} dia(s)");
        }

        public void CalcularValorDivida()
        {
            if(DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }
            if(DiasDeAtraso >= 5)
            {
                System.Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }
    }
}