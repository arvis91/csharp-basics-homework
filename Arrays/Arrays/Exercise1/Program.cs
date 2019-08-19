using System;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Exercise1
{
    class Program
    {
        //TODO: Write a C# program to sort a numeric array and a string array.
        private static void Main(string[] args)
        {
            int[] myArray1 = {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2165, 1457, 2456
            };

            
            string[] myArray2 = {
                "Java",
                "Python",
                "PHP",
                "C#",
                "C Programming",
                "C++"
            };
            Array.Sort(myArray1);
            Console.WriteLine("Sorted: " + String.Join(",", myArray2));
            Array.Sort(myArray2);
            Console.WriteLine("Sorted :" + String.Join(",",myArray1));
            
            Console.WriteLine("Sorted :" + String.Join(":", myArray2));
            Console.ReadKey();



            /*
            fixme
            Console.WriteLine("Original numeric array : " + .........);
            ........... //Sort array
            Console.WriteLine("Sorted numeric array : " + .........);
    
            Console.WriteLine("Original string array : " + .........);
            ......... //Sort array
            Console.WriteLine("Sorted string array : " + .........);
            */
        }

        

        /* public static string Sorter(int[] a, int [] b)
        {
            Console.WriteLine("Sorted: " + Array.Sort(a));

        } */

    }
}
