/*
    Faça um programa que imprima os números de 1 a 100.
*/

using System;


int[] numero = new int[100];

for (int count = 0; count<numero.Length; count++)
{
    int result = count + 1;
    Console.WriteLine($"{result}");
}