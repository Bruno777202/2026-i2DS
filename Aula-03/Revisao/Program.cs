internal class Program
{
    private static void Main(string[] args)
    {
        //Criar uma variavel
        // sintaxe : tipo variavel nome variavel = valor variavel

        // tipo de dados primarios 
        /*
          int -> reprensentação de um Número inteiros 
        */

        int idade = 21;
        /* double -> Representção de Número DECIMAIS */

        double salario = 10352.25;
        float altura = 1.75f;
        decimal peso = 70.35m;

        /* string -> Represenção de um texto alphabumerico */

        string nome = "thomaz";
        string celular = "14996667788";
        string cpf = "123.456.786-03";

        /* bool -> representação um numero Booleano (true or false)*/

        bool estudante = true;
        bool temLimite = false;
        /* datetijme -> Representação de data e hora*/
        DateTime cadastro =  new DateTime(2026,08,04,09,15,32);
        DateOnly nascimento = new DateOnly(2010,01,20);

        /*------------------------------------------------------------------------------------*/
        //operadores matematicos 
        //+ somar, -subtrair 
        // * -> multiplicar
        // / -> divisão 
        // % -> resto da divisão 
        // ** -> Exponiciação 5 ** 3
        // ^ -> ele tambem faz Exponiciação
        //atribuição

        int n1 = 10;
        int n2 = 3;
        double resultado = 0;

        //calcular a soma dos dois nuromes
        resultado = n1 + n2;
        Console.WriteLine("A soma do dois números é: " + resultado);
        // Calcular a subtração :
         resultado = n1 - n2;
        Console.WriteLine("A subtração  do dois números é: " + resultado);
        // Calcular a mutiplicação:
        resultado = n1 * n2;
        Console.WriteLine("A mutiplicação do dois números é: " + resultado);
        // Calcular  da divisão
        resultado = n1 / n2;
        Console.WriteLine("A  divisão do dois nùmeros é: " + resultado);
        // calcular o resto da divisão 
        resultado = n1 % n2;
        Console.WriteLine("A resto da divisão do dois nùmeros é: " + resultado);
        // calcular potencia 
        resultado = n1 ^ n2;
        Console.WriteLine("A Número elevado 1 do dois nùmeros é: " + resultado);

        /** opredor de incrementador **/

        Console.WriteLine("Valor de N1:" + n1);
        n1++; //Aumento do número atuel em + 1
        Console.WriteLine("Valor de N1:" + n1);

        // Operador de incremento 
        n1+=10;
        
        Console.WriteLine("Valor de N1: " + n1);
        //decremento
        n1-=10;
        Console.WriteLine("Valor de N1:" + n1);

        //===================================================================================================
        //Operadores relacionais -> realiza comparações
        // > -> maior que
        // < -> menor que 
        // >= -> maior ou igual que
        // <= -> menor ou igual que
        //== -> igual 
        // != -> diferente

        idade = 13;
        Console.WriteLine("A idade informada é maior que 18?: " +(idade > 18));

        peso = 55;
        Console.WriteLine("o peso indormado é menor que 60 kg?: " + (peso <= 60));

        estudante = false;
        Console.WriteLine("O nome informado é de um esdudante?: " + (estudante == true));

        //=======================================================================================================
        //Operadores logicos -> permitem combinar duas ou mais condições
        // && -> operadores logicos "E"
        // || -> operador logico "OU"
        // ! -> operador de negação.

        peso = 100;
        altura = 170;

        Console.WriteLine("peso: " + peso + "Altura: " + altura);
        Console.Write((peso <= 100) && (altura > 180));

        
        Console.WriteLine("peso: " + peso + "Altura: " + altura);
        Console.Write((peso <= 100) || (altura > 180));





        






    }
}