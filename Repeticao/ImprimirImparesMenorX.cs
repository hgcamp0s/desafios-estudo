/*
    Faça um programa que leia um número da entrada e imprima os números impares menores do que este número.
*/

using System;

Console.WriteLine("Digite um número:");
int numero = int.Parse(Console.ReadLine());

for (int count = 0; count < numero; count ++)
{
    if (count % 2 != 0)
    {
        int result = count;
        Console.WriteLine($"{result}");
    }
}