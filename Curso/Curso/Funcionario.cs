using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double ValorImposto;

        public override string ToString()
        {
            return $"DADOS ATUALIZADOS: O funcionário {Nome} recebe R$ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)} de salário.";
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - ValorImposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
        }
    }
}
