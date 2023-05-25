using System;

public class futuro
{
    public static void operacao()
    {
        double valorPresente;
        double taxaJuros;
        int periodo;
        double valorFuturo;

        Console.WriteLine("Informe o valor futuro:");
        valorFuturo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nInforme a taxa de juros:");
        taxaJuros = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nInforme o periodo:");
        periodo = Convert.ToInt32(Console.ReadLine());

        taxaJuros = taxaJuros / 100;

        valorPresente = valorFuturo / Math.Pow((1 + taxaJuros), periodo);

        Console.WriteLine($"Valor presente: R${valorPresente.ToString("N2")}");
    }
}