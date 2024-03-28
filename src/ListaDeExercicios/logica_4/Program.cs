// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o salario base: ");
double salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a quantidade de vendas total: ");
double vendasTotal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a comissao, apenas o numero: ");
double comissao = Convert.ToDouble(Console.ReadLine());

double salarioFinal = salario + (vendasTotal * (comissao / 100));

Console.WriteLine("Salario total: R$ " + salarioFinal);