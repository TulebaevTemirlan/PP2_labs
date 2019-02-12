using System;

namespace TasK
{
    class Student//Created class 
    {
        public string name;//method_name;
        public string  id;//method_id
        public int year;//method year

        //public to use this methods in constructor

        public Student(string name , string  id , int year )//constructor to transfer values to methods
        {
            this.name = name;
            this.id = id;
            this.year = year;

            Print();//called a function

        }

        public void Print()//created function which will output values;
        {
            Console.WriteLine("Name : " + name);//to output value in nice_format
            Console.WriteLine("ID : " + id);//to output value in nice_format
            Console.WriteLine("Year : " + year);//to output value in nice_format

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Zeus","18BD11056" , 1);//created new_student
            
            Console.ReadKey();//to console won't close
        }
    }
}

