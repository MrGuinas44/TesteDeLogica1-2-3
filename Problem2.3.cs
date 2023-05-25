using static System.Console;

public class saqueeight
{
    public static void operacao()
    {
        double valorInicial;
        double taxaJuros;
        double valorFinal;
        int i;

        WriteLine("Informe o valor presente:");
        valorInicial = Convert.ToDouble(ReadLine());
        WriteLine("\nInforme a taxa de juros:");
        taxaJuros = Convert.ToDouble(ReadLine());

        double RendaAcld = valorInicial;
        taxaJuros = taxaJuros/100;

        WriteLine("| Mês | Valor Presente | Taxa Juros | Rendimento | Rend. Liquida |");
        for(i=1; i<=8; i++)
        {
            valorFinal = valorInicial * Math.Pow((1 + taxaJuros), i);
            double RendaLiq = valorFinal - valorInicial;
            Write($"| {i}  |");
            Write($" {valorInicial.ToString("N2")}        |");
            Write($" {taxaJuros * 100}%         |");
            Write($" {valorFinal.ToString("N2")}   |");
            Write($" {(RendaLiq).ToString("N2")}         |");
            Write("\n");

            if(i == 5)
            {
                WriteLine("Eis aí o 5º mês, quanto deseja sacar?:");
                double saque = Convert.ToDouble(ReadLine());
                if(saque <= 0)
                {
                    continue;
                }
                else
                {
                    saque = valorFinal - saque;
                    valorInicial = saque;
                }
            }
        }
        valorFinal = valorInicial * Math.Pow((1 + taxaJuros), 8.3);
        WriteLine($"Valor final para 8 meses e 10 dias: {valorFinal.ToString("N2")}");
    }
}