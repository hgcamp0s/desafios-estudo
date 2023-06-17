/*
    Faça um programa que leia 2 números da entrada e imprima o resto da divisão inteira de um pelo outro
*/

using System;

Console.WriteLine("Digite o primeiro número:");
decimal numero1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
decimal numero2 = Convert.ToDecimal(Console.ReadLine());

decimal resto1 = numero1 % numero2;
decimal resto2 = numero2 % numero1;

decimal restoDivisao = resto1 % resto2;

Console.WriteLine($"O resto da divisão de {numero1} por {numero2} é: {restoDivisao}");