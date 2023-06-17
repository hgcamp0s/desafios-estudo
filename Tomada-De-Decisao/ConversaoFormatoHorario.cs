/*
    Faça um programa que leia um horário no sistema de 24 horas
    e imprima este horário no sistema de 12 horas.
    Exemplos: 23:32 -> 12:32 pm
               0:00 -> 12:00 am
               6:00 ->  6:00 am
              12:00 -> 12:00 pm
*/

using System;
using System.Globalization;

Console.WriteLine("Digite o horário no formato de 24 horas (H:mm):"); // Solicita o usuário um horário no fomrato de 24 horas
string horario24h = Console.ReadLine();

DateTime horario;
// Essas linhas tentam converter o valor de 'horario24h' para o formato 'DateTime' usando o método 'TryParseExact()'
// Este método tenta analisar uma string em um objeto 'DateTime' usando o formato especificado
// O formato fornecido para 'TryParseExact()' é "H:mm", onde "H" representa a hora no formato 24horas sem zero à esquerda, e "mm" representa os minutos
// O parâmetro 'CultureInfo.InvariantCulture' é usado para garantir que o formato seja interpretado independentemente da cultura do sistema operacional.
// o parâmetro 'DatimeStyles.None' é usado para definir o estilo de análise como nenhum estilo específico.
// Se a conversão for bem-sucedida, o horário fornecido estiver no formato esperado, nosso 'if' será executado
if (DateTime.TryParseExact(horario24h, "H:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out horario))
{
    // Converte o objeto 'DaTime' 'horario' para uma string no fomrato de 12horas("hh:mm tt")
    // O "hh" representa a hora com dois digitos, "mm" representa os minutos e "tt" representa o designador AM/PM
    string horario12h = horario.ToString("hh:mm tt", CultureInfo.InvariantCulture);
    Console.WriteLine($"Horário no formato de 12 horas: {horario12h}");
}
else
{
    Console.WriteLine("Horário inválido.");
}