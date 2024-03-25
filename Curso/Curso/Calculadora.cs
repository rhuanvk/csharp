using Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal static class Calculadora
    {
        public static int Soma(params int[] numeros)
        {
            int soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            return soma;
        }

        public static void Triplica(ref int num)
        {
            num *= 3;
        }

        public static int ReturnTriplica(int num)
        {
            return num *= 3;
        }

        public static void TriplicaComOut(int num, out int result)
        {
            result = num * 3;
        }

    }
}

/*int x = 5;
Calculadora.Triplica(ref x);
Console.WriteLine(x);

int y = Calculadora.ReturnTriplica(x);
Console.WriteLine(y);

int z;

Calculadora.TriplicaComOut(x, out z);
Console.WriteLine(z);*/