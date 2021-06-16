using System;
using System.Collections.Generic;
using System.Globalization;
using TaxPayersEx.Entities;

namespace TaxPayersEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayers> listOfTaxPayers = new List<TaxPayers>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfTaxPayers.Add(new Individual(healthExpenditures, name, annualIncome));
                } 
                else
                {
                    Console.Write("Number of employess: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    listOfTaxPayers.Add(new Company(numberOfEmployees, name, annualIncome));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double sum = 0.0;
            foreach(TaxPayers payers in listOfTaxPayers)
            {
                Console.WriteLine(payers.Name + ": $ " + payers.Tax().ToString("F2", CultureInfo.InvariantCulture));
                sum += payers.Tax();
            }
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));

         
        }
    }
}
