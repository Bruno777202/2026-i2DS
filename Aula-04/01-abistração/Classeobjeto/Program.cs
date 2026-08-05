internal class Program
{
    private static void Main(string[] args)
    {
       /*
        classe -> é a abstração de um objeto do mundo realpara o mundo computacional.
        objeto -> é a instacia de uma classe
       */
        
         // instanciar um objeto do tipo aluno

         Aluno aluno01 = new Aluno();
         Aluno aluno02 = new Aluno();
        
        //atribuir valores
         aluno01.Nome = "jose da silva";
         aluno01.RM = 2444;
         aluno01.datanascimento = new DateOnly(2010,01,15);


         aluno02.Nome = "joão dos santos";
         aluno02.RM = 1234;
         aluno02.datanascimento = new DateOnly(2006,01,15);

         aluno01.Apresentarse();
         aluno02.Apresentarse();



    }

    //delcaramento de uma classe

    public class Aluno // declarasão de uma classe
    {
        // atributos -> Carecteristicas
        public string Nome {get; set; }
        public int RM {get; set;}
        public DateOnly datanascimento {get; set;}

        //metados -> acões ou funcionalidade 
        public void Apresentarse()
        {
            Console.WriteLine($"Ola, meu nome é {Nome}, meu {RM}, nasci na data {datanascimento}");
        }
    }
}