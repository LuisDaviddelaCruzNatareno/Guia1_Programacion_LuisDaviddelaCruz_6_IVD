internal class Program
{
    private static void Main(string[] args)
    {
        int num = 0;
        Console.WriteLine("INtroduzca un número:");
        num = int.Parse(Console.ReadLine());
        if(num<0)
        {
            Console.WriteLine("El número es menor a cero");
        }
        else
        {
            Console.WriteLine("El número es igual o menor a cero");
        }
    }
}