/*
    Faça um programa que leia a idade de uma pessoa e informa sua classe eleitoral
    Não eleitor (abaixo de 16 anos)
    Eleitor obrigatório (entre 18 e 65 anos)
    Eleitor facultativo (entre 16 e 18 e acima dos 65 anos)
*/

using System;

Console.WriteLine("Entre com a idade do eleitor:");
int idade = int.Parse(Console.ReadLine());

if (idade < 16)
{
    Console.WriteLine("Não eleitor.");
}
else if (idade >= 18 && idade <= 65)
{
    Console.WriteLine("Eleitor obrigatório.");
}
else if ((idade >= 16 && idade < 18) || idade > 65)
{
    Console.WriteLine("Eleitor facultativo.");
}