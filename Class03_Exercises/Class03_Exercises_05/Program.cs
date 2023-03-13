namespace Class03_Exercises_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputOne = Console.ReadLine();
            int inputOneParsed = Convert.ToInt32(inputOne);

            string inputTwo = Console.ReadLine();
            int inputTwoParsed = Convert.ToInt32(inputTwo);

            string inputThree = Console.ReadLine();
            int inputThreeParsed = Convert.ToInt32(inputThree);

            string inputFour = Console.ReadLine();
            int inputFourParsed = Convert.ToInt32(inputFour);

            string inputFive = Console.ReadLine();
            int inputFiveParsed = Convert.ToInt32(inputFive);


            int[] integerArray = new int[5] {inputOneParsed, inputTwoParsed, inputThreeParsed, inputFourParsed, inputFiveParsed };

            int sum = 0;
            foreach(int item in integerArray)
            {
                sum += item;
                
            }
            Console.WriteLine(sum);

            //int sum = integerArray.Sum();
            //Console.WriteLine(sum);

        }
    }
}