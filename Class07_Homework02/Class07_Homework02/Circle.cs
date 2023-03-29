
namespace Class07_Homework02
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(string name, string color, int[] position, int radius)
            : base(name, color, position)
        {
            Radius = radius;
        }

        public override void GetArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"The area of the {Name} circle is {area:F2}.");
        }

        public override void GetPerimeter()
        {
            double perimeter = 2 * Math.PI * Radius;
            Console.WriteLine($"The perimeter of the {Name} circle is {perimeter:F2}.");
        }
    }
}
