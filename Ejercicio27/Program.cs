void DescuentoProducto()
{
    Console.Write("Ingrese el precio del producto (Q): ");
    double precioProducto=double.Parse(Console.ReadLine());
    Console.WriteLine();
    if (precioProducto > 0)
    {
        double descuento = precioProducto * 0.1;
        Console.WriteLine($"El precio del producto con descuento es: Q{precioProducto-descuento}");
    }
    else
    {
        Console.WriteLine("Valor inválido. Por favor ingrese un valor válido.");
        Console.WriteLine();
        DescuentoProducto();
    }
}

DescuentoProducto();