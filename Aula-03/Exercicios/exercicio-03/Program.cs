using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite a nota do Aluno: ");
        int nota = int.Parse(Console.ReadLine());

        if(nota >= 6.9)
        {
            Console.WriteLine("Aluno foi aprovado");
        }
        else
        {
            Console.WriteLine("Aluno foi Reprovado");
        }
    }
}