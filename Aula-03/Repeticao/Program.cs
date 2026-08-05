using System.Globalization;
using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // sintaxe :
        // enquanto uma condição for verdadeira 
        // execute um conjunto de comandos

        /*
         for -> quando sabemos q quantidade de rtepetição 
         while -> quando a repetição depende de uma condiçao 
         do while -> quando precisa executar ao menos uma vez bloco de codigo
        */


        // loça for : imprimir numero de  ate o 10 

        
          Console.WriteLine("imprimir numeros de 1 a 10, utilizando o laço for");
        for (int numero =1; numero<= 10; numero++ )
        {
            Console.WriteLine(numero);
        }
        //laço for : Contagem regresiva de 10 até 0
        for (int numero =1; numero >= 0; numero-- )
        {
            Console.WriteLine(numero);
        }

        //============================================================================================================
          Console.WriteLine("imprimir numeros de 1 a 10, utilizando o laço while.");

        int contador = 1;

        while(contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }

        /*
         solicitar a senha até acertar
        */

        string senha = "";

        while(senha != "2444")
        {
            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();
        }
         Console.WriteLine("Acesso permitido");

        //=====================================================================================
        int Num;
        do
        {
           Console.Write("Digite um Número Positivo: ");
           Num = int.Parse(Console.ReadLine());
        }while(Num <=0);












    }
}