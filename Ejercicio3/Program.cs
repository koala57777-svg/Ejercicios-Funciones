double a;
double Doble(double a)
{
    return a * 2;
}

Console.WriteLine("Ingrese un número: ");
Console.WriteLine();
a=int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"El doble del número es: {Doble(a)}");