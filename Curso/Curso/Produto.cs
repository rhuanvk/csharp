using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class Produto
    {
        public string Nome;
        public double ValorUnitario;
        public int QuantidadeEstoque;

        public override string ToString()
        {
            return $"Com {QuantidadeEstoque} unidades de {Nome} disponíveis em estoque, o valor total é de R$ {ValorTotal().ToString("F2", CultureInfo.InvariantCulture)}.";
        }

        public double ValorTotal()
        {
            return ValorUnitario * QuantidadeEstoque;
        }

        public void AdicionarEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }

        public void RemoverEstoque(int quantidade)
        {
            QuantidadeEstoque -= quantidade;
        }
    }
}
