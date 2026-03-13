void AreaCirculo()
{
    Console.Write("Ingrese el radio del círculo: ");
    double radiocirculo=double.Parse(Console.ReadLine());
    Console.WriteLine();
    if (radiocirculo >= 0)
    {
        Console.WriteLine($"El área del círculo es: {Math.PI * radiocirculo * radiocirculo} unidades cuadradas");
    }
    else
    {
        Console.WriteLine("Ingrese datos váidos. No existen longitudes negativas.");
        Console.WriteLine();
        AreaCirculo();
    }
}

AreaCirculo();