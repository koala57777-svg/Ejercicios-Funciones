using System.Net.WebSockets;

double a, b;
double Suma(double a, double b)
{
    return a + b;
}

Console.WriteLine("Ingrese el primer número: ");
Console.WriteLine();
a=double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ingrese el segundo número: ");
Console.WriteLine();
b=double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"La suma de los números es: {Suma(a,b)}");