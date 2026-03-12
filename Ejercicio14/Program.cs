double distancia, tiempo;

double CalcularVelocidad(double a, double b)
{
    return a / b;
}

Console.Write("Ingrese la distancia recorrida (m): ");
distancia=double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Ingrese el tiempo empleado (s): ");
tiempo = double.Parse(Console.ReadLine());
Console.WriteLine();
if (distancia<0 || tiempo <= 0)
{
    Console.WriteLine("Datos inválidos. Por favor ingrese datos válidos.");
}
else
{
    Console.WriteLine($"La velocidad promedio es de: {CalcularVelocidad(distancia,tiempo)} m/s");
}