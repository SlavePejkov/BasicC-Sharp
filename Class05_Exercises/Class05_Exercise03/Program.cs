namespace Class05_Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student[] students = new Student[5];

            students[0] = new Student { Name = "Slave", Academy = "SEDC", Group = "G7" };
            students[1] = new Student { Name = "Stojan", Academy = "Seavus", Group = "G9" };
            students[2] = new Student { Name = "Riste", Academy = "Brainster", Group = "G1" };
            students[3] = new Student { Name = "Tijana", Academy = "SEDC", Group = "G6" };
            students[4] = new Student { Name = "Ognen", Academy = "SEDC", Group = "G4" };

            Console.WriteLine("Please enter a name");
            string userInput = Console.ReadLine();
            

            if(userInput == "Slave")
            {
                Console.WriteLine($"Name: {students[0].Name}");
                Console.WriteLine($"Academy: {students[0].Academy}");
                Console.WriteLine($"Group: {students[0].Group}");
            } 
            else if(userInput == "Stojan")
            {
                Console.WriteLine($"Name: {students[1].Name}");
                Console.WriteLine($"Academy: {students[1].Academy}");
                Console.WriteLine($"Group: {students[1].Group}");
            } 
            else if (userInput == "Riste")
            {
                Console.WriteLine($"Name: {students[2].Name}");
                Console.WriteLine($"Academy: {students[2].Academy}");
                Console.WriteLine($"Group: {students[2].Group}");
            } 
            else if(userInput == "Tijana")
            {
                Console.WriteLine($"Name: {students[3].Name}");
                Console.WriteLine($"Academy: {students[3].Academy}");
                Console.WriteLine($"Group: {students[3].Group}");
            }
            else if (userInput == "Ognen")
            {
                Console.WriteLine($"Name: {students[4].Name}");
                Console.WriteLine($"Academy: {students[4].Academy}");
                Console.WriteLine($"Group: {students[4].Group}");
            }
            else
            {
                Console.WriteLine("The student that you are looking for doesnt exist");
            }
        }
    }
}