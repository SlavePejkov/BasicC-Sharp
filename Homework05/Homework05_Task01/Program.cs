namespace Homework05_Task01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter age");
            string age = Console.ReadLine();

            Human firstHuman = new Human(firstName, lastName, age);

            Console.WriteLine(firstHuman.GetPersonDetails());
        }
    }
}