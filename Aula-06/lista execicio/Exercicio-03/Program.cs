internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> Cardapio = new Dictionary<int, string>();

        Cardapio.Add(1,"hanburgue");
        Cardapio.Add(2,"espaguete");
        Cardapio.Add(3,"fritas");
        Cardapio.Add(4,"lanche de pernil");

        Console.WriteLine("Cardápio");

        foreach(var produto in Cardapio)
        {
            Console.WriteLine($"Codigo: {produto.Key} - Produto: {produto.Value}");
        }
        




    }
}