internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM  PILHAS (FILO )====");

        //1 - criar uma nova pilha vazia
        Stack<string> pilhaLivros = new Stack<string>();

        // 2- adicionar lel,mentos em uma pilha 
        pilhaLivros.Push("Dom quixote");
        pilhaLivros.Push("O Morro dos ventos Univantes");
        pilhaLivros.Push("O Cortiço");

        // 3 - Percorrer todos os elementos de uma pilha 
            Console.WriteLine();

        foreach(var livro in pilhaLivros)
        {
            Console.WriteLine(livro);
        }

        // Remover elemnetos da pilha
        string livroRemovido = pilhaLivros.Pop();
            Console.WriteLine();
            Console.WriteLine($"O livor retirado foi: {livroRemovido}");

            pilhaLivros.Push("Dom quixote");
            Console.WriteLine();
            Console.WriteLine();
        foreach(var livro in pilhaLivros)
        {
            Console.WriteLine(livro);
        }



        
    }
}