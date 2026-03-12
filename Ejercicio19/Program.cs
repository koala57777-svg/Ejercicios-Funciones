double calificacion;
string Nombreestudiante;
string PromedioEstudiante(string a)
{
    double sumacalficaciones = 0;

    for (int i=1; i<=3; i++)
    {
        Console.Write($"Ingrese la nota {i} del estudiante {Nombreestudiante}: ");
        calificacion=double.Parse( Console.ReadLine() );
        Console.WriteLine();
        if ( calificacion>=0 && calificacion <= 100)
        {
            sumacalficaciones += calificacion;
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Dato inválido. Por favor ingrese datos válidos");
            i = i - 1;
            Console.WriteLine();
        }
    }
    return $"El promedio de las calificaciones del estudiante {Nombreestudiante} es: {sumacalficaciones/3}";
}

Console.Write("Ingrese el nombre del estudiante: ");
Nombreestudiante= Console.ReadLine();
Console.WriteLine();
Console.WriteLine(PromedioEstudiante(Nombreestudiante));