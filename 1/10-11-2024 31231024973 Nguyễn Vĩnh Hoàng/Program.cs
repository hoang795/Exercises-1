using System;

namespace NguyenVinhHoang_31231024973
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Question1
            Question1();
            // Question2
            Question2();
            // Question3
            Question3();
            // Question4
            Question4();
            // Question5
            Question5();
            // Question6
            Question6();
            // Question7
            Question7();
            // Question8
            Question8();
            // Question9
            Question9();
            // Question10
            Question10();
        }

        static void Question1()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 + num2;
            Console.WriteLine($"Sum: {sum}");
        }

        static void Question2()
        {
            Console.Write("Enter first value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            (a, b) = (b, a); 
            Console.WriteLine($"After swapping: a = {a}, b = {b}");
        }

        static void Question3()
        {
            Console.Write("Enter first floating point number: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter second floating point number: ");
            float num2 = Convert.ToSingle(Console.ReadLine());
            float product = num1 * num2;
            Console.WriteLine($"Product: {product}");
        }

        static void Question4()
        {
            Console.Write("Enter feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            double meters = feet * 0.3048;
            Console.WriteLine($"{feet} feet is equal to {meters} meters");
        }

        static void Question5()
        {
            Console.Write("Enter temperature (C for Celsius, F for Fahrenheit, e.g., 32C): ");
            string input = Console.ReadLine().Trim();
            char scale = input[^1]; 
            double temperature = Convert.ToDouble(input[0..^1]); 

            if (scale == 'C' || scale == 'c')
            {
                double fahrenheit = (temperature * 9 / 5) + 32;
                Console.WriteLine($"{temperature}C is {fahrenheit}F");
            }
            else if (scale == 'F' || scale == 'f')
            {
                double celsius = (temperature - 32) * 5 / 9;
                Console.WriteLine($"{temperature}F is {celsius}C");
            }
           
        }

        static void Question6()
        {
            Console.WriteLine($"Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");
            Console.WriteLine($"Size of char: {sizeof(char)} bytes");
            Console.WriteLine($"Size of long: {sizeof(long)} bytes");
            Console.WriteLine($"Size of byte: {sizeof(byte)} bytes");
        }

        static void Question7()
        {
            Console.Write("Enter a character: ");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nASCII value of '{character}': {(int)character}");
        }

        static void Question8()
        {
            Console.Write("Enter radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Area of the circle: {area}");
        }

        static void Question9()
        {
            Console.Write("Enter side length of the square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double area = Math.Pow(side, 2);
            Console.WriteLine($"Area of the square: {area}");
        }

        static void Question10()
        {
            Console.Write("Enter number of days: ");
            int days = Convert.ToInt32(Console.ReadLine());
            int years = days / 365;
            days %= 365;
            int weeks = days / 7;
            days %= 7;
            Console.WriteLine($"{years} years, {weeks} weeks, {days} days");
        }
    }
}
