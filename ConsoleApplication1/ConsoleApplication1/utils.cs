using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class utils
    {

        public static void PayEmployee( Employee[] myArray)
        {

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Termination == new DateTime(1900, 09, 9)) 
                {
                    Console.WriteLine((myArray[i].FirstName) + " has been terminated!");
                    Console.WriteLine(" ");
                }
                else {                 
                    Console.WriteLine(myArray[i].FirstName + " has been paid " + "$" + myArray[i].Rate * myArray[i].HoursWorked + " dollars.");
                    Console.WriteLine(" ");
                }
            }

        }
    }
}

