using System;

namespace InputOutput
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Declare Variable -- a storage space in memory

            /* 
              -- Data types --

                string --> Words/numbers ( Name, Surname, license plate ) - "Name", " Hello world"
                int --> whole numbers
                duble/float --> decimals
                char --> One cahracter ( 'a', 'b', '7', '%' )
            */

            // impossible to use space in variable's name 

            string userName; // use clear name for variable declaration 
            int userAge; // camelCase 


            // Allow user input and store in variable

            Console.WriteLine("Insert your name: ");
            userName = Console.ReadLine(); // Assign value to the variable 

            Console.WriteLine("Insert your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());


            // Print contents of variable/user's input
            Console.WriteLine("Name inserted = " + userName);
            Console.WriteLine("Age inserted = " + userAge);

        }
    }
}
