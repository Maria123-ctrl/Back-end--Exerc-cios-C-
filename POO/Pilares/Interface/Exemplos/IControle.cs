using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public interface IControle
    {
        //métodos
        void Ligar();

        void Desligar();

        void AumentarVolume();

        void DiminuirVolume();
    }
}