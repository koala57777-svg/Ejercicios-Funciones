double a;
double RadioCirculo(double a)
{
    return Math.PI * (a * a);

}

Console.WriteLine("Ingrse el radio del círculo: ");
Console.WriteLine();
a=double.Parse(Console.ReadLine());
Console.WriteLine();
if (a < 0)
{
    Console.WriteLine("Dato inválido. Ingrese un valor positivo.");
}
else
{
    Console.WriteLine($"El radio del círculo es de: {RadioCirculo(a)} unidades cuadradas.");
}