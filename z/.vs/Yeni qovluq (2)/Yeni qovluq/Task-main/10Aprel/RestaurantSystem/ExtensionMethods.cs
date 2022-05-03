using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantSystem
{
    public static class ExtensionMethods
    {
        public static double DoubleInput(this string command, string message1, string message2)
        {
            Console.WriteLine(message1);
            string inputStr = command;
            double inputDouble;
            while (!double.TryParse(inputStr, out inputDouble))
            {
                Console.WriteLine(message2);
                inputStr = Console.ReadLine();
            }
            double.TryParse(inputStr, out inputDouble);
            return inputDouble;
        }
        public static string StringInput(this string command, string message)
        {
            Console.WriteLine(message);
            return command;
        }
        public static int IntInput(this string command ,string message1, string message2)
        {
            Console.WriteLine(message1);
            string inputStr = command;
            int inputInt;
            while (!int.TryParse(inputStr, out inputInt))
            {
                Console.WriteLine(message2);
                inputStr = Console.ReadLine();
            }
            int.TryParse(inputStr, out inputInt);
            return inputInt;
        }
    }
}
