internal class Program
{

    
    private static void Main(string[] args)
    {
        // 1 -  sintaxe Dictinary <chave, valor>
        Dictionary<string, string> dicionario = new Dictionary<string, string>();

        // 2-  Adiciona elementos no dicionario
        dicionario.Add("Hamburgue", "lanche feito tradicionamente de pão e carne");
        dicionario.Add("Fernando", "Professor do senai de jau");
        dicionario.Add("Escola,", "Local frenquetado por alunos sen");

        // 3 = Percorrer todos os elmentos de um dicionario
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 4 - Alterar um elemento do dicionario
        dicionario["Hamburgue"] = "Professor do senai de jau";
         Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 5 - pesquisar uma chave (Key) existe dentro do dicionario
        string termo; 
        bool chaveExiste = dicionario.TryGetValue("Escola", out termo);
        if (chaveExiste)
        {
            Console.WriteLine($"A palavra foi encontrada: {termo}");
        }
        else
        {
            Console.WriteLine("A palavra não foi encontrada no dicionario");
        }

        // 6 - Excluir um elemento do diocionario
        dicionario.Remove("Fernando");
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
                // 7 - Ordenar um Dicionario por chave
        var DicionarioOrdernado = dicionario.OrderBy(i => i.Key);
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}