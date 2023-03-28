namespace Class07_Exercises01
{
    public class CEO : Employee
    {
        Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public CEO(string firstName, string lastName, double salary, Employee[] employees, int shares, double sharesPrice)
        : base(firstName, lastName, RoleEnum.Other, salary)
        {
            Employees = employees;
            Shares = shares;
            SharesPrice = sharesPrice;
        }

        public void AddShares(double number)
        {
            SharesPrice += number;
        }

        public void PrintEmployees()
        {
            foreach(Employee employee in Employees)
            {
                Console.WriteLine(employee.GetInfo());
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }

    }
}
