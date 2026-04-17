internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba el número del mes (1-12):");
        int mes = Convert.ToInt32(Console.ReadLine());
        string msj = "";

        switch (mes)
        {
            case 1: msj = "Enero"; break;
            case 2: msj = "Febrero"; break;
            case 3: msj = "Marzo"; break;
            case 4: msj = "Abril"; break;
            case 5: msj = "Mayo"; break;
            case 6: msj = "Junio"; break;
            case 7: msj = "Julio"; break;
            case 8: msj = "Agosto"; break;
            case 9: msj = "Septiembre"; break;
            case 10: msj = "Octubre"; break;
            case 11: msj = "Noviembre"; break;
            case 12: msj = "Diciembre"; break;
                default: msj = "Mes inválido"; break;
                }

        Console.WriteLine("El mes es: " + msj);
    }
}