namespace Class04_Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check your c:\\ drive");
            Console.WriteLine("We will have" + " " + "fair" + " " + "elections");
            Console.WriteLine("The \\n sign means: new line");

            //Console.WriteLine(@"Check your c:\ drive");
            //Console.WriteLine(@"We will have ""fair"" elections");
            //Console.WriteLine(@"The \n sign means: new line");

            //Exercise 03;
            Console.WriteLine("Please enter a number");
            string usersNumber = Console.ReadLine();

            bool parsedNumber = int.TryParse(usersNumber, out int number);
            if (!parsedNumber)
            {
                Console.WriteLine("Please enter a valid number");
            }
            else if (number > 31)
            {
                Console.WriteLine("Please enter a smaller number");
            }

            static void  Substring(int n)
            {
                string myString = "Hello from SEDC Codecademy 2023";
                if(n > myString.Length)
                {
                    n = myString.Length;
                }

                string substring = myString.Substring(0, n);

                Console.WriteLine(substring);
                Console.WriteLine(substring.Length);



            }
            Substring(number);

        }
    }
}