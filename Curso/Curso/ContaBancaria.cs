using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class ContaBancaria
    {
        public string Titular { get; private set; }
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string titular, int conta, double saldo)
        {
            Titular = titular;
            Conta = conta;
            Deposito(saldo);
        }

        public override string ToString()
        {
            return $"Dados da conta {Conta}, Titular: {Titular}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void Deposito(double quantidade)
        {
            Saldo += quantidade;   
        }

        public void Saque(double quantidade)
        {
            Saldo -= quantidade;
        }


    }
}

            /*string Titular;
            int NumeroConta;
            double Saldo = 0.00;
            string DepositoInicial;
            ContaBancaria Conta;

            Console.Write("Informe o número da conta: ");
            NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do titular: ");
            Titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n): ");
            DepositoInicial = Console.ReadLine();



            while (DepositoInicial != "s" && DepositoInicial != "n")
            {
                Console.WriteLine("Digite apenas s ou n.");
                Console.Write("Haverá depósito inicial? (s/n): ");
                DepositoInicial = Console.ReadLine();
            }

            if (DepositoInicial == "s")
            {
                Console.WriteLine("Qual será o valor do depósito inicial? ");
                Saldo = double.Parse(Console.ReadLine());
            }
            else if (DepositoInicial == "n")
            {
                Saldo = 0.00;
            }

            Conta = new ContaBancaria(Titular, NumeroConta, Saldo);

            Console.WriteLine(Conta);

            Console.Write("Informe um valor para depósito: ");
            Conta.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine(Conta);

            Console.Write("Informe um valor para saque: ");
            Conta.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine(Conta);*/