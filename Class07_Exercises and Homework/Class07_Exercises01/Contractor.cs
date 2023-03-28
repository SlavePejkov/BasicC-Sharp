using System.Text.RegularExpressions;

namespace Class07_Exercises01
{
    public class Contractor : Employee
    {
        private double WorkHours { get; set; }
        private int PayPerHour { get; set; }
        private Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Manager responsible) : base(firstName, lastName, RoleEnum.Contractor, 0)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            
            double salary = WorkHours * PayPerHour;
            salary = Salary;
            return salary;
            
        }

        public string CurrentPosition()
        {
            return Responsible.GetCurrentPosition();
        }



    }
}
