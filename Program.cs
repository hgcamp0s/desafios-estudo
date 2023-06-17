/*
    
*/

using System;

Console.WriteLine("Digite o início:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o fim:");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Valor do múltiplo:");
int n = int.Parse(Console.ReadLine());

if (x < y)
{
    for (int z = x; z <= y; z++)
    {
        if (z % 5 == 0)
        {
            Console.WriteLine($"{z}");
        }
    }
}
else
{
    Console.WriteLine("O inicio deverá ser maior que o fim.");
}