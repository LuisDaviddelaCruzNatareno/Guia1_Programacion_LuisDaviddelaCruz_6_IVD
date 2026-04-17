internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el día: ");
        int dia = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el mes (1-12): ");
        int mes = Convert.ToInt32(Console.ReadLine());
        string msj = "";

        if ((mes == 3 && dia >= 21) || mes == 4 || mes == 5 || (mes == 6 && dia <= 20)) msj = "PRIMAVERA";
        else if ((mes == 6 && dia >= 21) || mes == 7 || mes == 8 || (mes == 9 && dia <= 20)) msj = "VERANO";
        else if ((mes == 9 && dia >= 21) || mes == 10 || mes == 11 || (mes == 12 && dia <= 20)) msj = "OTOÑO";
        else msj = "INVIERNO";

        Console.WriteLine("\nLa estación según la fecha es: " + msj);
    }
}