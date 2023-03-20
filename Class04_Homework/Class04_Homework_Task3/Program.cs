using System;
using System.Security.Cryptography.X509Certificates;

namespace Class04_Homework_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num;
            num = Convert.ToInt32(Console.ReadLine());


            static void Usersinputednumber(int number)
            {
                string stringNum = Convert.ToString(number);
                int sum = 0;

                for (int i = 0; i < stringNum.Length; i++)
                {
                    sum += Convert.ToInt32(stringNum.Substring(i, 1));
                    
                }
                Console.WriteLine("The sum of the numbers is: " + sum);

            }
            Usersinputednumber(num);
        }
        
    }
}