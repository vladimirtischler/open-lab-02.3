using System;

namespace open_lab_02._3
{
    class Program
    {
        public static int Sum(int a, int b)

        {
            return (a % b);

        }
        static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(number1, number2));

        }
    }
}
