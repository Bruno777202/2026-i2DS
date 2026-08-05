internal class Program
{
    private static void Main(string[] args)
    {
       // Encapsulamento -> visa "proteger" as Propreidades da classe

       Pessoa p1 = new Pessoa("Asdrubal","(14)99966-8822","asdrubal@email.com");
       p1.Nome = "Asdrubal";
       p1.Celular = "(14)99966-8822";
       p1.Email = "asdrubal@email.com";

    

       Console.WriteLine($"Nome: {p1.Nome} - celular: {p1.Celular} - email {p1.Email}");
    }
    public class Pessoa //
    {
        private string Nome {get; set;}

        private string Celular {get; set; }

        private string Email {get; set;}
        // alterar o metado construtor para os parametros para criação dos objetos
        public Pessoa( string nome, string celular, string email)
        {
            this.Nome = nome;
            this.Celular = celular;
            this.Email = email;
        }

        public void Mostrarcontato()
        {
            Console.WriteLine($"Nome {this.Nome} - Celular{this.Celular} - eamil {this.Email}");
        }

        public void Alterar(string celuiar)
        {
            this.Celular = Celular;
        }
        
    }
}