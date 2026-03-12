using System.Net.WebSockets;

double a;
double Cuadrado(double a)
{
    return a * a;
}

Console.WriteLine("Ingrese un número: ");
Console.WriteLine();
a= double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"El cuadrado del número es: {Cuadrado(a)}");