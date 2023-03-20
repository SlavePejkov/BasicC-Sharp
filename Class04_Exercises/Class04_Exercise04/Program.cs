using System.Text;

namespace Class04_Exercise04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(DateTime.Now.AddDays(3));
            Console.WriteLine(DateTime.Now.AddMonths(1));
            Console.WriteLine(DateTime.Now.AddMonths(1).AddDays(3));
            Console.WriteLine(DateTime.Now.AddYears(-1).AddMonths(-2));
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.ToString("MMMM"));
            Console.WriteLine(DateTime.Now.Year);

           



        }
    }
}