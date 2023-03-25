using System.Security.Cryptography.X509Certificates;

namespace Class05_Exercise_02
{
    public class Dog
    {
        public string Name { get; set; }

        public string Race { get; set; }

        public string Color { get; set; }

        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }

        public string Eat()
        {
            return $"The dog is now eating";
        }

        public string Play()
        {
            return $"The dog is now playing";
        }

        public string ChaseTail()
        {
            return $"Dog is now chasing its tail";
        }
    }
}
