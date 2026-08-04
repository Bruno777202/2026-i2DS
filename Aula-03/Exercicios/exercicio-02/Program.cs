internal class Program
{
    private static void Main(string[] args)
    {
        


        int num1;
        int num2;"";

        Console.Write("Digite o primeiro numero");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite um segundo número: ");


        Console.WriteLine("1-soma");
        Console.WriteLine("2-subtração");
        Console.WriteLine("3-multplicação");
        Console.WriteLine("4-divisão");

        string operadores;

        Console.Write("selecione uma operação: ");
        operadores = Console.ReadLine();

        double resultado=0;

         switch (operadores)
        {
            case "1":
            resultado = num1 + num2;
            break;
            case "2":
             resultado = num1 + num2;
            break;
            case "3":
             resultado = num1 + num2;
            break;
             case "4":
            resultado = num1 + num2;
            break;
          default:
            Console.WriteLine("Operador informado não é valido");
            break;
        }
         

    }

    
}