using System;
using System.Globalization;

namespace testeTecnico03 {
    class Program {
        static void Main(string[] args) {

            decimal[] faturamentoDiario = { 1000.50M, 2500.70M, 1800.90M, 3000.20M, 2100.40M, 1500.60M, 1700.80M, 2900.10M, 2200.30M, 2600.50M, 2300.70M, 2800.90M };
            decimal menorValor = faturamentoDiario[0];
            decimal maiorValor = faturamentoDiario[0];
            decimal somaFaturamento = 0;

            foreach (decimal valor in faturamentoDiario) {
                if (valor < menorValor) {
                    menorValor = valor;
                }
                if (valor > maiorValor) {
                    maiorValor = valor;
                }
                somaFaturamento += valor;
            }

            decimal mediaFaturamento = somaFaturamento / faturamentoDiario.Length;
            int diasAcimaMedia = 0;

            foreach (decimal valor in faturamentoDiario) {
                if (valor > mediaFaturamento) {
                    diasAcimaMedia++;
                }
            }

            Console.WriteLine("Menor valor de faturamento diário: R${0}", menorValor);
            Console.WriteLine("Maior valor de faturamento diário: R${0}", maiorValor);
            Console.WriteLine("Número de dias com faturamento acima da média: {0}", diasAcimaMedia);
        }
    }
}
    