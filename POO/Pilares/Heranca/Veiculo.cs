using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Veiculo
    {
        public string Marca = "";
        public string Modelo = "";
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Vrum Vrum");
        }
    }
}