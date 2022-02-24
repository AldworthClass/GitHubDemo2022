using System;

namespace First_CSharp_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double age;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{name}, next year you will be {age + 1}");

        }
    }
}
