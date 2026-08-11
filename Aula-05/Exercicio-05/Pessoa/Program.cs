using System.IO.Pipes;

internal class Program
{
    private static void Main(string[] args)
    {
        //Primeiro Funcionario
        Funcionario funcionario1 = new Funcionario();
        funcionario1.Nome = "joão da silva";
        funcionario1.Idadeatual = 32;
        funcionario1.registro = 125;
        funcionario1.salario = 2750.00;
        //segundo funcionario
        Funcionario funcionario2 = new Funcionario();
        funcionario2.Nome = "Maria de Oliveira";
        funcionario2.Idadeatual = 26;
        funcionario2.registro = 125;
        funcionario2.salario = 2750.00;
        //terceiro funcionario
        Funcionario funcionario3 = new Funcionario();
        funcionario3.Nome = "Pedro dos santos";
        funcionario3.Idadeatual = 41;
        funcionario3.registro = 102;
        funcionario3.salario = 5700.00;

        Console.WriteLine("=== FUNCIONÁRIO===");
        Console.WriteLine("\nFuncionario 1");
        Console.WriteLine($"Nome: {funcionario1.Nome}");
        Console.WriteLine($"Idade: {funcionario1.Idadeatual}");
        Console.WriteLine($"registro: {funcionario1.registro}");
        Console.WriteLine($"Salario: {funcionario1.salario}");

        Console.WriteLine("=== FUNCIONÁRIO===");
        Console.WriteLine("\nFuncionario 2");
        Console.WriteLine($"Nome: {funcionario2.Nome}");
        Console.WriteLine($"Idade: {funcionario2.Idadeatual}");
        Console.WriteLine($"registro: {funcionario2.registro}");
        Console.WriteLine($"Salario: {funcionario2.salario}");

         Console.WriteLine("=== FUNCIONÁRIO===");
        Console.WriteLine("\nFuncionario 3");
        Console.WriteLine($"Nome: {funcionario3.Nome}");
        Console.WriteLine($"Idade: {funcionario3.Idadeatual}");
        Console.WriteLine($"registro: {funcionario3.registro}");
        Console.WriteLine($"Salario: {funcionario3.salario}");

        //Envelhecendo os funcionarios
        funcionario1.Envelhecer(13);
        funcionario2.Envelhecer(22);
        funcionario3.Envelhecer(39);

        Console.WriteLine("\n === Após ENVELHECER ===");
        Console.WriteLine($"{funcionario1.Nome} : {funcionario1.Idadeatual}");
        Console.WriteLine($"{funcionario2.Nome} : {funcionario1.Idadeatual}");
        Console.WriteLine($"{funcionario3.Nome} : {funcionario1.Idadeatual}");


    }


    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idadeatual {get; set;}

        public void Envelhecer(int anos)
        {
            Idadeatual += anos;
        }

    }


    public class Funcionario : Pessoa
    {
        public double salario {get; set;}
        public int registro {get; set;}

    }
}