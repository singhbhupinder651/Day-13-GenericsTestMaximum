﻿namespace FindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {

            FindMax findMax = new FindMax();

            int result = findMax.FindMaxInteger(150, 100, 5);

            Console.WriteLine("Greatest number among three numbers is : " + result);

        }
    }
}