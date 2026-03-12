void SaludoPersonalizado()
{
    Console.Write("Ingrese su nombre: ");
    string Nombre= Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine($"Hola {Nombre}, ¡Espero que tengas un buen día!");
}

SaludoPersonalizado();