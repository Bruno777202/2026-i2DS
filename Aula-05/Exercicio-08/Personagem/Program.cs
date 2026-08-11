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

        public int Nivel {get; private set;}
        public int Forca {get;private set;}

        public string Agilidade {get; set;}

        public string Inteligencia {get; set;}

        public string Vida {get; set;}



    }

// Método Construtor
        public Personagem(string nome, int forca, int agilidade, int inteligencia, int vida)
        {
            Nome = nome;
            Forca = forca;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            Vida = vida;
            Experiencia = 0;
            Nivel = 1; 
        }

        public virtual void ApresentarSe()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nível: {Nivel}");
            Console.WriteLine($"Experiência: {Experiencia}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Agilidade: {Agilidade}");
            Console.WriteLine($"Inteligência: {Inteligencia}");
            Console.WriteLine($"Vida: {Vida}");
        }

        public virtual void Atacar(Personagem alvo)
        {
            int dano = Forca;
            Console.WriteLine($"{Nome} atacou {alvo.Nome}");

            alvo.Defender(dano);
            GanharExperiencia(20);       
        }

        public virtual void Defender(int dano)
        {
            int danoRecebido = dano - Agilidade;
            if(danoRecebido < 1)
            {
                danoRecebido = 1;
            } 
            Vida -= danoRecebido;
            if(Vida < 0)
            {
                Vida = 0;
            }
            Console.WriteLine($"Dano Recebido: {danoRecebido}");
            Console.WriteLine($"Vida de  {Nome}: {Vida}");
        }
        public void GanharExperiencia(int experiencia)
        {
            Experiencia += experiencia;
            Console.WriteLine($"{Nome} ganhou {experiencia} XP");

            VerificarEvolucao();
        }

        public void VerificarEvolucao()
        {
            int experienciaNecessaria = Nivel * 100;
            if (Experiencia >= experienciaNecessaria)
            {
                Evoluir();
            }
        }

        protected virtual void Evoluir()
        {
            Nivel++; // Nivel = Nivel + 1
            Forca += 2; // Forca = Forca + 2
            Agilidade += 2;
            Inteligencia +=2;
            Vida += 10;
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("              LEVEL UP!");
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine($"{Nome} evoluiu para o nível {Nivel}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Agilidade: {Agilidade}");
            Console.WriteLine($"Inteligência: {Inteligencia}");
            Console.WriteLine($"Vida: {Vida}");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        public class Mago : Personagem
    {
        public Mago(string)
    }

}