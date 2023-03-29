namespace Class07_Homework02
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        
        public Rectangle(string name, string color, int[] position, int sideA, int sideB)
            : base(name, color, position)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public override void GetArea()
        {
            int area = SideA * SideB;
            Console.WriteLine($"The area of the {Name} rectangle is {area}");
        }

        public override void GetPerimeter()
        {
            int perimeter = 2 * (SideA + SideB);
            Console.WriteLine($"The perimeter of the {Name} rectangle is {perimeter}");
        }
    }
}

