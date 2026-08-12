using System.Security.Cryptography;

internal class Program
{
    public class Aluno
    {
        public int Id {get;set ;}
        public string? Nome {get; set;}
        public string? MAtricula {get; set;}
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM  LISTA ====");

        // 1 - Iniciar uma nova lista 
        List<Aluno> listaAluno = new List<Aluno>();

        Aluno aluno1 = new Aluno{Id = 1, Nome = "Zuleika", MAtricula = "12345"};
        Aluno aluno2 = new Aluno{Id = 2, Nome = "Pafuncio", MAtricula = "25256"};
        Aluno aluno3 = new Aluno{Id = 3, Nome = "Asdrubal", MAtricula = "85235"};

        // 2 - incluir elementos na lista
        listaAluno.Add(aluno1);
        listaAluno.Add(aluno2);
        listaAluno.Add(aluno3);

        //3 - Percorrer todos elementos de uma lista
        foreach(var aluno in listaAluno)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.MAtricula}");
        }


        // 4 - Alterar um elemento da lista
        listaAluno[1].MAtricula = "55555";
        listaAluno[2].Nome = "aleutério";
        Console.WriteLine();
         foreach(var aluno in listaAluno)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.MAtricula}");
        }
        Console.WriteLine();
        Console.WriteLine($"quantidade de elemneto na lista {listaAluno.Count()}");


        // 5- Remover o elemento da lista 
        listaAluno.RemoveAt(0);
         Console.WriteLine();
         foreach(var aluno in listaAluno)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.MAtricula}");
        }

        // 6 - Remover um elemento da lista por objeto
        listaAluno.Remove(aluno3);
        Console.WriteLine();
         foreach(var aluno in listaAluno)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.MAtricula}");
        }



        // 7 - qunatidade de elementos da lista 
        Console.WriteLine();
        Console.WriteLine($"quantidade de elemneto na lista {listaAluno.Count()}");

        // 8 - Remover todos elementos da lista
        listaAluno.Clear();





    }
}