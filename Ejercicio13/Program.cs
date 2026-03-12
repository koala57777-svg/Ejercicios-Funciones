int cantidadproductos;

double productoingresado;

double TotalCompra(int cantidadproductos)
{
    double sumatotal = 0;
    for (int i=1; i<=cantidadproductos; i++)
    {
        Console.Write($"Ingrese el precio del producto {i} (Q): ");
        productoingresado=double.Parse(Console.ReadLine());
        sumatotal += productoingresado;
        Console.WriteLine();
    }
    return sumatotal;
}

Console.Write("Cantidad de productos que desea ingresar: ");
cantidadproductos=int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine();
double resultado=TotalCompra(cantidadproductos);
Console.WriteLine();
Console.WriteLine($"El total de las compras es: Q{resultado}");
Console.WriteLine();