using System;

public class juros
{
    public static void operacao()
    {
        double valorPresente = 1000;
        double taxaJuros = 5.30;
        int periodoMes = 10;
        double valorFinal;

        taxaJuros = taxaJuros/100;

        valorFinal = valorPresente * Math.Pow((1 + taxaJuros), periodoMes);

        Console.WriteLine($"\nSeu valor presente é: R${valorPresente.ToString("N2")}");
        Console.WriteLine($"\nSua taxa de juros é : {taxaJuros} = {taxaJuros * 100}%");
        Console.WriteLine($"\nO periodo de meses é: {periodoMes}");
        Console.WriteLine($"\nSeu valor futuro será: R${valorFinal.ToString("N2")}");
    }
}