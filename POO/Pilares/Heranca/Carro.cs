using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Carro : Veiculo
    {
        public int qntPortas = 0;
        public override void MostrarInfo()
        {
            Console.WriteLine(@$"Modelo: {Modelo}
                                 Marca: {Marca}
                                 Portas: {qntPortas}");
        }
    }
}