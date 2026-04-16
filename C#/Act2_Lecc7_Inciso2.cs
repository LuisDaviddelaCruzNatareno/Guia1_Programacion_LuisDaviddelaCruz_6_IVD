internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la calificación (0-100):");
        double nota = Convert.ToDouble(Console.ReadLine());
        string msj = "";

        if (nota >= 95) msj = "Rango: EXCELENTE";
        else if (nota >= 85) msj = "Rango: MUY BIEN";
        else if (nota >= 75) msj = "Rango: BIEN";
        else if (nota >= 60) msj = "Rango: REGULAR";
        else msj = "Rango: DEFICIENTE";

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(msj);
    }
}