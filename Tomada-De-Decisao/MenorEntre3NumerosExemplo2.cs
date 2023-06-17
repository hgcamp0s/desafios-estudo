/*
    Faça um programa que leia 3 números e imprima o menor deles. 
*/

using System;

List<int> numeros = new List<int>(); // Lista chamada 'numeros' para armazenar os valores fornecidos pelo usuário

Console.WriteLine("Digite o primeiro número:");
numeros.Add(int.Parse(Console.ReadLine())); // Método 'Add()' da lista para adicionar cada número lido pelo 'Console.Readline()'

Console.WriteLine("Digite o segundo número:");
numeros.Add(int.Parse(Console.ReadLine()));

Console.WriteLine("Digite o terceiro número:");
numeros.Add(int.Parse(Console.ReadLine()));

int menor = numeros[0]; // Iniciamos a variável 'menor' com o primeiro elemento da lista ('numeros[0]')

for (int i = 1; i < numeros.Count; i++) // Utilizamos o loop for para percorrer os elementos restantes da lista
{
    if(numeros[i] < menor) // Comparando cada número com 'menor', s'e algum número for menor que 'menor'
    {
        menor = numeros[i]; // Atualizamos o valor de 'menor'
    }
}

Console.WriteLine($"O menor número é: {menor}");