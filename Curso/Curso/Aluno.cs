using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Curso
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double[] Notas;
        public int NotaNecessaria = 60;

        public double NotaFinal()
        {
            double notaFinal = 0;

            foreach (double nota in Notas)
            {
                notaFinal += nota;
            }

            return notaFinal;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
