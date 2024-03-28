
Console.WriteLine("Digite a altura em metros: ");
double altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o peso em kilos: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("IMC: " + (peso / (altura * altura)) * 10000);

