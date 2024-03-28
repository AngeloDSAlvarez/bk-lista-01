// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite a nota da primeira prova: ");
double provaUm = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o peso da primeira prova: ");
double pesoUm = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a nota da segunda prova: ");
double provaDois = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o peso da segunda prova: ");
double pesoDois = Convert.ToDouble(Console.ReadLine());

double media = ((provaUm * pesoUm) + (provaDois * pesoDois)) / 10;

Console.WriteLine("Media ponderada do aluno: " +  media);