internal class Program
{
    private static void Main(string[] args)
    {
        // polimorfismo : ou objeto pode ser tratadop de maneiras diferntes do contexto que é utilizada

        Gato = new Gato()
    }

    // Super Classe
    public class Animal
    {
        public string Nome {get; set; }

        public void FazerBarulho()
        {
            Console.WriteLine("Todo animal faz um barulho");
        }
    }

    public class Cachorro : Animal
    {
        public over void FazerBarulho()
        {
            Console.WriteLine("Au Au Au")
        }
    }
}