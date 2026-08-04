internal class Program
{
    private static void Main(string[] args)
    {
        Ola("cristiano");
        Ola("maria");
        Ola("joão");
    Console.WriteLine(" A soma de 5 e 3 é: " + calcular(5,3, "+"));
    Console.WriteLine(" A subtração de 5 e 3 é: " + calcular(5,3, "-"));

    }

    // finção sem retorno e sem parametros
   /* public static void Ola()
    {
        Console.WriteLine("Olá, seja bem vindo!");
    }*/
    // Função com parametros nome e sem retorno
    public static void Ola(string nome)
    {
        Console.WriteLine("Olá" + nome +", seja bem vindo(a)!");
    }

    public static double calcular(double num1, double num2, string operador)
    {
        
       double resultado=0;

        switch (operador)
        {
            case "+":
            resultado = num1 + num2;
            break;
            case "-":
            resultado = num1 + num2;
            break;
            case "*":
            resultado = num1 + num2;
            break;
             case "/":
            resultado = num1 + num2;
            break;
          default:
            Console.WriteLine("Operador informado não é valido");
            break;
        }
         
       return resultado;


    }
}