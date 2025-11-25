using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Carro
    {
        private string Modelo = "";

        private string Marca = "";

        private int velocidadeAtual;

        public void DefinirMarca(string valor)
        {
            Marca = valor;
        }

        public string ObterMarca()
        {
            return Marca;
        }
        public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }

        public string ObterModelo()
        {
            return Modelo;
        }

        public int ObeterVelocidade()
        {
            return velocidadeAtual;
        }

        public void Acelerar(int valor)
        {
            if (valor > 0)
                velocidadeAtual += valor;
        }

        public void Frear(int valor)
        {
            if (valor > 0)
                velocidadeAtual -= valor;
        }
    }
}