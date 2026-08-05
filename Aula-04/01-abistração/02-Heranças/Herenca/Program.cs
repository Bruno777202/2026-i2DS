internal class Program
{
    private static void Main(string[] args)
    {
       

       Animal animal01 = new Animal();
       Cachorro dog1 = new Cachorro();

       animal01.Nome = "Ferdinando";
       animal01.Idade = 2;

       Console.WriteLine($"Nome do animal: {animal01 .Nome} - {animal01.idade}");

       dog1.Nome = "Snoop";
       dog1.idade = 5;
       dog1.Raca = "Vira-Lata";
       dog1.Latir();

       Console.WriteLine($"Nome: {dog1.Nome} | idade {dog1.idade} | Raça {dog1.Raca}");
    }

    public class Animal
    {
        public int Nome {get; set;}

        public int idade {get; set;}
    }

    public class Cachorro : Animal
    {
        public string Raca {get; set;}

        public void Latir()
        {
            Console.WriteLine("Au Aa");
        }
    }
}