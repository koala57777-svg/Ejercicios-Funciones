void YearNacimientoAproximado()
{
    Console.Write("Ingrese su edad: ");
    int edad=int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (edad >= 0)
    {
        Console.WriteLine($"Su año de nacimiento aproximado es: {2026-edad}");
    }
    else
    {
        Console.WriteLine("Edad inválida. Por favor ingrese una edad válida");
        Console.WriteLine();
        YearNacimientoAproximado();
    }
}

YearNacimientoAproximado();