namespace Class05_Exercise_01
{
    class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human (string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public string GetPersonStats()
        {
            return $"The person is {FirstName} {LastName} {Age}";
        }
    }
}
