using System;

public class jurosIII
{
    public static void operacao()
    {
        double valorPresente;
        double taxaJuros;
        int periodoMes;
        double valorFinal;

        Console.WriteLine("Insira o valor presente:");
        valorPresente = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nInsira a taxa de juros:");
        taxaJuros = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nInsira o periodo de meses:");
        periodoMes = Convert.ToInt32(Console.ReadLine());

        taxaJuros = taxaJuros/100;

        valorFinal = valorPresente * Math.Pow((1 + taxaJuros), periodoMes);

        Console.WriteLine($"\nSeu valor futuro será: R${valorFinal.ToString("N2")}");
    }
}
