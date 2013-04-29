using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoWhile
{
    class Program
    {
        const string PASSWORD = "";

        static void Main(string[] args)
        {
            string strInput = string.Empty;
            do
            {
                //password is wrong
                Console.WriteLine("Please enter your password:");
                strInput = Console.ReadLine();
            } while (strInput != PASSWORD);

            //if outside the while loop, 
            //  then they guessed correctly
            Console.WriteLine("You entered the correct password!");
            Console.Write("Press Any Key to Continue:");
            Console.ReadKey();

        }
    }
}
