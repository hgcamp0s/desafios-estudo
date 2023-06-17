/*
    Faça um programa que leia 3 números e imprima uma das seguintes mensagens:
    "Todos os números são iguais"
    "Todos os números são diferentes"
    "Apenas dois números são iguais" 
*/

using System;

Console.WriteLine("Digite o primeiro número:");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número:");
int numero3 = int.Parse(Console.ReadLine());

if (numero1 == numero2 && numero1 == numero3)
{
    Console.WriteLine("Todos os números são iguais.");
}
else if (numero1 == numero2 && numero1 != numero3)
{
    Console.WriteLine("Apenas dois números são iguais.");
}
else 
{
    Console.WriteLine("Todos os números são diferentes.");
}