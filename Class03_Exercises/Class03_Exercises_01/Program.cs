namespace Class03_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Exercise 01;
            Console.WriteLine("Please enter a number");
            string firstInput = Console.ReadLine();

            int usersInputOne;
            bool parsedInputOne = int.TryParse(firstInput, out usersInputOne);

            for(int i = 1; i <= usersInputOne; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Please enter another number");
            string secondInput = Console.ReadLine();

            int usersInputTwo;
            bool parsedInputTwo = int.TryParse(secondInput, out usersInputTwo);

            for (int j = usersInputTwo; j >= 1; j--)
            {
                Console.WriteLine(j);
            }

            

        }
    }
}