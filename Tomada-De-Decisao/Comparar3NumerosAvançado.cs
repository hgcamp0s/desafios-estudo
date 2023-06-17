/*
    Faça um programa que leia 3 números e imprima uma das seguintes mensagens:
    "Todos os números são iguais"
    "Todos os números são diferentes"
    "Apenas dois números são iguais" 
*/

using System;

List<int> numeros = new List<int>();

Console.WriteLine("Digite o primeiro número:");
numeros.Add(int.Parse(Console.ReadLine()));

Console.WriteLine("Digite o segundo número:");
numeros.Add(int.Parse(Console.ReadLine()));

Console.WriteLine("Digite o terceiro número:");
numeros.Add(int.Parse(Console.ReadLine()));

int contadorIguais = 0;
int numeroIgual = 0;

for (int i = 0; i < numeros.Count; i++) // Primeiro loop percorre a lista de números
{
    int contador = 0;
    for (int j = 0; j < numeros.Count; j++) // Segundo loop faz a comparação entre os números
    {
        if (numeros[i] == numeros[j]) //Compara se um número é igual ao outro
        {
            contador++; // Toda vez que encontrar um número igual incrementamos em 1 o contador
        }
    }

    if (contador > contadorIguais) // Se o contador atual for maior que o contador mais alto, significa que encontramos um número com mais ocorrências
    {
        contadorIguais = contador; // Portando, atualizamos o valor do contador mais alto 'contadorIguais' para o valor do contador atual
        numeroIgual = numeros[i]; // E armazenamos o número correspondente na variável 'numeroIgual'
    }
}

if (contadorIguais == 1)
{
    Console.WriteLine("Todos os números são diferentes.");
}
else if (contadorIguais == 2)
{
    Console.WriteLine("Apenas dois números são iguais.");
}
else
{
    Console.WriteLine("Todos os números são iguais.");
}