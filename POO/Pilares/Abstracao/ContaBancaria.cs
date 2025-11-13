using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao
{
    public abstract class ContaBancaria
    {
        public double Saldo = 0;
        public abstract void Depositar(float valor);
        public abstract void Sacar(float valor);
            
        
    }
}