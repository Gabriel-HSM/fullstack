using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_2_metodos_e_oo
{
    public class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double calcularNota()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (calcularNota() < 60.0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado() == true)
            {
                return 0.0;
            }
            else
            {
                return 60.0 - calcularNota();
            }
        }
    }
}