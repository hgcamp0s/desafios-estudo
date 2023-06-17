/*
    Faça um programa que leia um intervalo da entrada(inicio e fim) e imprima os números naturais neste intervalo.
*/

using System;

Console.WriteLine("Digite o início:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o fim:");
int y = int.Parse(Console.ReadLine());

for (int z = x; z <= y; z++)
{
    Console.WriteLine($"{z}");
}