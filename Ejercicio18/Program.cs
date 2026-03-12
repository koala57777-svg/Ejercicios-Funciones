int cantidadProductos;

string TotalFactura(int a)
{
    double sumatotal = 0;
    double precioproducto = 0;
    for (int i = 1; i <= a; i++)
    {
        Console.Write($"Ingrese el precio del producto {i} (Q):");
        precioproducto = double.Parse(Console.ReadLine());
        Console.WriteLine();
        if (precioproducto > 0)
        {
            sumatotal += precioproducto;
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Dato inválido. Por favor ingrese datos válidos");
            i = i - 1;
            Console.WriteLine();
        }
    }
    return $"El total de la factura es de: Q{sumatotal}";
}

Console.Write("Cantidad de productos que desea ingresar precio: ");
cantidadProductos=int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(TotalFactura(cantidadProductos));

