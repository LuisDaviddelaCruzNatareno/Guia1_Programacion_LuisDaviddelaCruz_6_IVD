internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese 5 calificaciones:");
        double n1 = Convert.ToDouble(Console.ReadLine());
        double n2 = Convert.ToDouble(Console.ReadLine());
        double n3 = Convert.ToDouble(Console.ReadLine());
        double n4 = Convert.ToDouble(Console.ReadLine());
        double n5 = Convert.ToDouble(Console.ReadLine());

        string msj = "";
        double result = (n1 + n2 + n3 + n4 + n5) / 5;

        if (result >= 60)
        {
            msj = "EL ESTUDIANTE APRUEBA\nPromedio final:";
        }
        else
        {
            msj = "EL ESTUDIANTE REPRUEBA\nPromedio final:";
        }

        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(msj);
        Console.WriteLine(result);
    }
}