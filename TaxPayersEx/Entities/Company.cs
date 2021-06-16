namespace TaxPayersEx.Entities
{
    class Company : TaxPayers
    {
        public int NumberOfEmployess { get; set; }

        public Company(int numberOfEmployess, string name, double annualIncome)
            : base(name, annualIncome)
        {
            NumberOfEmployess = numberOfEmployess;
        }

        public override double Tax()
        {
            double tax;

            if(NumberOfEmployess <= 10)
            {
                tax = AnnualIncome * 0.16;
            }
            else
            {
                tax = AnnualIncome * 0.14;
            }
            return tax;
        }
    }
}
