
Console.WriteLine("Digite o tamanho A");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o tamanho B");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o tamanho C");
double c = Convert.ToDouble(Console.ReadLine());

if (a + b > c)
{
    Console.WriteLine("A + B é maior que C");
} else
{
    Console.WriteLine("A + B é menor que C");
}