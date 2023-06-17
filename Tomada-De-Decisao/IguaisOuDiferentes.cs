/*
    Faça um programa que leia 2 números e imprima uma mensagem dizenedo se são iguais ou diferentes
*/

using System;

Console.WriteLine("Digite o primeiro número:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int y = int.Parse(Console.ReadLine());

if (x == y)
{
    Console.WriteLine("São iguais.");
}
else
{
    Console.WriteLine("São diferentes.");
}