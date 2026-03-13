void AreaRectangulo()
{
    Console.Write("Ingrese la base del rectángulo: ");
    double baseRectangulo=double.Parse(Console.ReadLine());
    Console.WriteLine();
    if (baseRectangulo > 0)
    {
        Console.Write("Ingrese la base del rectángulo: ");
        double alturaRectangulo = double.Parse(Console.ReadLine());
        Console.WriteLine();
        if (alturaRectangulo > 0)
        {
            Console.WriteLine($"El área del rectángulo es: {baseRectangulo*alturaRectangulo} unidades cuadradas");
        }
        else
        {
            Console.WriteLine("Dato inválido. Ingrese dato válido");
            Console.WriteLine();
            AreaRectangulo();
        }
    }
    else
    {
        Console.WriteLine("Dato inválido. Ingrese dato válido");
        Console.WriteLine();
        AreaRectangulo();
    }
}

AreaRectangulo();  