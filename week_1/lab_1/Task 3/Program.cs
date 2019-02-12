using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//created size_of_array

            string s = Console.ReadLine();//saved entering string_of_numbers

            string[] ss = s.Split(' ');//divided the entered string by spaces and saved to an array of string type

            int[] numbers = new int[n];//created new_integer_type_array

            for (int i = 0; i < n; i++)//created a loop , which will continue a times
            {
                int number = Convert.ToInt32(ss[i]);//convert elements of string_array to integer
                numbers[i] = number;//wrote the converted element in our integer_array
            }
            for (int i = 0; i < n; i++)//used a loop to print doubled_values_of_array
            {
                Console.Write(numbers[i] + " " + numbers[i] + " ");//Command to print values_of_array twice
            }
            Console.ReadKey();// to console won't close
        }
    }
}
