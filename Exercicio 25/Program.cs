using Exercicio_25.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int numberTaxPayers = int.Parse(Console.ReadLine());

            List<Pessoa> listPessoa = new List<Pessoa>();

            for (int i = 0; i < numberTaxPayers; i++)
            {
                Console.Write("Individual or company (i/c)? ");
                char typePeople = char.Parse(Console.ReadLine());
                typePeople = char.ToUpper(typePeople);

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (typePeople == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());

                    listPessoa.Add(new PessoaFisica(name, anualIncome, healthExpenditures));
                }
                else if (typePeople == 'C')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployee = int.Parse(Console.ReadLine());

                    listPessoa.Add(new PessoaJuridica(name, anualIncome, numberEmployee));
                }
                else
                {
                    Console.WriteLine("Error");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            double total = 0.0;
            Console.WriteLine("\nTAXES PAID: ");
            foreach (var item in listPessoa)
            {
                double tax = item.CalcularImposto();
                Console.WriteLine(item.Nome + ": $ " + item.CalcularImposto().ToString("F2"));
                total += tax;
            }

            Console.WriteLine($"Total: {total.ToString("F2")}");
            Console.ReadKey();
        }
    }
}
