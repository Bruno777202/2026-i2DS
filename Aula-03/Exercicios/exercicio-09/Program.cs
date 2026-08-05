using System.Collections;

double saldo= 0;
internal partial class Program
{
    private static void Main(string[] args)
    {
        
        int opcao;

        do
        {
            Console.WriteLine("1-consultar saldo");
            Console.WriteLine("2-depositar");
            Console.WriteLine("3-sacar");
            Console.WriteLine("4-sair");

            Console.WriteLine("escolha a opção: ");

           opcao = int.Parse(Console.ReadLine());

           switch (opcao);
            {
                case 1;
                consultarSaldo(saldo);
                break;
                case 2;
                depositar(saldo);
                break;
                case 3;
                sacar(saldo);
                break;
                case 4;
                Console.WriteLine("encerrando o sistema...");
                break;
                default;
                Console.WriteLine("A opcção selecionada não é valida");
                break;
            }

        }while(opcao != 4);
    }

    public static void consultarSaldo(double saldo)
    {
        Console.WriteLine($"saldo Atual: R$ (saldo:F2)");
    }
    public static void depositar(double saldo)
    {
        double Valor;
        Console.WriteLine("Valor de Deposita: ");
        Valor = double.Parse(Console.ReadLine());
        saldo += Valor;
        consultarSaldo(saldo);
    }

    public static void sacar(double saldo)
    {
         double Valor;
        Console.WriteLine("Valor de saque: ");
        Valor = double.Parse(Console.ReadLine());
        if(Valor <= saldo)
        {
            saldo -= Valor;
            consultarSaldo(saldo);
        }
        else
        {
          Console.WriteLine("Saque não realizado. saldo insuficiente");
        }
    }
}