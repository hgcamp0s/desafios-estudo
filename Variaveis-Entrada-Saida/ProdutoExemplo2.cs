/*
    Faça um programa que leia 2 números da entrada e imprima seu produto.
*/

using System;

Console.WriteLine("Entre com o primeiro número: ");
decimal x = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Entre com o segundo número: ");
decimal y = Convert.ToDecimal(Console.ReadLine());

decimal z = x * y;

Console.WriteLine($"O produto entre os números é: {z}");