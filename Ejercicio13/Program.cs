int cantidadproductos;

double productoingresado;

string TotalCompra(int cantidadproductos)
{
    double sumatotal = 0;
    for (int i=1; i<=cantidadproductos; i++)
    {
        Console.Write($"Ingrese el precio del producto {i} (Q): ");
        productoingresado=double.Parse(Console.ReadLine());
        Console.WriteLine();
        if (productoingresado > 0)
        {
            sumatotal += productoingresado;
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Dato invalido. Por favor ingrese datos válidos"); ;
            i = i - 1;
            Console.WriteLine();
        }
    }
    return $"La suma total es de: Q{sumatotal}";
}

Console.Write("Cantidad de productos que desea ingresar: ");
cantidadproductos=int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(TotalCompra(cantidadproductos));
