using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {    
        //comentario de linha
        /*
         Comentarios de blocos ou comnetario em varias linhas
         pode ser ter várias limhas 
        
        */
        // Imprimir uma linha de texto na tela 
        Console.WriteLine("Promgramação Orientada a Objeto\n");

        Console.WriteLine("Abstração - 1 pilar da POO");

        /*criar uma classe em C#
        a classe deve ser declarada fora do bloco de programa
        */
         
         /*Criar um objeto de uma classe*/
         
         pet pet1 = new pet();

         pet1.nome = "Toto";
         pet1.tipo = "Cahorro";
         pet1.idade = 3;
         pet1.MosTrarNome();

        pet pet2 = new pet();

         pet2.nome = "Mingau";
         pet2.tipo = "Gato";
         pet2.idade = 8;
         pet2.MosTrarNome();


    }


    public class pet // o NOme da classe sempre com letras MAIUSI
    {
    // declaração dos Atributos 
     public string  nome;
     public string tipo;
     public int idade;

        // declaração dos metodos
     public void MosTrarNome()
    {
         Console.WriteLine("Meu nome é " + this,nome);
    }
    }
    
}
