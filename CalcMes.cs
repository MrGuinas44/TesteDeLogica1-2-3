using System;

public class calc
{
    public static void operacao()
    {
        double valorPresente;
        double taxaJurosPerc;
        int periodoMes;
        int cont = 1;

        Console.WriteLine("Informe o valor presente:");
        valorPresente = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nInforme a taxa de juros:");
        taxaJurosPerc = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nInforme o periodo de meses:");
        periodoMes = Convert.ToInt32(Console.ReadLine());
        double RendaAcld = valorPresente;

        taxaJurosPerc = taxaJurosPerc/100;

        Console.WriteLine("| Mês | Taxa Juros | Rendimento | Rend. Liquido | Renda Acumulada |");
        while(cont<=periodoMes)
        {
            double valorFinal = valorPresente * Math.Pow((1 + taxaJurosPerc), cont);
            
            Console.Write($"| {cont}   |");
            Console.Write($" {taxaJurosPerc * 100}%      |");
            Console.Write($" {valorFinal.ToString("N2")}   |");
            double RendaLiq = valorFinal - valorPresente;
            Console.Write($" {(RendaLiq).ToString("N2")}         |");
            RendaAcld = RendaAcld + valorFinal - valorPresente;
            Console.Write($"  {RendaAcld.ToString("N2")}       |");
            Console.Write("\n");
            cont++;
        }
    }
}