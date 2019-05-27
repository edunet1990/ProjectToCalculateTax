using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Teste
{
    class JuridicPerson : FisicPerson
    {
        public int EmployeesNumber { get; set; }


        public JuridicPerson()
        {

        }

        public JuridicPerson(string name, double annualIncome, int employeesNumber) : base(name, annualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override void Impostos()
        {
           
            if (EmployeesNumber > 10)
            {
                double percentual = 14.0 / 100.0;
                AnnualIncome = (percentual * AnnualIncome);
            }
            else
            {
                double percent = 16.0 / 100.0;
                AnnualIncome = (percent * AnnualIncome);
            }
        }
    }
}
