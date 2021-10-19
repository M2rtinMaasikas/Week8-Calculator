using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma nimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("sisesta oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());

            SayHello(userName, userAge);
        }
        private static void SayHello(string someName, int someNumber)
        {
            Console.WriteLine($"Tere, 3{someName}!");
            Console.WriteLine($"oled sündinud aastal {2021 - someNumber}.");



        }
    }
}
