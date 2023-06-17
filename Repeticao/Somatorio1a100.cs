/*
    Faça um programa que imprima os números de 1 a 100 e o valor de seu somatório.
*/

using System;

int somatorio = 0;
for (int numero = 1; numero <= 100; numero++)
{
    Console.WriteLine(numero);
    somatorio += numero;
}
Console.WriteLine($"O somatório dos números de 1 a 100 é: {somatorio}");