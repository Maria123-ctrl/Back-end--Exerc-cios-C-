using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }
        public ContaBancaria(float saldoInicial)
        {
            if(saldoInicial >= 0)
            {
                Saldo = saldoInicial;
                return;
            }
        }
        // metodo que guarda o saldo
        public void Depositar(float valor)
        {
            if(valor >= 0)
            {
                Saldo = valor;
                return;
            }

            System.Console.WriteLine($"Valor para depósito inválido");
        }
        // metodo publico que retorna o Saldo
        public float GetSaldo()
        {
            return Saldo;
        }

        public void Sacar(float valor)
        {
            if(valor <= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                System.Console.WriteLine($"Saque feito com sucesso!");
                return;
            }
            else
            {
               System.Console.WriteLine($"Valor para saldo inválido");
            }
        }
    }
}