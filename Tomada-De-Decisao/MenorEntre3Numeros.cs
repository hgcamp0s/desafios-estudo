/*
    Faça um programa que leia 3 números e imprima o menor deles. 
*/

using System;

Console.WriteLine("Digite o primeiro número:");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o primeiro número:");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o primeiro número:");
int numero3 = int.Parse(Console.ReadLine());

int menor = numero1;

if (numero2 < menor)
{
    menor = numero2;
}

if (numero3 < menor)
{
    menor = numero3;
}

Console.WriteLine($"O menor número é: {menor}");