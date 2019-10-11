using System;

namespace open_lab_02._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write two numbers.");
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            int a = Convert.ToInt32(number1);
            int b = Convert.ToInt32(number2);
            int c = a % b;
            Console.WriteLine(c);

        }
    }
}
