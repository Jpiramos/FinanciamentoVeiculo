using System;

namespace FinanciamentoVeiculo
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            Console.Write("Modelo do Veículo: ");
            veiculo.Modelo = Console.ReadLine();

            Console.Write("Preço do Veículo: ");
            veiculo.Preco = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ano do Veículo: ");
            veiculo.Ano = Convert.ToInt32(Console.ReadLine());

            Financiamento financiamentoCarro = new Financiamento();
            financiamentoCarro.Veiculo = veiculo;

            Console.Write("Valor da Entrada: ");
            financiamentoCarro.ValorEntrada = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Número de Parcelas: ");
            financiamentoCarro.NumeroParcelas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Taxa de Juros Mensal (%): ");
            financiamentoCarro.TaxaJurosMensal = Convert.ToDouble(Console.ReadLine());

            decimal valorParcela = financiamentoCarro.CalcularValorParcela();
            decimal valorFull = financiamentoCarro.CalcularTotal();

            Console.WriteLine("\nDetalhes do Financiamento:");
            Console.WriteLine($"Modelo do Veículo: {veiculo.Modelo}");
            Console.WriteLine($"Preço do Veículo: R${veiculo.Preco:N2}");
            Console.WriteLine($"Ano do Veículo: {veiculo.Ano}");
            Console.WriteLine($"Valor da Parcela Mensal: R${valorParcela:N2}");
            Console.WriteLine($"Valor Total pago No Financiamento R${valorFull:N2}");
        }
    }
}
