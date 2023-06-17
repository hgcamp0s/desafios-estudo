/*
    Faça um programa que leia um valor de hora e informe quantos minutos se passaram desde o inicio do dia.
*/

using System;

Console.WriteLine("Digite um valor de hora(0 a 23):");
int hora = int.Parse(Console.ReadLine());

DateTime inicioDoDia = DateTime.Today; // Obtém a data atual, representando o inicio do dia
DateTime horaInformada = inicioDoDia.AddHours(hora); // Adiciona a quantidade de horas fornecida pelo usuário usando o método 'Addhours(hora)' para criar um novo objeto 'DateTime' chamado 'horaInformada'.

TimeSpan diferenca = horaInformada - inicioDoDia; // 'TimeSpan' representa o intervalo de tempo, que calculos a diferença da 'horaInformada' e o 'iniciDoDia'
int minutos = (int)diferenca.TotalMinutes; // Aqui obtemos a quantidade total de minutos dessa diferença usando a propriedade 'TotalMinutes' e a convertemos para um valor inteiro

Console.WriteLine($"Já se passaram {minutos} minutos desde o inicio do dia.");