using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome = "";

        public int Idade;

        //metodo construtor de Pessoa
        //possui parametros - representam os valores de Nome e Idade
        //ou seja, estamos inicializando valores para as props
        //nome e idade
        public Pessoa(string n, int i)
        {
            Nome = n; //inicializa com o valor de n
            Idade = i; //inicializa com o valor de i
        }


        public void ExibirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}