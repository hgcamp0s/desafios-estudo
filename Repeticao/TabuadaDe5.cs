/*
    Faça um programa que imprima a tabuada de 5 no formato base
*/

using System;

int x = 5;

for (int count = 1; count <= 10; count++)
{
    int result =  x;
    result =  result * count;
    Console.WriteLine($"{x} x {count} = {result}");
}