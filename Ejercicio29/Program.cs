void CantidadEstudiantesCurso()
{
    Console.Write("Ingrese la cantidad de estudiante que hay en el curso: ");
    int cantidadEstudiante=int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (cantidadEstudiante >= 0)
    {
        Console.WriteLine($"La cantidad de estudiante que hay en la clase es: {cantidadEstudiante} estudiante/s");
    }
    else
    {
        Console.WriteLine("Cantidad inválida. Por favor ingrese una cantidad válida");
        Console.WriteLine();
        CantidadEstudiantesCurso();
    }
}
Console.WriteLine();
CantidadEstudiantesCurso();