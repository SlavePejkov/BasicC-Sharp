using System.Security.Cryptography.X509Certificates;

namespace Homework05_Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Driver driverOne = new Driver("Slave", 7);
            Driver driverTwo = new Driver("Marko", 9);
            Driver driverThree = new Driver("Risto", 6);
            Driver driverFour = new Driver("Alek", 4);


            Car carOne = new Car("Tesla", 1020, driverOne);
            Car carTwo = new Car("Ferrari", 986, driverTwo);
            Car carThree = new Car("Porsche", 502, driverThree);
            Car carFour = new Car("Mazda", 187, driverFour);

             static void RaceCars(Car carOne, Car carTwo)
            {
                int car1Speed = carOne.CalculateSpeed();
                int car2Speed = carTwo.CalculateSpeed();

                if (car1Speed > car2Speed)
                {
                    Console.WriteLine($"{carOne.Model} is faster than {carTwo.Model}");
                }
                else
                {
                    Console.WriteLine($"{carTwo.Model} is faster than {carOne.Model}");
                }
            }


            Console.WriteLine("Please select your first Car: \n Tesla (Number 1) \n Ferrari (Number 2) \n Porsche (Number 3) \n Mazda (Number 4)");
            
            string userCarInputOne = Console.ReadLine();
            bool parsedUserCarInputOne = int.TryParse(userCarInputOne, out int car1Number);
            
            if (!parsedUserCarInputOne)
            {
                Console.WriteLine("Wrong input");
            }

            Car car1;

            switch (car1Number)
            {
                case 1:
                    car1 = carOne;
                    break;
                case 2:
                    car1 = carTwo;
                    break;
                case 3:
                    car1 = carThree;
                    break;
                case 4:
                    car1 = carFour;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    return;
            }

            Console.WriteLine("Please select your driver for your first car: \n Slave (Number 1) \n Marko (Number 2) \n Risto (Number 3) \n Alek (Number 4)");
            
            string userDriverInputOne = Console.ReadLine();
            bool parsedUserDriverInputOne = int.TryParse(userDriverInputOne, out int driver1Number);

            if (!parsedUserDriverInputOne)
            {
                Console.WriteLine("Wrong input");
            }

            Driver driver1;

            switch (driver1Number)
            {
                case 1:
                    driver1 = driverOne;
                    break;
                case 2:
                    driver1 = driverTwo;
                    break;
                case 3:
                    driver1 = driverThree;
                    break;
                case 4:
                    driver1 = driverFour;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    return;
            }

            car1.Driver = driver1;

            Console.WriteLine("Please select your second car: \n Tesla (Number 1) \n Ferrari (Number 2) \n Porsche (Number 3) \n Mazda (Number 4)");
            
            string userCarInputTwo = Console.ReadLine();
            bool parsedUserCarInputTwo = int.TryParse(userCarInputTwo, out int car2Number);

            if (!parsedUserCarInputTwo)
            {
                Console.WriteLine("Wrong input");
            }

            Car car2;

            switch (car2Number)
            {
                case 1:
                    car2 = carOne;
                    break;
                case 2:
                    car2 = carTwo;
                    break;
                case 3:
                    car2 = carThree;
                    break;
                case 4:
                    car2 = carFour;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    return;
            }

            Console.WriteLine("Please select your driver for your second car: \n Slave (Number 1) \n Marko (Number 2) \n Risto (Number 3) \n Alek (Number 4)");
            
            string userDriverInputTwo = Console.ReadLine();
            bool parsedUserDriverInputTwo = int.TryParse(userDriverInputTwo, out int driver2Number);

            if (!parsedUserDriverInputTwo)
            {
                Console.WriteLine("Wrong input");
            }

            Driver driver2;

            switch (driver2Number)
            {
                case 1:
                    driver2 = driverOne;
                    break;
                case 2:
                    driver2 = driverTwo;
                    break;
                case 3:
                    driver2 = driverThree;
                    break;
                case 4:
                    driver2 = driverFour;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    return;
            }

            car2.Driver = driver2;

            RaceCars(car1, car2);
        }
        
    }
}