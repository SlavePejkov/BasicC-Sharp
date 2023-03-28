namespace Class07_Exercises01
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        private string Department { get; set; }

        public Manager(string firstName, string lastName, double salary, string department) : base(firstName, lastName, RoleEnum.Manager, salary)
        {
            Bonus = 0;
            Department = department;
        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }

        public string GetCurrentPosition()
        {
            return Department;
        }
    }
}
