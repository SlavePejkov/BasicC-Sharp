namespace Class05_Exercise_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your dogs name?");
            string dogsName = Console.ReadLine();

            Console.WriteLine("What king of dog is it?");
            string dogRace = Console.ReadLine();

            Console.WriteLine("What color is your dog?");
            string colorOfDog = Console.ReadLine();

            Dog dogOne = new Dog(dogsName, dogRace, colorOfDog);

            Console.WriteLine("Please choose a number 1, 2 or 3");
            string usersInput = Console.ReadLine();

            bool parsedNum = int.TryParse(usersInput, out int num);

            if (!parsedNum)
            {
                Console.WriteLine("Please enter a valid number");
                
            }
            switch (num)
            {
                case 1:
                    Console.WriteLine(dogOne.Eat());
                    break;
                case 2:
                    Console.WriteLine(dogOne.Play());
                    break;

                case 3:
                    Console.WriteLine(dogOne.ChaseTail());
                    break;

                default:
                    Console.WriteLine("Enter correct number");
                    break;

                

            }
        }
    }
}