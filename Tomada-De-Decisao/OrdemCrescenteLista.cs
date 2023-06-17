/*
    Faça um programa que leia 3 números e os imprima em ordem crescente 
*/

using System;

List<int> numeros = new List<int>(); // Lista chamada 'numeros' para armazenar os valores fornecidos pelo usuário

Console.WriteLine("Digite o primeiro número:");
numeros.Add(int.Parse(Console.ReadLine())); // Método 'Add()' da lista para adicionar cada número lido pelo 'Console.Readline()'

Console.WriteLine("Digite o segundo número:");
numeros.Add(int.Parse(Console.ReadLine()));

Console.WriteLine("Digite o terceiro número:");
numeros.Add(int.Parse(Console.ReadLine()));

numeros.Sort(); // Ordena a lista em ordem crescente

Console.WriteLine($"Ordem crescente:");
for (int i = 0; i < numeros.Count; i++) // Percorre a lista ordenada e exibe cada número em ordem crescente
{
    Console.WriteLine($"{numeros[i]}");
}