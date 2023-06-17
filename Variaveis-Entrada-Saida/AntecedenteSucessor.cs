/*
    Faça um programa que leia um número da entrada e imprima o seu antecedente e o seu sucessor.
*/

using System;

Console.WriteLine("Digite um número:");
string entrada = Console.ReadLine();

while (!string.IsNullOrEmpty(entrada))
{
    if (int.TryParse(entrada, out int n))
    {
        Console.WriteLine($"O antecessor de {n} é {n - 1} e seu sucessor é {n + 1}");
        break;
    }
    Console.WriteLine("Digite um número:");
    entrada = Console.ReadLine();
}