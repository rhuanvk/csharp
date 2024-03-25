using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class ConversorDeMoeda
    {
        public static double ParaDolar(double cotacao, double quantidade)
        {
            return cotacao * (quantidade + (quantidade * 0.06));

        }
    }
}
