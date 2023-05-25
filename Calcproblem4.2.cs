using System;

public class saque
{
    public static void operacao()
    {
        double valorPresente;
        double taxaJuros;
        int periodoMes;
        int cont = 1;

        Console.WriteLine("Informe o valor presente:");
        valorPresente = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nInforme a taxa de juros:");
        taxaJuros = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nInforme o periodo de meses:");
        periodoMes = Convert.ToInt32(Console.ReadLine());
        double RendaAcld = valorPresente;

        taxaJuros = taxaJuros/100;

        Console.WriteLine("| Mês | Valor Presente | Taxa Juros | Rendimento | Rend. Liquido | Renda Acumulada |");
        for(int i = 1; i <= periodoMes; i++)
        {
            double valorFinal = valorPresente * Math.Pow((1+taxaJuros), cont);
            double RendaLiq = valorFinal - valorPresente;
            double saque;
            
            if(cont == 5)
            {
                Console.WriteLine($"\nÉ chegado o {i}º mes. Informe o valor que deseja sacar?: ");
                saque = Convert.ToDouble(Console.ReadLine());
                valorFinal = valorPresente * Math.Pow((1+taxaJuros), cont);
                RendaAcld += RendaLiq - saque;
                valorPresente = RendaAcld;
                cont = 0;
            }
            else
            {
                RendaAcld += valorFinal - valorPresente;
            }

            Console.Write($"| {i}   |");
            Console.Write($" R${valorPresente.ToString("N2")}     |");
            Console.Write($" {taxaJuros * 100}%         |");
            Console.Write($" {valorFinal.ToString("N2")}   |");
            Console.Write($" {(RendaLiq).ToString("N2")}         |");
            Console.Write($" {RendaAcld.ToString("N2")}        |");
            Console.Write("\n");
            cont++;
        }
    }
}