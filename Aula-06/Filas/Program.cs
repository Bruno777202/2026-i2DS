internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM  FILAS (fifo) ====");

        // 1 - criar uma nova fila vazia
        Queue<string> filaBanco = new Queue<string>();

        // 2 - adicionar elementos nas filas

        filaBanco.Enqueue("zuleika");        //0
        filaBanco.Enqueue("asdrubal");       //1
        filaBanco.Enqueue("Pafuncio");       //2
        filaBanco.Enqueue("Epaminondas");    //3 

        // 3 - Percorrer lelmnetos de uma fila 


        foreach ( var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }
        
        // 4 - retirar um lemento da lçista 
        string pessoaRetirada = filaBanco.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"Nome chamado foi : {pessoaRetirada}");
       
        Console.WriteLine("Lucrácia");
        foreach ( var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }
          
          // 5 - Verificando se existe um determinado elemnento na lista
          string procurar = "Pafuncio";
          bool achou = filaBanco.Contains("procurar");
          if (achou)
        {
            Console.WriteLine($"{procurar }está na fila");
        }
        else
        {
            Console.WriteLine($"{procurar} NÃO  esta na fila");
        }

        
    }
}