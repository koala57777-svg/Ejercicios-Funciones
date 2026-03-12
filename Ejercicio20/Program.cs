int diasTrabajados=1;
double pagoDiario=1;

string SalarioTotal(int a, double b)
{
    return $"El salario total del trabajador es: Q{a * b}";
}

do
{
    Console.Write("Ingrese el pago diario (Q): ");
    pagoDiario = double.Parse(Console.ReadLine());
    Console.WriteLine();
    if (pagoDiario > 0)
    {
        Console.Write("Ingrese los días trabajados: ");
        diasTrabajados = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (diasTrabajados > 0)
        {
            Console.WriteLine(SalarioTotal(diasTrabajados, pagoDiario));
            break;
        }
        else
        {
            Console.WriteLine("Dato inválido. Por favor ingrese un dato válido. ");
            Console.WriteLine();
            diasTrabajados = 1;
            
        }
    }
    else
    {
        Console.Write("Dato inválido. Por favor ingrese un dato válido. ");
        Console.WriteLine();
        pagoDiario = 1;
        
    }
    Console.WriteLine();
 
} while (pagoDiario > 0 || diasTrabajados > 0);
