using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int line;// creating integer to know how many stars i want
            line = Convert.ToInt32(Console.ReadLine());// input
            for (int i = 1; i <= line; i++)//loop for 2d array
            {
                for (int j = 1; j <= line; j++)// also loop for 2d array
                {
                    if (i == j)// condition to output external stars
                    {
                        Console.Write("[*]");
                    }
                    if (i > j)// conditon for internal stars
                        Console.Write("[*]");
                }
                Console.Write("\n");//to complete star stair

            }
            Console.ReadKey();// to console won't close
            
        }
                }
            }
        
    

