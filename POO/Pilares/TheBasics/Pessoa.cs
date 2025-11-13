using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// namespace pode ser considerado como a pasta do projeto
// namespace é o módulo do sistema
// namespace é com o um pacote, 
namespace TheBasics
{
    public class Pessoa
    {
        public string Nome = "";

        public int Idade;

        public Endereco EnderecoCompleto;
        
        public Pessoa(Endereco endereco){
            EnderecoCompleto = endereco;
        }

        public void Falar()
        {
            System.Console.WriteLine($"Olá, eu sou {Nome} e tenho {Idade} anos");

        }

        public void Envelhecer()
        {
            Idade++;
        }
    }
}