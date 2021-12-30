namespace Exercicio_25.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public double GastoSaude { get; private set; }

        /* Pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. 
         * Pessoas com renda de 20000.00 em diante pagam 25% de imposto.
         * Se a pessoa teve gastos com saúde, 50% destes gastos são abatidos no imposto.*/
        public override double CalcularImposto()
        {
            double imposto;

            if (RendaAnual <= 20000)
            {
                imposto = ((RendaAnual * 15) / 100); 
            }
            else
            {
                imposto = ((RendaAnual * 25) / 100);
            }

            if (GastoSaude > 0)
            {
                GastoSaude = (GastoSaude * 50) / 100;
                imposto -=  GastoSaude;
            }

            return imposto;
        }
    }
}
