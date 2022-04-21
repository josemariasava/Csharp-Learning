using System;

namespace MathOperators
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /***
            Basic Assignment Operator
            ***/

            // case 1 
            int num;
            num = 5; // = --> tutto quello a destra dell operatore = viene assegnato alla variabile che sta a sinistra

            // case 2
            int num1 = 10; // Stesso concetto espresso sopra, con una singola riga di codice


            /*** 
            Arithmetic Operators
            ***/

            Console.WriteLine($"Addition : {num + num1}"); // somma
            Console.WriteLine($"Subtraction : {num - num1}"); // sottrazione
            Console.WriteLine($"Moltiplication : {num * num1}"); // moltiplicazione
            Console.WriteLine($"Division : {num / num1}"); // Division

            /* Tutte operazioni basilari. Tramite le diverse librerie di c# possiamo accedere 
             * a diversi metodi per effettuare calcoli più complessi 
             */

            /***
            Compund Assignment Operators
            ***/

            int num3 = 10;
            Console.WriteLine("Valore inizale variabile = {0}", num3);

            num3 += 4; // variabile num3 + 4
            Console.WriteLine("valore + 4 : {0}", num3);
            num3 -= 2; // variabile num3 - 2
            Console.WriteLine("valore - 2 : {0}", num3);
            num3 *= 3; // Valore moltiplicato 3 volte
            Console.WriteLine("valore moltiplicato 3 : {0}", num3);
            num3 /= 2; // diviso 2
            Console.WriteLine("valore diviso 2 : {0}", num3);

        }
    }
}
