double a;
double GradosFahrenheit(double a)
{
    return (a * 9 / 5) + 32;
}

Console.WriteLine("Ingrese los grados (Celsius): ");
Console.WriteLine();
a=double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"{a} grados Celsius son: {GradosFahrenheit(a)} grados Fahrenheit.");