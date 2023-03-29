namespace Class08_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>()
            {
                {"Slave", "078888524" },
                {"John", "+38977456" },
                {"Bob", "077668899" },
                {"Risto", "074858212" },
                {"Tijana", "078456123" }
            };

            Console.Write("Please enter a name: ");
            string name = Console.ReadLine();

            bool foundPerson = false;

            foreach(KeyValuePair<string, string> pair in PhoneBook)
            {
                if (pair.Key.ToLower() == name.ToLower())
                {
                    Console.WriteLine($"\t{pair.Key} - {pair.Value}");
                    foundPerson = true;
                    break;
                }              
            }
            if (!foundPerson)
            {
                Console.WriteLine("The name that you are searching for does not exist.");
            }

        }
    }
}