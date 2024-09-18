using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Cria uma lista genérica
        List<int> numeros = new List<int>();
        int contador = 0;

        // utiliza o laço while cinco vezes para adicionar números à lista
        while (contador < 5)
        {
            numeros.Add(contador); // Adiciona o valor de contador na lista
            Console.WriteLine("Adicionando: " + contador);
            contador++; // Incrementa o contador
        }

        Console.WriteLine("\nNúmeros na lista:");
        // Exibindo os números da lista
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
