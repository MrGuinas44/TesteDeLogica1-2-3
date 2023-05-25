using System;

public class meses
{
    public static void operacao()
    {
       double valorInicial;
       double taxaJuros;
       double valorFinal;

       Console.WriteLine("Informe o valor inicial:");
       valorInicial = Convert.ToDouble(Console.ReadLine());

       Console.WriteLine("Informe a taxa em juros:");
       taxaJuros = Convert.ToDouble(Console.ReadLine());

       taxaJuros = taxaJuros / 100;

        Console.WriteLine("| Mês | Valor Presente | Taxa Juros | Rendimento |");
        for(int i = 1; i <= 8; i++)
        {
            valorFinal = valorInicial * Math.Pow((1 + taxaJuros), i);
            Console.Write($"| {i}  |");
            Console.Write($" {valorInicial.ToString("N2")}        |");
            Console.Write($" {taxaJuros * 100}%         |");
            Console.Write($" {valorFinal.ToString("N2")}   |");
            Console.Write("\n");
        }
        valorFinal = valorInicial * Math.Pow((1 + taxaJuros), 8.3);
        Console.WriteLine($"Valor final para 8 meses e 10 dias: {valorFinal.ToString("N2")}");
    }
}