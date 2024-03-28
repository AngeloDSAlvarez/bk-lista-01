// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um numero: ");
double input = Convert.ToDouble(Console.ReadLine());

double num = input;
for (int i = Convert.ToInt16(num) - 1; i > 0; i--)
{
    num = num * i;
}

Console.WriteLine(input + "! = " + num);