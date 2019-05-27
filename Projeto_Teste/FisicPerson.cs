using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Teste
{
    class FisicPerson
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }
        public double HealthExpenditures { get; set; }

        public FisicPerson()
        {

        }

        public FisicPerson(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public FisicPerson(string name, double annualIncome, double healthExpenditures)
        {
            Name = name;
            AnnualIncome = annualIncome;
            HealthExpenditures = healthExpenditures;
        }


        public  virtual void Impostos()
        {
            double percent = 0;
            if (AnnualIncome < 20000.00)
            {
                 percent = 15.0/100.0;
                AnnualIncome = (percent * AnnualIncome);
            }

            if (AnnualIncome > 2000.00)
            {
                 percent = 25.0 / 100.0;
                AnnualIncome = (percent * AnnualIncome);
            }



            AnnualIncome = (AnnualIncome + percent) - (HealthExpenditures * (50.0 /100.0));
        }
    }
}
