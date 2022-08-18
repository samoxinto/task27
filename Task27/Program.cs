using System;

namespace Task27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string number = Console.ReadLine();

            int result = 0;
            for (int i = 0; i < number.Length; i++)
                result += int.Parse(number[i].ToString());

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
