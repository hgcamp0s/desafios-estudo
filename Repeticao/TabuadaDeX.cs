/*
    Faça um programa que leia um número da entrada e imprima a tabuada deste número.
    Suponha que o número lido da entrada é maior que zero.
*/

using System;

Console.WriteLine("Digite um número:");
int x = int.Parse(Console.ReadLine());

if (x > 0)
{
    for (int count = 1; count <= 10; count++)
    {
        int result = x;
        result = result * count;
        Console.WriteLine($"{x} x {count} = {result}");
    }
}
else 
{
    Console.WriteLine("Digite um número maior que 0");
}