/*
    Faça um programa que leia um número da entrada e imprima os números naturais de 0 até este número.
    Suponha que o número lido da entrada será maior que zero.
*/

using System;

Console.WriteLine("Digite um número:");
int numero = int.Parse(Console.ReadLine());

if (numero > 0)
{
    for (int count = 0; count < numero; count++)
    {
        int result = count + 1;
        Console.WriteLine($"{result}");
    }
}
else
{
    Console.WriteLine("Digite um número válido.");
}