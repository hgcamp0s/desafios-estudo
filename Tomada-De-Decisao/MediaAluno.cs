/*
    Faça um programa que leia três notas de um aluno, calcule sua média aritmética e imprima
    uma mensagem dizendo se o aluno foi aprovado, reprovado ou deverá fazer prova final
    aprovado (media >= 7)
    reprovado (media < 3)
    prova final (3 < media)
*/

using System;

double[] notas = new double[3];

Console.WriteLine("Digite a nota da AV1:");
notas[0] = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota da AV2:");
notas[1] = double.Parse(Console.ReadLine());

Console.WriteLine("Digite oa nota da AV3:");
notas[2] = double.Parse(Console.ReadLine());


if (notas[2] > notas[0] || notas[2] > notas[1]) // Verifica se a nota da AV3 é maior do que a nota da AV1 ou da AV2
{                                               // Se sim, signifca que a nota da AV3 substituirá uma das notas anteriores para o cálculo da média
    if (notas[0] <= notas[1]) // Verifica qual das duas notas(AV1 ou AV2) é menor
    {                         // Se a nota da AV1 for menor ou igual a nota da AV2
        notas[0] = notas[2];  // Significa que a nota da AV1 será substituída pela nota da AV3
    }
    else // Caso contrário, se a nota da AV2 for menor do que a nota da AV1
    {
        notas[1] = notas[2]; // Significa que a nota da AV2 será substituída pela nota da AV3
    }
}

double media = (notas[0] + notas[1] + notas[2]) / 3;

Console.WriteLine($"Média das notas: {media}");

if (media >= 7)
{
    Console.WriteLine("Aluno aprovado!");
}
else if (media < 3)
{
    Console.WriteLine("Aluno reprovado!");
}
else
{
    Console.WriteLine("Prova final!");
}