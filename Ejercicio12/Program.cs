int edad;

string MostrarEdad(int edad)
{
    return $"La edad ingresada es: {edad} años";
}

Console.Write("Ingresa tu edad: ");
edad=int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(MostrarEdad(edad));