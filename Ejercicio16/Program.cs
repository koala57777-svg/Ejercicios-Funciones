double minutos;

string ConvertirMinutos(double a)
{
    return $"El equivalente de {a} minutos es: {a/60} horas";
}

Console.Write("Ingrese la cantidad de minutos: ");
minutos=double.Parse(Console.ReadLine());
Console.WriteLine();
if (minutos < 0)
{
    Console.WriteLine("Dato inválidos. Por favor ingrese datos positivos");
}
else
{
    Console.WriteLine(ConvertirMinutos(minutos));
}
