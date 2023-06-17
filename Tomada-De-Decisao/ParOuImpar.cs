/*
    Faça um programa que leia um número e imprima uma mensagem dizendo se é par ou ímpar. 
*/

using System;

Console.WriteLine("Digite um número:");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número é ímpar.");
}