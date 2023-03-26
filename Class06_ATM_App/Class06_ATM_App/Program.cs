using System.Globalization;

namespace Class06_ATM_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t \t \t \t Welcome to the ATM app");

            Customer[] customers = new Customer[4];
            customers[0] = new Customer("Josh", "234-124-555-487", "1872", 34.51m);
            customers[1] = new Customer("Mark", "274-144-755-123", "4379", 453.461m);
            customers[2] = new Customer("Bob", "789-124-456-124", "1837", 321.4m);
            customers[3] = new Customer("Jake", "741-852-963-427", "3461", 12234.34m);

            Console.WriteLine("Please ente your card number:");
            string cardNumber = Console.ReadLine();

            Console.WriteLine("Please ente your pin:");
            string usersPin = Console.ReadLine();
           
            bool foundPerson = false;

            foreach (Customer customer in customers)
            {
                
                if (cardNumber == customer.CardNumber && usersPin == customer.Pin)
                {                   
                    Console.WriteLine($"Welcome {customer.Name}");
                    foundPerson = true;

                    Console.WriteLine("What would you like to do: \n 1) Check Balance \n 2) Cash Withdrawal \n 3) Cash Deposit");

                    if (!int.TryParse(Console.ReadLine(), out int number))
                    {
                        Console.WriteLine("Wrong input");
                    }

                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Your current balance is {0:C}", customer.Balance);
                            break;

                        case 2:
                            Console.WriteLine("How much money would you like to withdrawal?");
                            decimal withdrawal = decimal.Parse(Console.ReadLine());

                            if(withdrawal > customer.Balance)
                            {
                                Console.WriteLine("You don't have enought money");
                            }
                            else
                            {                               
                                Console.WriteLine("You have succesfully withdrawal {0:C}", withdrawal);
                                Console.WriteLine("Now your balance is {0:C} ", customer.Balance - withdrawal);
                            }
                            break;

                        case 3:
                            Console.WriteLine("How much money would you like to deposit");
                            decimal depostit = decimal.Parse(Console.ReadLine(), NumberStyles.Currency);

                            if(depostit < 0)
                            {
                                Console.WriteLine("Wrong input");
                            }
                            else{
                                Console.WriteLine("You have succesfully deposited {0:C}", depostit);
                                decimal balancedeposit = customer.Balance + depostit;
                                Console.WriteLine("Now you have {0:C} in your bank account", balancedeposit);
                            }
                            break;
                    }
                }
            }

            if (!foundPerson)
            {
                Console.WriteLine("Invalid card number or pin");
                return;
            }

            Console.WriteLine("Thank you for using the ATM");

        }
    }
}