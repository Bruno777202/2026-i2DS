internal class Program
{
    private static void Main(string[] args)
    {
        int celsius;
        Console.Write("Digite a temperatura um Graus celsius");
       celsius = int.Parse(Console.ReadLine());

       double fehrenheit = (celsius = 9 / 5) + 32;

       Console.WriteLine("A temperatura em fahrenheit é; " + fehrenheit);




    }
}