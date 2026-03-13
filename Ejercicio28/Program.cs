void PromedioEstudiante()
{
    double sumacalificaciones = 0;
    double calificacion;

    for(int i=1; i<=3; i++)
    {
        Console.Write($"Ingrese la nota número {i}: ");
        calificacion=double.Parse( Console.ReadLine() );
        Console.WriteLine();
        if (calificacion>=0 && calificacion <= 100)
        {
            sumacalificaciones += calificacion;
        }
        else
        {
            Console.WriteLine($"Calificación inválida. Vuelva a ingresar la calificación número {i}");
            Console.WriteLine();
            i = i - 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"El promedio de las tres calificaciones del estudiante: {sumacalificaciones / 3}");
}

PromedioEstudiante();