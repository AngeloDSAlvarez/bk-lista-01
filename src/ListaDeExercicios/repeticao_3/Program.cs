
Console.WriteLine("Digite um numero: ");
int num = Convert.ToInt32(Console.ReadLine());

int fib = 0;
int fibPost = 1;

while (num > fib)
{
    Console.WriteLine(fib);

    int temp = fibPost;
    fibPost += fib;
    fib = temp;

}
