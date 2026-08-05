internal class Program
{
    private static void Main(string[] args)
    {
       // Se (determinada condição ) for verdadeiro executar esssa função 
       // senão 
       // executar o qeu esta logo abiaxo

       /*
        if(condição )
        {
          codigo se verdadeiro
        }else{
         codigo falso
        }
          
        
       */

       //varificar se uma idade um maior que 18 anos 
       int idade = 10;
       if(idade >=18)
        {
            Console.WriteLine("maior de idade");
        }
        else
        {
            Console.WriteLine("menor de idade");
        }
        //================================================================
         Console.Write("Digite a nota: ");
         int nota = int.Parse(Console.ReadLine());

         if(nota >= 7)
        {
            Console.WriteLine("aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }

        bool bloqueado = false;

        if (!bloqueado)
        {
            Console.WriteLine("Acesso permitido");
        }

         //==============================================================



         Console.WriteLine("1 - cadastrar");
         Console.WriteLine("2 - consultar");
         Console.WriteLine("3 - excluir");
         Console.WriteLine("4 - sair");

         Console.Write("Escolha uma opção: ");
         int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
            Console.WriteLine("cadastro selecionado");
             break;
             case 2:
             Console.WriteLine("consulta selecionado");
             break;
             case 3:
             Console.WriteLine("Execlusão selecionado");
             break;
             case 4:
             Console.WriteLine("Encerrado selecionado");
             break;
             default:
             Console.WriteLine("opção invalida.");
             break;



        }
         



    }
}