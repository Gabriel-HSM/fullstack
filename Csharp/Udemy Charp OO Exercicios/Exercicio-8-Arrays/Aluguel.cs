using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_Arrays
{
    public class Aluguel
    {
        public string NomeEstudante { get; set; }
        public string EmailEstudante { get; set; }

        public Aluguel(string nome, string email)
        {
            NomeEstudante = nome;
            EmailEstudante = email;
        }

        public override string ToString()
        {
            return NomeEstudante + ", " + EmailEstudante;
        }
    }
}