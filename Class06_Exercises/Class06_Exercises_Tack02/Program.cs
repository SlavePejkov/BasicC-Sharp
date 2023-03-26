namespace Class06_Exercises_Tack02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            string input = Console.ReadLine();

            if (!decimal.TryParse(input, out decimal number))
            {
                Console.WriteLine("Wrong input, please try again!");
                
            }

            static void NumberStats(decimal n)
            {
                if(n < 0)
                {
                    Console.WriteLine("The number is negative");
                }else if(n == 0)
                {
                    Console.WriteLine("The numbers neither negative or positive");
                }
                else { Console.WriteLine("The number is positive"); }

                if (n % 1 == 0)
                {
                    Console.WriteLine("The number is an Integer");

                    if (n % 2 == 0)
                    {
                        Console.WriteLine("The number is Even");
                    }
                    else
                    {
                        Console.WriteLine("The number is Odd");
                    }
                }
                else
                {
                    Console.WriteLine("The number is a Decimal");
                }


            }
            NumberStats(number);
        }
    }
}