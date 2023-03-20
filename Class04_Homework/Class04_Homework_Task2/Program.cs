namespace Class04_Homework_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plaease write a sentence");
            string usersInput = Console.ReadLine();
            string[] words = usersInput.Split(" ");

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}