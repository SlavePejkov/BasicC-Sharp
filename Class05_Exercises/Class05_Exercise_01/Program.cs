using System.Text;

namespace Class05_Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("What is your first name?");
            string usersFirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string usersLastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            string usersAge = Console.ReadLine();

            bool parsedAge = int.TryParse(usersAge, out int age);
            if (!parsedAge)
            {
                Console.WriteLine("Please enter a valid age");
            }


            Human personOne = new Human(usersFirstName, usersLastName, age);

            Console.WriteLine(personOne.GetPersonStats());
        }
    }
}