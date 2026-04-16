internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**** BUZÓN DE VOZ ****");
        Console.WriteLine("1- Ver Mensajes\n2- Configuración\n3- Operador\n4- Salir");
        int opc = Convert.ToInt32(Console.ReadLine());
        string msj = "";

        switch (opc)
        {
            case 1: msj = "Entrando a: BANDEJA DE ENTRADA"; break;
            case 2: msj = "Entrando a: CONFIGURACIÓN"; break;
            case 3: msj = "Llamando a: OPERADOR"; break;
            case 4: msj = "Saliendo..."; break;
            default: msj = "Opción no válida"; break;
        }
}