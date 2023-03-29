using Class07_Homework02;
namespace Class07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Shape("First Shape", "Black", new int[] { 0, 0 });
            Shape shape2 = new Shape("Second Shape", "Red", new int[] { 10, 20 });

            Shape.Move(shape1);
            Shape.Move(shape2);

            Console.WriteLine($"Shape 1 is now at ({shape1.Position[0]}, {shape1.Position[1]})");
            Console.WriteLine($"Shape 2 is now at ({shape2.Position[0]}, {shape2.Position[1]})");

            Rectangle rectangle = new Rectangle("RectangleOne", "Blue", new int[] { 5, 5 }, 4, 6);

            Console.WriteLine($"The {rectangle.Name} has sides {rectangle.SideA} and {rectangle.SideB}.");
            Console.WriteLine($"The {rectangle.Name} is located at ({rectangle.Position[0]}, {rectangle.Position[1]}).");
            Console.WriteLine($"The {rectangle.Name} is {rectangle.Color}.");

            Shape.Move(rectangle);

            Console.WriteLine($"The {rectangle.Name} has been moved to ({rectangle.Position[0]}, {rectangle.Position[1]}).");

            rectangle.GetArea();
            rectangle.GetPerimeter();

            
            Circle circle = new Circle("Circle1", "Green", new int[] { 10, 10 }, 5);

            
            Console.WriteLine($"The {circle.Name} has radius {circle.Radius}.");
            Console.WriteLine($"The {circle.Name} is located at ({circle.Position[0]}, {circle.Position[1]}).");
            Console.WriteLine($"The {circle.Name} is {circle.Color}.");

            
            Shape.Move(circle);

            Console.WriteLine($"The {circle.Name} has been moved to ({circle.Position[0]}, {circle.Position[1]}).");


            circle.GetArea();
            circle.GetPerimeter();
        }
    }
}