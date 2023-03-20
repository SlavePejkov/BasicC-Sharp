namespace Class04_Homework_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usersInput = Console.ReadLine();
            string lastFiveChars = usersInput.Substring(usersInput.Length - 5);
            Console.WriteLine(lastFiveChars);
            

        }
    }
}