double a, b;
double PrecioFinal(double a, double b)
{
    double descuento = a * (b / 100);
    return a - descuento;
}

Console.WriteLine("Ingrese el precio del producto: ");
Console.WriteLine();
a=double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ingrese el porcentaje de descuento del producto: ");
Console.WriteLine();
b=double.Parse(Console.ReadLine());
Console.WriteLine();
if (a < 0 || b < 0)
{
    Console.WriteLine("Datos inválidos. Por favor ingrese valores positivos.");
}
else
{
    Console.WriteLine($"El precio final del producto es de: {PrecioFinal(a,b)}");
}