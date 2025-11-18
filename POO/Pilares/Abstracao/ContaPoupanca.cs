using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao
{
    public class ContaCorrente : ContaBancaria
    {
         private double Taxa = 0.03;
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
            double totalComTaxa =  valor + (valor * Taxa);
            
            if(valor <= 0 || totalComTaxa >= Saldo)
            {
                Console.WriteLine($"O valor do saque deve positivo e ter dinheiro suficiente para o saque (Conta Corrente)");
                return;
            }
           
            // Console.WriteLine($"Saldo {Saldo}");
            Saldo -= valor;
        }
       
        // Saldo -= totalComTaxa;
         
    }
}