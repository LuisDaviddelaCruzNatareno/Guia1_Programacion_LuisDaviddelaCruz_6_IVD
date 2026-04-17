internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese día (1-7): ");
        int dia = Convert.ToInt32(Console.ReadLine());
        string msj = "";

        switch (dia)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                msj = "ENTRE SEMANA"; break;
            case 6:
            case 7:
                msj = "FIN DE SEMANA"; break;
            default:
                msj = "DÍA NO EXISTE"; break;
        }
    }
}