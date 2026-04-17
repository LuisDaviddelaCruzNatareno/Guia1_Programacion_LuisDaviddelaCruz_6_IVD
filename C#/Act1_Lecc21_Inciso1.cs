internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**** CONSULTA DE DÍAS ****");
        Console.Write("Digite un número del 1 al 7: ");
        int opc = Convert.ToInt32(Console.ReadLine());

        string msj = "";

        switch (opc)
        {
            case 1:
                msj = "Hoy es: LUNES";
                break;
            case 2:
                msj = "Hoy es: MARTES";
                break;
            case 3:
                msj = "Hoy es: MIÉRCOLES";
                break;
            case 4:
                msj = "Hoy es: JUEVES";
                break;
            case 5:
                msj = "Hoy es: VIERNES";
                break;
            case 6:
                msj = "Hoy es: SÁBADO";
                break;
            case 7:
                msj = "Hoy es: DOMINGO";
                break;
            default:
                msj = "ERROR: Seleccione una opción válida (1-7)";
                break;
        }
    }
}