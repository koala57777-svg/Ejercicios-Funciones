double a, b, c;

double Promedio(double a, double b, double c)
{
    return (a + b + c) / 3;
}

Console.WriteLine("Ingrese el primer número: ");
Console.WriteLine();
a=double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ingrese el segundo número: ");
Console.WriteLine();
b = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ingrese el tercer número: ");
Console.WriteLine();
c = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"El promedioo de los número es: {Promedio(a,b,c)}");