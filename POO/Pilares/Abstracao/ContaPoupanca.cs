using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao
{
    public class ContaCorrente : ContaBancaria
    {
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
            Saldo -= valor;
            Console.WriteLine($"Saldo {Saldo}");
        }
        public void CalcularSaldo()
        {
            Saldo += 0.02f * Saldo;
            Console.WriteLine($"Saldo {Saldo}");

        }
    }
}