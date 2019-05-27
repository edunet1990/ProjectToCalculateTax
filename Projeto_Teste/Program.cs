using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pessoa = new List<FisicPerson>();
            JuridicPerson j = new JuridicPerson();
            FisicPerson f = new FisicPerson();

            Console.Write("Enter the number of tax payer");

            int numbersOfTaxPayers = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numbersOfTaxPayers; i++)
            {
                Console.Write("Individual or Company (i/c)? ");
                string choiceIndivOrCompany = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();


                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (choiceIndivOrCompany == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExpend = double.Parse(Console.ReadLine());
                    f.Name = name;
                    f.AnnualIncome = anualIncome;
                    f.HealthExpenditures = healthExpend;
                    f.Impostos();
                    Pessoa.Add(f);
                    
                }
                else
                {
                    Console.Write("Number of employeeds: ");
                    int nEmployeds = int.Parse(Console.ReadLine());

                    j.Name = name;
                    j.AnnualIncome = anualIncome;
                    j.EmployeesNumber = nEmployeds;
                    j.Impostos();
                    Pessoa.Add(j);
                }

             
            }


            foreach (var item in Pessoa)
            {
                Console.WriteLine($" {item.Name}: $ {item.AnnualIncome}");
            }

            Console.ReadLine();
        }
    }
}
