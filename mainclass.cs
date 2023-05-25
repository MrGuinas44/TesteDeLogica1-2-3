using System;

public class Program
{
    public static void Main()
    {
        int sel;

        do
        {
            Console.WriteLine("\nInforme um valor de 1 a 7:");
            Console.WriteLine("1- Calcula juros composto com um valor definido");
            Console.WriteLine("2- Mostra o rendimento para um determinado mês");
            Console.WriteLine("3- Calcula juros composto com o valor que desejar");
            Console.WriteLine("4- Mostra o rendimento e permite saque ao 5º mês");
            Console.WriteLine("5- Calcula o valor presente atraves do valor futuro");
            Console.WriteLine("6- Mostra o rendimento para 8 meses e 10 dias");
            Console.WriteLine("7- Mostra o rendimento para 8 meses e 10 dias e permite o saque");
            Console.WriteLine("Digite 0 para encerrar o programa.");

            sel = Convert.ToInt32(Console.ReadLine());

            switch(sel)
            {
                case 1:
                juros.operacao();
                break;

                case 2:
                calc.operacao();
                break;

                case 3:
                jurosIII.operacao();
                break;
                
                case 4:
                saque.operacao();
                break;

                case 5:
                futuro.operacao();
                break;

                case 6:
                meses.operacao();
                break;

                case 7:
                saqueeight.operacao();
                break;

                case 0:
                Console.Write("\nPrograma encerrado!");
                break;

                default:
                Console.WriteLine("\nDigite um valor valido");
                break;
            }
        }while(sel != 0);
    }
}