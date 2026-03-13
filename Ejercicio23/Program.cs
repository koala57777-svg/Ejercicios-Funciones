void SumaDosNumeros()
{
    Console.Write("Ingrese el primer número: ");
    double numerouno=double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Ingrese el segundo número: ");
    double numerodos = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"La suma de los dos números es: {numerouno+numerodos}");
}

SumaDosNumeros();