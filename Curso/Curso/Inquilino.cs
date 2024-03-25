using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class Inquilino
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Inquilino(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Email: {Email}";
        }

    }
}

            /*int n;
            Inquilino[] quartos = new Inquilino[10];

            Console.Write("Quantos quartos serão alugados? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Quarto {i}:");
                Console.Write("Inquilino: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto desejado: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Inquilino(nome, email);
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"Quarto {i}: {quartos[i]}");
                }
            }*/
