
namespace Class07_Exercises01
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName) : base (firstName, lastName, RoleEnum.Sales, 500)
        {
            SuccessSaleRevenue = 0;
        }

        public void AddSuccessRevenue(double number)
        {
            SuccessSaleRevenue += number;
        }

        public override double GetSalary()
        {
            double basicSalary = base.GetSalary();

            double salaryPlusBonus = 0;

            if (SuccessSaleRevenue <= 2000)
            {
                salaryPlusBonus = basicSalary + 500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                salaryPlusBonus = basicSalary + 1000;
            }
            else
            {
                salaryPlusBonus = basicSalary + 1500;
            }

            return salaryPlusBonus;
        }
    }
}
