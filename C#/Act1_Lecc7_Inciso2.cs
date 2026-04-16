internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su edad:");
        double edad = Convert.ToDouble(Console.ReadLine());
        string msj = "";

        if (edad >= 18)
        {
            msj = "ESTADO: Mayor de edad";
        }
        else
        {
            msj = "ESTADO: Menor de edad";
        }

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(msj);
    }
}
