/*
    Faça um programa que leia um número da entrada e imprima os números naturais de 0 até este número,
    pulando de dois em dois. Suponha que o número lido da entrada será maior que zero.
*/

using System;


Console.WriteLine("Digite um número:");
int numero = int.Parse(Console.ReadLine());

for (int count = 0; count <= numero; count += 2)
{
    int result = count;
    Console.WriteLine($"{result}");
}