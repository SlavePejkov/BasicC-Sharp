namespace Class06_Exercises_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "The whole group of G2 loves C#.They find learning this language fun and easy!";
            Console.WriteLine(myString);

            string[] splitString = myString.Split(".");
            Console.WriteLine(splitString[1]);
        }
    }
}