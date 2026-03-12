double a;

double PesoLibras(double a)
{
    return (a*2.2);
}

Console.WriteLine("Ingrese el peso (Kg): ");
Console.WriteLine();
a=double.Parse(Console.ReadLine());
Console.WriteLine();
if (a < 0)
{
    Console.WriteLine("Dato inválido. Por favor ingresar datos positivos.");
}
else
{
    Console.WriteLine($"{a} kg son: {PesoLibras(a)} lb");
}