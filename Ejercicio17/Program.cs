int cantidadEstudiantes;
string PromedioGrupal(int cantidadEstudiantes)
{
    double suma = 0;
    double notaIngresasda = 0;

    for (int i=1; i<=cantidadEstudiantes; i++)
    {
        Console.Write($"Ingrese la nota del estudiante {i}: ");
        notaIngresasda=double.Parse( Console.ReadLine() );
        Console.WriteLine();
        if (notaIngresasda > 0 && notaIngresasda <= 100)
        {
            suma += notaIngresasda;
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Nota ingresada no válida. Por favor ingreses datos válidos.");
            i = i - 1;
            Console.WriteLine();
        }
    }
    return $"El promedio grupal es de: {suma/cantidadEstudiantes}";
}

Console.Write("Cantidad de estudiantes que desea ingresar: ");
cantidadEstudiantes = int.Parse(Console.ReadLine());
Console.WriteLine(PromedioGrupal(cantidadEstudiantes));
