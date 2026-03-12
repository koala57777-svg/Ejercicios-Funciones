double a, b;
double AreaRectangulo(double a, double b)
{
    return a * b;
}

Console.WriteLine("Ingrese la altura del rectángulo: ");
Console.WriteLine();
a=double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ingrese la base del rectángulo: ");
Console.WriteLine();
b=double.Parse(Console.ReadLine());
Console.WriteLine();
if (a<0 || b<0)
{
    Console.WriteLine("Datos inválidos. Por favor ingrese valores positivos.");
}
else
{
    Console.WriteLine($"El área del rectangulo es de: {AreaRectangulo(a,b)} unidades cuadradas.");
}