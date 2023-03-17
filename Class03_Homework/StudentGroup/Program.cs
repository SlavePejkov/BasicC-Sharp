namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] studentsG1 = new string[5] { "Slave", "Marko", "Darko", "Sarko", "Anja" };
            string[] studentsG2 = new string[5] { "Ivan", "Mile", "Mia", "Andrea", "Goran" };

            Console.WriteLine("Please enter the numbers 1 or 2");
            string usersGroup = Console.ReadLine();

            int usersInputedNumber;
            bool convertedNumber = int.TryParse(usersGroup, out usersInputedNumber);

            if (!convertedNumber)
            {
                Console.WriteLine("Please enter a valid number");
            }else if(usersInputedNumber > 2 || usersInputedNumber < 1)
            {
                Console.WriteLine("Please enter the correct number");
            }
            
            if(usersInputedNumber == 1)
            {
                Console.WriteLine("The students in G1 are:");

                foreach (string name in studentsG1)
                {
                    Console.WriteLine(name);
                }
            }else if(usersInputedNumber == 2)
            {
                Console.WriteLine("The students in G2 are:");

                foreach (string name in studentsG2)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}