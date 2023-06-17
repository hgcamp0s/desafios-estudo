/*
    Faça um programa que leia 2 números e imprima uma mensagem dizendo o maior deles.
    Suponha que os números serão diferentes.
*/

using System;

Console.WriteLine("Digite o primeiro número:");
double x = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
double y = double.Parse(Console.ReadLine());

if (x > y)
{
    Console.WriteLine($"O maior é o primeiro número: {x}");
}
else if (x < y)
{
    Console.WriteLine($"O maior é o segundo número: {y}");
}
else
{
    Console.WriteLine("Os números são iguais.");
}