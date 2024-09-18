using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pede um número
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            // Loop for que repete o número cinquenta vezes, com incremento de +1
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Repetição {i + 1}: {numero}");
                numero++; // Incrementa o número
            }

            Console.ReadLine();
        }
    }
}
