using System;

namespace FinanciamentoVeiculo
{
    public class Financiamento
    {
        public Veiculo Veiculo;
        public decimal ValorEntrada;
        public int NumeroParcelas;
        public double TaxaJurosMensal;


        public decimal CalcularValorTotalFinanciado()
        {
            decimal valorFinanciado = Veiculo.Preco - ValorEntrada;
            return valorFinanciado;
        }

        public decimal CalcularValorParcela()
        {
            decimal valorFinanciado = CalcularValorTotalFinanciado();
            double taxaJuros = TaxaJurosMensal / 100.0;
            double valorParcela = (double)(valorFinanciado * Convert.ToDecimal(taxaJuros) /
                                  (1 - Convert.ToDecimal(Math.Pow(1 + taxaJuros, -NumeroParcelas))));
            double total = (double)(valorParcela * NumeroParcelas);
            return (decimal)valorParcela;
        }

        public decimal CalcularTotal()
        {
            decimal valorFinanciado = CalcularValorTotalFinanciado();
            double taxaJuros = TaxaJurosMensal / 100.0;
            double valorParcela = (double)(valorFinanciado * Convert.ToDecimal(taxaJuros) /
                                  (1 - Convert.ToDecimal(Math.Pow(1 + taxaJuros, -NumeroParcelas))));
            double totalfull = valorParcela * NumeroParcelas;
            return (decimal)totalfull;
        }


    }
}
        

