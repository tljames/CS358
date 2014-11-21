//ChangeMaker App  Author:Tim James
//This program computes the amount of quarters, dimes, nickels and pennies that it would take to give change for input amount under one dollar.

using System;


namespace ChangeMaker
{
    class ChangeMakerApp
    {
        static void Main()
        {
            int CHANGE;
            //Input amount of change here in integer form.
            CHANGE = 87;

            //Computations and display of results.
            Console.WriteLine("The coins returned for " + CHANGE + " cents are");
            Console.WriteLine("");
            Console.WriteLine((CHANGE / 25) + " Quarters");
            CHANGE = CHANGE % 25;
            Console.WriteLine("");
            Console.WriteLine((CHANGE / 10) + " Dimes");
            CHANGE = CHANGE % 10;
            Console.WriteLine("");
            Console.WriteLine((CHANGE / 5) + " Nickels");
            CHANGE = CHANGE % 5;
            Console.WriteLine("");
            Console.WriteLine(CHANGE + " Pennies");
            Console.Read();
        }
    }
}
