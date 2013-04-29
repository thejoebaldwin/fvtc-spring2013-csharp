using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Registrar
{
    class Program
    {
        static void Main(string[] args)
        {
            int intMenu = 0;
            string[] Classes = {
                                   "Intro to C#",
                                   "C# Intermediate",
                                   "Advanced Programming",
                                   "Project Delivery"
                               };

            int[] Seats = {
                              0,
                              4,
                              5,
                              2
                          };


            while (true)
            {

                for (int i = 0; i < Classes.Length; i++)
                {
                    Console.WriteLine(i.ToString() + ":" + Classes[i]);
                }
                //this is the exact same thing
                //int i = 0;
                //while (i < Classes.Length)
                //{
                //    i++;
                //}



                string strInput = string.Empty;
                do
                {
                    Console.Write("Please select an option:");
                    strInput = Console.ReadLine();

                } while (!Int32.TryParse(strInput, out intMenu)  || intMenu >= Classes.Length);

                Console.WriteLine(Classes[intMenu] + " has " + Seats[intMenu] + " seats");

                Console.Write("Press the enter key to quit");
                Console.ReadLine();
            }
        }
    }
}
