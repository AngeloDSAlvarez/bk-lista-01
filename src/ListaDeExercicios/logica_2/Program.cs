
Console.WriteLine("Digite os graus em Fahrenheit: ");
double fahrenheit = Convert.ToDouble(Console.ReadLine());

double celsius = (fahrenheit - 32) * 5/9;

Console.WriteLine("Temperatura em Celsius: " + celsius);