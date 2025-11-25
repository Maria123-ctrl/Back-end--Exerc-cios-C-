using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Gerente
    {
        public double Bonus;

        public override double CalcularSalario()
        {
            return SalarioBase + Bonus;
        }

        // public Gerente(string nome, double salarioBase, double bonus)
        //     : base(nome, salarioBase)
        // {
        //     Bonus = bonus;
        // }

        // // Sobrescreve o método para incluir o bônus
        
    }

}