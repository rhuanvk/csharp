using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class Retangulo
    {
        public double L; // largura
        public double A; // altura

        public double Area()
        {
            return L * A;
        }

        public double Perimetro()
        {
            return 2 * (L + A);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(L, 2) + Math.Pow(A, 2));
        }
    }
}
