internal class Program
{
    private static void Main(string[] args)
    {
        Personagem personagens = new Personagem();
        personagens.Nome = "pequeno";
        personagens.Nivel = 60;
        personagens.Forca = 110;
        personagens.Agilidade = "ninja";
    }

    public class Personagem
    {
        public string Nome {get; set;}

        public int Nivel {get; set;}
        public int Forca {get; set;}

        public string Agilidade {get; set;}

        public string Inteligencia {get; set;}

        public string Vida {get; set;}



    }

    public class Categoria
    {
        public string mogo {get; set;}
        public string Elfo {get; set;}
        public string Cavalheiro {get; set;}


    }
}