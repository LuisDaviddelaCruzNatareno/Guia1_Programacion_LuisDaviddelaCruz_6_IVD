internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese Contraseña: ");
        string clave = Console.ReadLine();
        string msj = "";

        if (clave == "Password123")
        {
            msj = "¡BIENVENIDA!";
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            msj = "INGRESO PROHIBIDO";
            Console.ForegroundColor = ConsoleColor.Red;
        }

        Console.WriteLine("\n" + msj);
        Console.ResetColor();
    }
}