namespace Class03_Exercises_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string inputOne = Console.ReadLine();

            int inputOneParsed;

            bool firstInput = int.TryParse(inputOne, out inputOneParsed);

            if (!firstInput)
            {
                Console.WriteLine("Please enter valid number");
            }

            for(int i = 2; i <= inputOneParsed; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"The even numbers are {i}");
                    
                }
            }

            Console.WriteLine("Please enter a number");
            string inputTwo = Console.ReadLine();

            int inputTwoParsed;
            bool SecondInput = int.TryParse(inputTwo, out inputTwoParsed);

            if (!SecondInput)
            {
                Console.WriteLine("Please enter a valid number");
            }

            for (int j = 1; j < inputTwoParsed; j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine($"The odd numbers are {j}");
                }
            }
        }
    }
}