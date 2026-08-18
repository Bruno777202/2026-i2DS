internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> filascaixa = new Queue<string>();

        filascaixa.Enqueue("ourinhos");         //0
        filascaixa.Enqueue("enderlote");        //1
        filascaixa.Enqueue("watervaldo");       //2
        filascaixa.Enqueue("signosbololos");    //3
        filascaixa.Enqueue("jorgeclado");       //4

        string pessoafila = filascaixa.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"Pessoa: {pessoafila}");

        
        foreach(var pessoa in filascaixa)
        {
            Console.WriteLine(pessoa);
        }



    }
}