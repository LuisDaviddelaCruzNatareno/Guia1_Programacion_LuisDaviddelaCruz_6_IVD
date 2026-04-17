internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--- CONTACTOS EMPRESA ---");
        Console.WriteLine("1. Ventas\n2. Recepción\n3. Dirección\n4. Compras");
        Console.Write("Elija un número: ");
        int opc = Convert.ToInt32(Console.ReadLine());
        string msj = "";

        switch (opc)
        {
            case 1: msj = "DEPARTAMENTO: VENTAS\nResponsable: Ana Martinez\nCorreo: ana@empresa.com"; break;
            case 2: msj = "DEPARTAMENTO: RECEPCIÓN\nResponsable: Luis Perez\nCorreo: luis@empresa.com"; break;
            case 3: msj = "DEPARTAMENTO: DIRECCIÓN\nResponsable: Elena Gomez\nCorreo: elena@empresa.com"; break;
            case 4: msj = "DEPARTAMENTO: COMPRAS\nResponsable: Pedro Armas\nCorreo: pedro@empresa.com"; break;
            default: msj = "Departamento no válido."; break;
        }

        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(msj);
        Console.ResetColor();
    }
}