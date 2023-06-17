/*
    Faça um programa que leia um número da entrada(n) e imprima a soma dos números pares entre 1 e (x).
    Suponha que num será maior que zero.
*/

using System;

Console.WriteLine("Digite um número:");
int n = int.Parse(Console.ReadLine());

int somatorio = 0;

if (n > 0)
{
    for (int numero = 1; numero <= n; numero++)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine(numero);
            somatorio += numero;
        }
    }
    Console.WriteLine($"Soma dos números pares entre 1 e X: {somatorio}");
}
else 
{
    Console.WriteLine("Digite um número maior que zero.");
}