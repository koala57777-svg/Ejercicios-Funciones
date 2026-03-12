double a, b;

double SalarioTotal(double a, double b)
{
    return a*b;
}

Console.WriteLine("Ingrese el salario por hora (Q): ");
Console.WriteLine();
a=double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ingrese las horas trabajadas: ");
Console.WriteLine();
b = double.Parse(Console.ReadLine());
Console.WriteLine();
if (a<0 || b < 0)
{
    Console.WriteLine("Datos inválidos. Por favor ingrese datos positivos.");
}
else
{
    Console.WriteLine($"El salario total es de: Q{SalarioTotal(a,b)}");
}