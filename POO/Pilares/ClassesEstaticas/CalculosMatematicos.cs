using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        // Operacoes matematicas simples
        // visibilidade tipoRetorno Nome(parametros)
        public static float Somar(float a, float b)
        {
            return a + b;
        }
        public static float Subtracao(float a, float b)
        {
            return a - b;
        }
        public static float Multiplicacao(float a, float b)
        {
            return a * b;
        }
        public static float Divisao(float a, float b)
        { 
              return a / b; 
        }
    }
}