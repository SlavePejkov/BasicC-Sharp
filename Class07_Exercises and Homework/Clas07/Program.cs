using Class07_Exercises01;
namespace Clas07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, to our company!");

            SalesPerson salesPerson1 = new SalesPerson("Sales", "One");
            SalesPerson salesPerson2 = new SalesPerson("Sales", "Two");

            Manager manager = new Manager("Bob", "Bobski", 1500, "Deparment of Seavus");

            salesPerson1.AddSuccessRevenue(300);
            salesPerson2.AddSuccessRevenue(500);

            salesPerson2.AddSuccessRevenue(300);
            salesPerson1.AddSuccessRevenue(2000);

            manager.AddBonus(450);

            //Console.WriteLine(salesPerson1.GetInfo());
            //Console.WriteLine(salesPerson2.GetInfo());
            //Console.WriteLine(manager.GetInfo());

            Employee otherEmployee = new Employee("Risto", "Panchevski", RoleEnum.Other, 300);

            //HomeworkTask1;
            Employee anotherEmploye1 = new Employee("Slave", "Pejkov", RoleEnum.Other, 450);
            Employee anotherEmploye2 = new Employee("John", "Doe", RoleEnum.Other, 200);



            //Console.WriteLine(otherEmployee.GetInfo());

            Employee[] Company = new Employee[5];

            Manager manager1 = new Manager("Mark", "Cuban", 5000, "Dallas Mavericks");
            Manager manager2 = new Manager("Jack", "Thomson", 2000, "Deparment ingeneering");

            Contractor contractor1 = new Contractor("Marko", "Stojanovski", 42, 50, manager1);
            Contractor contractor2 = new Contractor("Ilija", "Perovski", 40, 45, manager2);

            SalesPerson salesPerson = new SalesPerson("Tom", "Jerry");

            Company[0] = manager1;
            Company[1] = manager2;
            Company[2] = contractor1;
            Company[3] = contractor2;
            Company[4] = salesPerson;

            CEO ceo1 = new CEO("Maria", "Doe", 15000, Company, 100, 50);
            Console.WriteLine(ceo1.GetInfo());
            ceo1.PrintEmployees();
            Console.WriteLine(ceo1.GetSalary());
            


        }
    }
}