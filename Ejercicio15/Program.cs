double baseTriangulo, alturaTriangulo;

double AreaTriangulo(double a, double b)
{
    return ((0.5) * (a * b));
}

Console.Write("Ingrese la base del triángulo: ");
baseTriangulo=double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Ingrese la altura del triángulo: ");
alturaTriangulo = double.Parse(Console.ReadLine());
Console.WriteLine();
if (baseTriangulo<0 || alturaTriangulo < 0)
{
    Console.WriteLine("Datos inválidos. Por favor ingresar datos válidos.");
}
else
{
    Console.WriteLine($"El área del triángulo es de: {AreaTriangulo(baseTriangulo, alturaTriangulo)} unidades cuadradas");
}