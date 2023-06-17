/*
    Faça um programa que leia 2 números e os imprima em ordem crescente 
*/

using System;

Console.WriteLine("Digite o primeiro número:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int y = int.Parse(Console.ReadLine());

int menor = Math.Min(x, y); // Método que encontra o menor valor e atribui à variável 'menor'
int maior = Math.Max(x, y); // Método que encontra o maior valor e atribui à variável 'maior'

Console.WriteLine("Os números em ordem crescente são:");
Console.WriteLine($"{menor}");
Console.WriteLine($"{maior}");