using System.Reflection.Metadata.Ecma335;

namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some numbers");
            

            string input1 = Console.ReadLine();
            int intInputOne = int.Parse(input1);
            

            string input2 = Console.ReadLine();
            int intInputTwo = int.Parse(input2);
            

            string input3 = Console.ReadLine();
            int intInputThree = int.Parse(input3);
            

            string input4 = Console.ReadLine();
            int intInputFour = int.Parse(input4);
           

            string input5 = Console.ReadLine();
            int intInputFive = int.Parse(input5);
            

            string input6 = Console.ReadLine();
            int intInputSix = int.Parse(input6);
            

          


            int sum = 0;
            int[] sumOfEven = new int[6] { intInputOne, intInputTwo, intInputThree, intInputFour, intInputFive, intInputSix };

            for (int i = 0; i < sumOfEven.Length; i++)
            {
                if (sumOfEven[i] % 2 == 0)
                {
                    sum += sumOfEven[i];
                }
            }
            Console.WriteLine("The result is " + sum);

        }
    }
}