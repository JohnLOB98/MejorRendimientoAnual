// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double fondoSemanal     = 1031.84;
double rendimiento      = 0.000375;
double mejorRendimiento = 0; 
int    mejorSemana      = 0;


for (int week = 1; week <= 51; week++)
{
    int    diasFaltantes = 7 * (52 - week);
    double cantidadInicial, cantidad;

    cantidadInicial = cantidad = fondoSemanal * week;

    while(--diasFaltantes > 0)
        cantidad += cantidad * rendimiento;

    double generadoRendimientos = cantidad - cantidadInicial;

    Console.WriteLine($"WEEK {week} --- ${generadoRendimientos.ToString(".00")}");
    if (generadoRendimientos > mejorRendimiento)
    {
        mejorRendimiento = generadoRendimientos;
        mejorSemana      = week; 
    }

}

Console.WriteLine($"Para obtener mejor rendimeinto sacar el dinero en la SEMANA {mejorSemana}");
