using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("Please select the Option: ");
            double result = 0;
            int option = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                result = addNumbers(num1, num2);
            }
            else if (option == 2)
            {
                result = subtractNumbers(num1, num2);
            }
            else if (option == 3){
                result = multiplyNumbers(num1, num2);
            }
            else if(option == 4)
            {
                result = divideNumbers(num1, num2);
            }
            Console.WriteLine("The result is = " + result);
        }

        static int addNumbers (int num1 , int num2)
        {
            return num1 + num2;
        }
        static int subtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }
        static int multiplyNumbers(int num1, int num2)
        {
            return num1 * num2;
        }
        static double divideNumbers(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
