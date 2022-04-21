using System;

namespace ConditionalStatement
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // Definition of variables
            int num1;
            int num2;

            // Ask user to enter values for variables

            Console.WriteLine("Insert num1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert num2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            /*
             * IF Statements ( ==, <; >; >=; <=; != )
             */
            if (num1 > num2) // se num1 > num2 
            {
                Console.WriteLine("num1 maggiore di num2");
            }
            else if (num1 < num2) // altrimenti num1 < num2 
            {
                Console.WriteLine("num2 maggiore di num1");
            }
            else if (num1 == num2) // altrimenti num1 = num2 
            {
                Console.WriteLine("num1 uguale a num2");
            }
            else // altrimenti ultima alternativa 
            {
                Console.WriteLine("Nessun opzione valida");
            }

            // Definition of variables

            int number;

            // Ask user to enter values for variables

            Console.WriteLine("Inserisci numero : ");
            number = Convert.ToInt32(Console.ReadLine());

            /*
             * SWITCH Statements
             */

            switch(number)
            {
                case 0:
                    Console.WriteLine("Number caso 0"); // entra qui solo se viene digitato il valore 0 
                    break;
                case 10:
                    Console.WriteLine("Number caso 10"); // entra qui solo se viene digitato il valore 10 
                    break;
                case 50:
                    Console.WriteLine("Number caso 50"); // entra qui solo se viene digitato il valore 50 
                    break;
                case int i when (i >= 51 && i <= 100): // entra qui in tutti i caso il numero inserito sarà >=51.
                    /* Utile per iterare n volte un determinato caso, ed evitare di definire n casi per la stessa funzione
                       int i --> assume il valore della variabile inserita da tastiera
                     */
                    Console.WriteLine("Number sarà compreso tra 51 e 100, number da te inserito = " + number);
                    break;
                default: // caso di default, per qualsiasi valore che non soddisfa i casi precedenti mostrerà il messaggio non valido
                    Console.WriteLine("Number non valido per i casi descritti");
                    break;
            }

            /*
             * TERNARY 
             */

            /*            condizione     se vera     se falsa  */
            var message = num1 > num2 ? "n1 > n2" : "n2 > n1";

            Console.WriteLine(message);


        }
    }
}
