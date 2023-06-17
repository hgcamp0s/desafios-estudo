/*
    Faça um programa que leia um número e imprima seu valor absoluto(sem o sinal). 
*/

using System;

Console.WriteLine("Digite um número:");
double numero = double.Parse(Console.ReadLine());

double valorAbsoluto = Math.Abs(numero); // Método 'Math.Abs()' calcula o valor absoluto e o armazena na variável

Console.WriteLine($"O valor absoluto do número é: {valorAbsoluto}");