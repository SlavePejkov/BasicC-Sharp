namespace Class04_Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter + or -");
            string usersInput = Console.ReadLine();

           

            if (usersInput != "-" && usersInput != "+")
            {
                Console.WriteLine("Please enter the correct symbols");              
            }

            Console.WriteLine("Please enter two numbers");
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            bool firstParsedNumber = int.TryParse(firstNumber, out int usersFirstNumber);
            bool secondParsedNumber = int.TryParse(secondNumber, out int usersSecondNumber);

            if(!firstParsedNumber || !secondParsedNumber)
            {
                Console.WriteLine("Please enter a valid number");
            }

            static int Sum (int num1, int num2)
            {
                return num1 + num2;
            }

            

            static int Substract(int num1, int num2)
            {
                return num1 - num2;
            }
           

            switch (usersInput)
            {
                case "-":
                    Console.WriteLine("The result is: " + Substract(usersFirstNumber, usersSecondNumber));
                    break;
                case "+":
                    Console.WriteLine("The result is: " + Sum(usersFirstNumber, usersSecondNumber));
                    break;
            }

        }
    }
}