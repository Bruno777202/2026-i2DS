internal class Program
{
    private static void Main(string[] args)
    {

       //Primeiro Carro
        Carro carro1 = new Carro();
        carro1.Marca = "Ferraria";
        carro1.modelo = "pista 488";
        carro1.velocidade = 110;


        //segundo Carro
        Carro carro2 = new Carro();
        carro2.Marca = "Porsche";
        carro2.modelo = "carreria";
        carro2.velocidade = 100;
  
        //Terceiro Carro
        Carro carro3 = new Carro();
        carro3.Marca = "";
        carro3.modelo = "";
        carro3.velocidade = 50;


  
    }

    public class Carro
    {
        public string Marca {get; set;}
        public string modelo {get; set;}
        public int velocidade {get; set;}


        

 } 
 
  }



