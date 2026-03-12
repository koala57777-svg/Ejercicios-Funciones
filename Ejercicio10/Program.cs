double a;

double CuboNumero(double a)
{
    return a * a * a;
}

Console.WriteLine("Ingrese un número: ");
Console.WriteLine();
a=double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"El cubo del número es: {CuboNumero(a)}");