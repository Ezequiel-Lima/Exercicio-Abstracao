using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_25.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome, double rendaAnual, int funcionario) : base(nome, rendaAnual)
        {
            Funcionario = funcionario;
        }

        public int Funcionario { get; private set; }

        /* Pessoas jurídicas pagam 16% de imposto. 
         * Porém, se a empresa possuir mais de 10 funcionários 
         * Ela paga 14% de imposto. */
        public override double CalcularImposto()
        {
            double imposto;

            if(Funcionario > 10)
            {
                imposto = ((RendaAnual * 14) / 100);
            }
            else
            {
                imposto = ((RendaAnual * 16) / 100);
            }

            return imposto;
        }
    }
}
