/*
    Faça um programa que leia 2 números da entrada e imprima a sua média aritmética
*/

using System;

Console.WriteLine("Entre com o primeiro número: ");
decimal x = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Entre com o segundo número: ");
decimal y = Convert.ToDecimal(Console.ReadLine());

decimal z = (x + y) / 2;

Console.WriteLine($"A média aritmética é: {z}");