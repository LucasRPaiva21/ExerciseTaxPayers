namespace TaxPayersEx.Entities
{
    class Individual : TaxPayers
    {
        public double HealthExpenses { get; set; }

        public Individual(double healthExpenses, string name, double annualIncome) 
            : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Tax()
        {
            double tax;

            if (AnnualIncome < 20000.00)
            {
                if(HealthExpenses > 0.0)
                {
                     tax = (AnnualIncome * 0.15) - (0.5 * HealthExpenses);
                } 
                else
                {
                    tax = AnnualIncome * 0.15;
                }

                
            } 
            else
            {
                if (HealthExpenses > 0.0)
                {
                    tax = (AnnualIncome * 0.25) - (0.5 * HealthExpenses);
                } else
                {
                    tax = AnnualIncome * 0.25;
                }
                
            }

            return tax;
        }
    }
}
