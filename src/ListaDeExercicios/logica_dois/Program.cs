
Console.WriteLine("Digite os 3 valores: ");
int v1 = Convert.ToInt16(Console.ReadLine());
int v2 = Convert.ToInt16(Console.ReadLine());
int v3 = Convert.ToInt16(Console.ReadLine());

if (v1 > v2 && v2 > v3)
{
    Console.WriteLine("Ordem decrescente: " + v1 + " " + v2 + " " + v3);
} else if (v1 > v2 && v3 > v2)
{
    Console.WriteLine("Ordem decrescente: " + v1 + " " + v3 + " " + v2);
} else if (v2 > v1 && v1 > v3)
{
    Console.WriteLine("Ordem decrescente: " + v2 + " " + v1 + " " + v3);
} else if (v2 > v1 && v3 > v1)
{
    Console.WriteLine("Ordem decrescente: " + v2 + " " + v3 + " " + v1);
} else if (v3 > v2 && v2 > v1)
{
    Console.WriteLine("Ordem decrescente: " + v3 + " " + v2 + " " + v1);
} else if (v3 > v2 && v1 > v2)
{
    Console.WriteLine("Ordem decrescente: " + v3 + " " + v1 + " " + v2);
}