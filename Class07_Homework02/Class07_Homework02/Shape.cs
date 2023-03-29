
namespace Class07_Homework02
{
    public class Shape
    {
        private string _name;
        private string _color;
        public string Name
        {
            get
            {
                Console.WriteLine("Getting the name");
                return _name;
            }
            set
            {
                if (value ==  null || value == "")
                {
                    Console.WriteLine("Wrong input");
                }
                else 
                {
                    Console.WriteLine($"Setting name to '{value}'");
                    _name = value;
                    
                }
                
            }
        }
        public string Color
        {
            get
            {
                Console.WriteLine("Getting the color");
                return _color;
            }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("Wrong input");
                }
                else
                {
                    Console.WriteLine($"Setting color to '{value}'");
                    _color = value;
                }
               
            }
        }
        public int[] Position { get; set; }

        public Shape(string firstName, string color, int[] position)
        {
            Name = firstName;
            Color = color;
            Position = position;
        }
        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for Area");
        }

        public virtual void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter");
        }

        public static void Move(Shape shape)
        {
            shape.Position[0] += 5;
            shape.Position[1] += 5;
        }



    }
}
