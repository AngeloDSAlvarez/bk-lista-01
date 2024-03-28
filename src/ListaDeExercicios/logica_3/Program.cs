// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a quilometragem inicial: ");
double kmInicial = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a quilometragem final: ");
double kmFinal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite quantos litros consumidos: ");
double litros = Convert.ToDouble(Console.ReadLine());


double consumo = (kmFinal - kmInicial) / litros;

Console.WriteLine("O consumo foi: " + consumo + " l/km");