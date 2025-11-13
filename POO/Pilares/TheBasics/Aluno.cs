using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Aluno : Pessoa
    {
        // Cria um construtor na classe aluno que recebe o endereço
        // chama o constrtutor da classe mãe e repassa o
        // endereço para ela
        
        public Aluno(Endereco endereco) : base(endereco)
        {

        }

        public string RA;

        public float NotaFinal;

        public string Curso;
    }
}