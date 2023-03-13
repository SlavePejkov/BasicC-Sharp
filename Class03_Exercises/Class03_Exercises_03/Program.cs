namespace Class03_Exercises_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string inputOne = Console.ReadLine();

            int inputOneParsed;

            bool firstInputParsed = int.TryParse(inputOne, out inputOneParsed);

            if (!firstInputParsed)
            {
                Console.WriteLine("Please enter a valid number");
            }

            for(int i = 1; i <= inputOneParsed; i++)
            {
                if(i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
                if(i == 100)
                {
                    Console.WriteLine("The limit is reached");
                    break;
                }
            }
        }
    }
}