﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        //TODO: Write a C# program to test if an array contains a specific value.
        private static void Main(string[] args)
        {
            int[] myArray = {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            for (int i = 0; i < myArray.Length; ++i)
            {
                int targetNumber = 1899;
                if (myArray[i] == targetNumber)
                {
                    Console.WriteLine("Contains!");
                    Console.ReadKey();
                }
               
            }

            /*
            fixme - check if contains number 1245 
            for (?) {
                ......
                Console.WriteLine("Contains!");
            }
            */
        }
    }
}
