using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class Aluno
    {
        public string Nome = "";

        public int Nota;

        public Aluno()
        {
            Nome = "Desconhecido";
            Nota = 0;
        }

        public Aluno(string n, int nt)
        {
            Nome = n;
            Nota = nt;
        }
    }
}