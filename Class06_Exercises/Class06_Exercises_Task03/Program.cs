namespace Class06_Exercises_Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User[] users = new User[4];
            string[] messages1 = new string[3] { "Hello my friend", "I need you at work", "What are you doing later" };
            string[] messages2 = new string[2] { "Hey Bryan, want to play basketball later", "Where are you?" };
            string[] messages3 = new string[3] { "Im making coffe do you want some", "I cant find the keys", "Good morning!" };
            string[] messages4 = new string[0];


            users[0] = new User { Id = 151, Username = "User234", Password = "mypAss23", Messages = messages1 };
            users[1] = new User { Id = 4562, Username = "User7824", Password = "password", Messages = messages2 };
            users[2] = new User { Id = 1498, Username = "User12435", Password = "hello123", Messages = messages3 };


            Console.WriteLine("If you want to Log in press 1, if you want to Register press 2:");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Wrong Input");
            }
            else if (number < 1 || number > 2)
            {
                Console.WriteLine("Wrong Input");

            }

            switch (number)
            {
                case 1:
                    Console.WriteLine("Enter your username");
                    string username = Console.ReadLine();

                    Console.WriteLine("Enter your password");
                    string password = Console.ReadLine();

                        if (username == users[0].Username && password == users[0].Password)
                        {
                            Console.WriteLine($"Welcome {users[0].Username}, Here are your messages: \n \t- {users[0].Messages[0]} \n \t- {users[0].Messages[1]} \n \t- {users[0].Messages[2]}");
                            return;

                        }else if(username == users[1].Username && password == users[1].Password)
                        {
                            Console.WriteLine($"Welcome {users[1].Username}, Here are your messages: \n \t- {users[1].Messages[0]} \n \t- {users[1].Messages[1]}");
                            return;
                        } else if(username == users[2].Username && password == users[2].Password)

                        {
                            Console.WriteLine($"Welcome {users[2].Username}, Here are your messages: \n \t- {users[2].Messages[0]} \n \t- {users[2].Messages[1]} \n \t- {users[2].Messages[2]}");
                            return;
                        }  
                    break;

                case 2:
                    Console.WriteLine("Please ender id");
                    if (!int.TryParse(Console.ReadLine(), out int idNum))
                    {
                        Console.WriteLine("Wrong Input");
                        return;
                    }

                    Console.WriteLine("Please enter username:");
                    string username3 = Console.ReadLine();

                    Console.WriteLine("Please enter password:");
                    string password3 = Console.ReadLine();
                    
                        if(username3 == users[0].Username || username3 == users[1].Username || username3 == users[2].Username)
                        {
                            Console.WriteLine("There is already an existing username by that name");
                            return;
                        }
                    
                    users[3] = new User { Id = idNum, Username = username3, Password = password3, Messages = messages4};
                    Console.WriteLine("Registration Complete! Users:");

                    foreach (User user in users)
                    {
                        Console.WriteLine($"{user.Id} {user.Username}");
                    }
                    break;
                    

            }
        }
    }
}