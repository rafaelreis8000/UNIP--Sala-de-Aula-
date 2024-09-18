using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definindo a matriz de nomes com cinco nomes padrão
            string[] nomes = { "Zeca", "Jorge", "Piririu", "Robert", "Mihan" };

            // Exibindo os nomes usando a estrutura foreach
            Console.WriteLine("Nomes da lista:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            // Exibindo os nomes em maiúsculas usando ToUpper()
            Console.WriteLine("\nNomes em maiúsculas:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome.ToUpper());
            }
        }
    }
}
