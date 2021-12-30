namespace Exercicio_25.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; private set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        /* Pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. 
         * Pessoas com renda de 20000.00 em diante pagam 25% de imposto.
         * Se a pessoa teve gastos com saúde, 50% destes gastos são abatidos no imposto.*/
        public override double CalcularImposto()
        {
            double imposto;

            if (RendaAnual <= 20000)
            {
                return imposto = ((RendaAnual * 15) / 100) - ((GastoSaude * 50) / 100); 
            }
            else
            {
                 return imposto = ((RendaAnual * 25) / 100) - ((GastoSaude * 50) / 100);
            }
        }
    }
}
