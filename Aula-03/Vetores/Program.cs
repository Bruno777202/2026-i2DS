internal class Program
{
    private static void Main(string[] args)
    {
       /* Vetores e matrizes
         Vetor -> é uma estrutura de dados utilizados para armazenar 
         varios valores de um tipo dentro de uma unica variavel 

         sintaxe: tipo[] nome vetor = new[tamanho];
       */

        // iniciar uma vetor_> lista de frutas 
          
          string[] listafrustas = {"Moça", "manga", "Morango", "Melancia", "melão"};
          Console.WriteLine("Acessar o terceiro elementos da lista");
          Console.WriteLine(listafrustas[2]);
          Console.WriteLine("ALterar o segundo elemento da lsita:");
          listafrustas[1] = "banana";

          for(int indice = 0; indice < listafrustas.Count(); indice++ )
        {
            Console.WriteLine(listafrustas[indice]);
        }

        //========================================================================================

        foreach (string fruta in listafrustas)
        {
            Console.WriteLine(fruta);
        }










    }
}