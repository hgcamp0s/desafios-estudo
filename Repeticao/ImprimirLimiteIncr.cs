/*
    Faça um programa que leia um número da entrada (limite), um incremento (incr) e imprima os números naturais de 0 até limite
    pulando de incr.
*/

using System;

Console.WriteLine("Digite um limite:");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o incremento:");
int incr = int.Parse(Console.ReadLine());

for (int count = 0; count <= numero; count += incr)
{
    int result = count;
    Console.WriteLine($"{result}");
}