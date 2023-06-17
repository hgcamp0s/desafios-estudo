/*
    Faça um programa que imprima a soma dos números pares entre 25 e 100.
*/

using System;

int somatorio = 0;
for (int numero = 25; numero <= 100; numero++)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
        somatorio += numero;
    }
}
Console.WriteLine($"O somatório dos números pares entre 25 e 100 é: {somatorio}");