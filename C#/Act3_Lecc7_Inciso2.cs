internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los 3 ángulos del triángulo:");
        double a1 = Convert.ToDouble(Console.ReadLine());
        double a2 = Convert.ToDouble(Console.ReadLine());
        double a3 = Convert.ToDouble(Console.ReadLine());
        string msj = "";

        if (a1 == 60 && a2 == 60 && a3 == 60) msj = "EQUILÁTERO";
        else if (a1 == a2 || a2 == a3 || a1 == a3) msj = "ISÓSCELES";
        else msj = "ESCALENO";

        Console.WriteLine("\nEl triángulo es: " + msj);
    }
}