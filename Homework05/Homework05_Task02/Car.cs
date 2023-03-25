namespace Homework05_Task02
{
    internal class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            
        }
        public int CalculateSpeed()
        {
            int result = Driver.Level * Speed;
            return result;
        }
    }
}
