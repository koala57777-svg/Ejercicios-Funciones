void ReporteEstudiante()
{
    Console.Write("Ingrese el nombre del estudiante: ");
    string NombreEstudiante = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Ingrese el curso del estudiante: ");
    string CursoEstudiante= Console.ReadLine();
    Console.WriteLine();

    double sumacalificaciones = 0;
    double calificacion;

    for(int i=1; i<=3; i++)
    {
        Console.Write($"Ingrese la calificación número {i}: ");
        calificacion=double.Parse( Console.ReadLine() );
        Console.WriteLine();
        if (calificacion>=0 && calificacion <= 100)
        {
            sumacalificaciones += calificacion;
        }
        else
        {
            Console.WriteLine($"Calificación inválida. Vuelva a ingresa la calificación número {i}");
            i = i - 1;
            Console.WriteLine();
        }
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("     Reporte de estudiante");
    Console.WriteLine("---------------------------------");
    Console.WriteLine();
    Console.WriteLine($"Nombre del estudiante: {NombreEstudiante}");
    Console.WriteLine();
    Console.WriteLine($"Curso del estudiante: {CursoEstudiante}");
    Console.WriteLine();
    Console.WriteLine($"Promedio de las tres calificaciones: {sumacalificaciones/3}");
}

ReporteEstudiante();