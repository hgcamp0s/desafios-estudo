/*
    Faça um programa que leia um valor de conta de restaurante, representando o gasto realizado;
    pelo cliente e imprima o valor total a ser pago, considerando que o restaurante cobra 10% para o garçom.
*/

using System;

Console.WriteLine("Informe o valor gasto pelo cliente:");
string valor = Console.ReadLine();

while(!string.IsNullOrEmpty(valor)) // Verifica se o usuário digitou um caracter
{
    if(double.TryParse(valor, out double gasto)) // E se esse valor é possível converter para um tipo double
    {
        double valorFinal = gasto * 1.10;
        Console.WriteLine($"O gasto total do cliente considerando os 10% do garçom é de: {valorFinal}");
        break;
    }
    Console.WriteLine("Informe um valor válido:"); // Se não, o programa fica repetindo até que seja informado um valor válido
    valor = Console.ReadLine();
}