using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao
{
    public class ContaPoupanca : ContaBancaria
    {
        private double Taxa = 0.05;//5% de taxa 
        public override void Depositar(float valor)
        {

            if(valor <= 0)
            {
                Console.WriteLine($"O valor do depósito deve ser maior que R$0,00");
                return;
            }
            Saldo += valor;
        }

        public override void Sacar(float valor)
        {
                        //valor solicitado + taxa de 1%
            double totalComTaxa = valor + (valor * Taxa);



            if( valor <= 0 || totalComTaxa >= Saldo)
            {
                Console.WriteLine($"O valor do saque deve positivo e ter dinheiro suficiente para o saque");
                return;// para a execução do método por aqui
            }
            Saldo -= totalComTaxa;
    
        }
        public void CalcularSaldo()
        {
            Saldo += 0.05f * Saldo;
            Console.WriteLine($"Saldo {Saldo}");

        }
    }
}