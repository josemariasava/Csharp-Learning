using System;

namespace DataTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Variable Declaration and Types
            string fullName = string.Empty;
            int age = 0;
            double salary = 0;
            char gender = char.MinValue;
            bool working; // binary value, default is false

            // Ask user to enter all this value and store to variable's

            Console.Write("Enter your name : ");
            fullName = Console.ReadLine();

            /*ReadLine() accept only string from the terminal
             * we can use Convert() built in class in C# to convert the value from string to datatype we need
            */
            Console.Write("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your salary : ");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your gender (M or F) : ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Are you working (true or false) ? ");
            working = Convert.ToBoolean(Console.ReadLine());


            // Print information stored in variables

            Console.WriteLine("Name: {0} Age: {1} Salary: {2} ", fullName, age, salary); // placeholder
            Console.WriteLine($"Gender: {gender} Working: {working}"); // interpolation

        }
    }
}
