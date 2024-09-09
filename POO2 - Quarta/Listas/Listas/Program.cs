using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> valores = new List<int>();

            valores.Add(16);
            valores.Add(18);
            valores.Add(23);
            valores.Add(12);

            int[] numeros = new int[] { 32, 12, 7, 20 };
            valores.AddRange(numeros);

            valores.Insert(1, 2);

            foreach (int item in valores)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();

        }
    }
}
