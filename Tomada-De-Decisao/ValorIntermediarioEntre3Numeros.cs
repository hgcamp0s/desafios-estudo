/*
    Faça um programa que leia 3 números e imprima o valor intermediário, entre o menor e o maior número. 
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

int indiceMeio = numeros.Count / 2; // Calculos o indice do elemento do meio divindo o tamanho da lista por 2
int valorIntermediario = numeros[indiceMeio]; // Acessamos o elemento do meio usando 'numeros[indiceMeio] e armazenamos o valor intermediario na variável 'valorIntermediario'

Console.WriteLine($"Valor Intermediário: {valorIntermediario}");