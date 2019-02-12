using System;

namespace Task_1
{
    class Program
    {
        public static bool IsPrime(int num)//created a function to check for primes
        {
            if (num == 1)// to execute 1
                return false;
            for(int i = 2; i <= Math.Sqrt(num); i++)//created a loop to move through array
            {
                if (num % i == 0)//made condition
                    return false;//if condition false return false
            }
            return true;//if true return true
        }
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

            int cnt = 0;//created a integer_variable
            for (int i = 0; i < n; i++)//used a loop to find number_of_primes in array
            {
                if (IsPrime(numbers[i]))//checked if function true/false
                {
                    cnt++;//increment cnt if comdition is true
                }
            }
            Console.WriteLine(cnt);//output of_number_of_primes
            for(int i = 0; i < n; i++)//useed a loop to find primes 
            {
                if (IsPrime(numbers[i]))//checked for true/false value to_be_prime
                {
                    Console.Write(numbers[i] + " ");//output primes if true_value
                }
            }

            Console.ReadKey();// to console won't close
        }
    }
}
